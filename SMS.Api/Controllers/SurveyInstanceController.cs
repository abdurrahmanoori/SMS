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
    public class SurveyInstanceController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public SurveyInstanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/surveyinstance/getAll")]
        public async Task<IActionResult> GetSurveyInstanceList()
        {
            IEnumerable<SurveyInstance> surveyinstances = await _unitOfWork.SurveyInstanceRepository.GetAll();

            IEnumerable<SurveyInstanceResponseDto> results = surveyinstances.Select(temp => temp.ToSurveyInstanceResponseDto());

            return Ok(results);

        }



        [HttpPost("api/surveyinstance/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var surveyinstance = await _unitOfWork.SurveyInstanceRepository.GetFirstOrDefault(x => x.SurveyInstanceID == id);
            if (surveyinstance == null)
            {
                return NotFound("There is no SurveyInstance by this Id.");
            }
            SurveyInstanceResponseDto surveyinstanceResponseDto = surveyinstance.ToSurveyInstanceResponseDto();

            return Ok(surveyinstanceResponseDto);


        }

        [HttpPost("api/surveyinstance/create")]
        public async Task<IActionResult> Create(SurveyInstanceAddDto surveyinstanceAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            SurveyInstance surveyinstance = surveyinstanceAddDto.ToSurveyInstance();
            await _unitOfWork.SurveyInstanceRepository.Add(surveyinstance);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("SurveyInstance created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteSurveyInstance(int surveyinstanceId)
        {
            if (surveyinstanceId <= 0)
            {
                return BadRequest();
            }
            var surveyinstance = await _unitOfWork.SurveyInstanceRepository.GetFirstOrDefault(x => x.SurveyInstanceID == surveyinstanceId);
            if (surveyinstance is null)
            {
                return BadRequest();
            }
            await _unitOfWork.SurveyInstanceRepository.Remove(surveyinstance);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("SurveyInstance has been deleted successfully");
        }
    }
}
