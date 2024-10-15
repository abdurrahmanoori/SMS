using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RepositoryContracts.DTOs;
using RepositoryContracts.Generic;
using SMS.Entities;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalDegreeController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public EducationalDegreeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/educationaldegree/getAll")]
        public async Task<IActionResult> GetEducationalDegreeList()
        {
            IEnumerable<EducationalDegree> educationaldegrees = await _unitOfWork.EducationalDegreeRepository.GetAll();

            IEnumerable<EducationalDegreeResponseDto> results = educationaldegrees.Select(temp=>temp.ToEducationalDegreeResponse());

            return Ok(results);

        }



        [HttpPost("api/educationaldegree/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var educationaldegree = await _unitOfWork.EducationalDegreeRepository.GetFirstOrDefault(x => x.EducationalDegreeID == id);
            if (educationaldegree == null)
            {
                return NotFound("There is no educationaldegree by this Id.");
            }
            EducationalDegreeResponseDto educationaldegreeResponseDto = educationaldegree.ToEducationalDegreeResponse();

            return Ok(educationaldegreeResponseDto);


        }

        [HttpPost("api/educationaldegree/create")]
        public async Task<IActionResult> Create(EducationalDegreeAddDto educationaldegreeAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            EducationalDegree educationaldegree = educationaldegreeAddDto.ToEducationalDegree();
            await _unitOfWork.EducationalDegreeRepository.Add(educationaldegree);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("educationaldegree created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteEducationalDegree(int educationaldegreeId)
        {
            if (educationaldegreeId <= 0)
            {
                return BadRequest();
            }
            var educationaldegree = await _unitOfWork.EducationalDegreeRepository.GetFirstOrDefault(x => x.EducationalDegreeID == educationaldegreeId);
            if (educationaldegree is null)
            {
                return BadRequest();
            }
            await _unitOfWork.EducationalDegreeRepository.Remove(educationaldegree);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("educationaldegree has been deleted successfully");
        }
    }
}
