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
    public class SurveyInstanceQuestionController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public SurveyInstanceQuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("api/surveyinstancequestion/getAll")]
        public async Task<IActionResult> GetSurveyInstanceQuestionList()
        {
            IEnumerable<SurveyInstanceQuestion> surveyinstancequestions = await _unitOfWork.SurveyInstanceQuestionRepository.GetAll();

            IEnumerable<SurveyInstanceQuestionResponseDto> results = surveyinstancequestions.Select(temp => temp.ToSurveyInstanceQuestionResponseDto());

            return Ok(results);

        }



        [HttpPost("api/surveyinstancequestion/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var surveyinstancequestion = await _unitOfWork.SurveyInstanceQuestionRepository.GetFirstOrDefault(x => x.SurveyInstanceQuestionID == id);
            if (surveyinstancequestion == null)
            {
                return NotFound("There is no surveyinstancequestion by this Id.");
            }
            SurveyInstanceQuestionResponseDto surveyinstancequestionResponseDto = surveyinstancequestion.ToSurveyInstanceQuestionResponseDto();

            return Ok(surveyinstancequestionResponseDto);


        }

        [HttpPost("api/surveyinstancequestion/create")]
        public async Task<IActionResult> Create(SurveyInstanceQuestionAddDto surveyinstancequestionAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            SurveyInstanceQuestion surveyinstancequestion = surveyinstancequestionAddDto.ToSurveyInstanceQuestion();
            await _unitOfWork.SurveyInstanceQuestionRepository.Add(surveyinstancequestion);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("surveyinstancequestion created successfully");
        }
                                                             

        [HttpDelete]
        public async Task<IActionResult> DeleteSurveyInstanceQuestion(int surveyinstancequestionId)
        {
            if (surveyinstancequestionId <= 0)
            {
                return BadRequest();
            }
            var surveyinstancequestion = await _unitOfWork.SurveyInstanceQuestionRepository.GetFirstOrDefault(x => x.SurveyInstanceQuestionID == surveyinstancequestionId);
            if (surveyinstancequestion is null)
            {
                return BadRequest();
            }
            await _unitOfWork.SurveyInstanceQuestionRepository.Remove(surveyinstancequestion);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("survey has been deleted successfully");
        }
    }
}
