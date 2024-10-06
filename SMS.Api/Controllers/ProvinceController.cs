using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryContracts.DTOs;
using RepositoryContracts.Generic;
using SMS.Entities;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {    
        readonly IUnitOfWork _unitOfWork;

        public ProvinceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("api/province/getAll")]
        public async Task<IActionResult> GetProvinceList()
        {
            IEnumerable<Province> provinces= await _unitOfWork.ProvincesRepository.GetAll();
            IEnumerable<ProvinceResponseDto> result = provinces.Select(temp => temp.toProvinceResponseDto());
            return Ok(result);
        }
        [HttpGet("api/province/GetById")]
        public async Task<IActionResult> GetByID(int id) { 
        var province=await _unitOfWork.ProvincesRepository.GetFirstOrDefault(x=> x.Id==id);
            if (province == null) {
                return NotFound("There is no province by this Id.");
            }
            ProvinceResponseDto provinceResponseDto = province.toProvinceResponseDto();
            return Ok(provinceResponseDto);
        
        }
        [HttpPost("api/province/create")]
        public async Task<IActionResult> Create(ProvinceAddDto provinceAddDto) {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            Province province=provinceAddDto.toProvince();
            await _unitOfWork.ProvincesRepository.Add(province);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("Province created successfully");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) {
            if (id <= 0)
            {
                return BadRequest();
            }
            var province = await _unitOfWork.ProvincesRepository.GetFirstOrDefault(x=>x.Id==id);
            if (province is null)
            {
                return BadRequest();
            }
            await _unitOfWork.ProvincesRepository.Remove(province);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("Province Has been deleted!");

        }
    }
}
