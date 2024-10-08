using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryContracts.DTOs;
using RepositoryContracts.Generic;
using SMS.Entities;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        readonly IUnitOfWork _unitOfWork;

        public DistrictController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("api/district/getAll")]
        public async Task<IActionResult> GetDistrictList() { 
         IEnumerable<District> districts= await _unitOfWork.DistrictRepository.GetAll();
            IEnumerable<DistrictResponseDto> result = districts.Select(temp => temp.toDistrictResponseDto());
            return Ok(result);

        }
        [HttpGet("api/district/GetById")]
        public async Task<IActionResult> GetById(int id) { 
         var district= await _unitOfWork.DistrictRepository.GetFirstOrDefault(x=> x.DistrictId==id);
            if (district == null) {
                return NotFound("There is no district by this Id.");
            }
            DistrictResponseDto districtResponseDto = district.toDistrictResponseDto();
            return Ok(district);

        }
        [HttpPost("api/district/create")]
        public async Task<IActionResult> Create(DistrictAddDto districtAddDto) {
            if (ModelState.IsValid is not true) {  return BadRequest(); }
            District district= districtAddDto.toDistrict();
            await _unitOfWork.DistrictRepository.Add(district);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("District Created Successfully");
        
        }
        [HttpDelete("api/district/delete")]

        public async Task<IActionResult> Delete(int id) {
            if (id <= 0)
            {
                return BadRequest();
            }
            var district= await _unitOfWork.DistrictRepository.GetFirstOrDefault(x=> x.DistrictId==id);
            if (district == null) { return BadRequest(); }
            await _unitOfWork.DistrictRepository.Remove(district);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("District has been deleted");

        }
    }
}
