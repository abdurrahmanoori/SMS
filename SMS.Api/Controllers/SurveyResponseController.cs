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
    public class SurveyResponseController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public SurveyResponseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/surveyresponse/getAll")]
        public async Task<IActionResult> GetSurveyResponseList()
        {
            IEnumerable<SurveyResponse> surveyresponse = await _unitOfWork.SurveyResponseRepository.GetAll();

            IEnumerable<SurveyResponseResponseDto> results = surveyresponse.Select(temp => temp.ToSurveyResponseResponseDto());

            return Ok(results);

        }



        [HttpPost("api/surveyresponse/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var surveyresponse = await _unitOfWork.SurveyResponseRepository.GetFirstOrDefault(x => x.SurveyResponseID == id);
            if (surveyresponse == null)
            {
                return NotFound("There is no surveyresponse by this Id.");
            }
            SurveyResponseResponseDto surveyresponseResponseDto = surveyresponse.ToSurveyResponseResponseDto();

            return Ok(surveyresponseResponseDto);


        }

        [HttpPost("api/survey/create")]
        public async Task<IActionResult> Create(SurveyResponseAddDto surveyresponseAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            SurveyResponse surveyresponse = surveyresponseAddDto.ToSurveyResponse();
            await _unitOfWork.SurveyResponseRepository.Add(surveyresponse);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("surveyresponse created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteSurveyResponse(int surveyresponseId)
        {
            if (surveyresponseId <= 0)
            {
                return BadRequest();
            }
            var surveyresponse = await _unitOfWork.SurveyResponseRepository.GetFirstOrDefault(x => x.SurveyResponseID == surveyresponseId);
            if (surveyresponse is null)
            {
                return BadRequest();
            }
            await _unitOfWork.SurveyResponseRepository.Remove(surveyresponse);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("surveyesponse has been deleted successfully");
        }
    }
}
