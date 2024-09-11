
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SMS.Entities;
using SMS.ServicesContracts;
using SMS.ServicesContracts.Dto;

namespace SMS.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        //  private readonly IUnitOfWork _SurveyService;
        private readonly ISurveyService _surveyService;

        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpPost("Api/Create")]
        public async Task<IActionResult> Create(SurveyAddDto addSurveyDto)
        {
            var result = await _surveyService.AddSurvey(addSurveyDto);
            return Ok(result);

        }



        [HttpGet("Api/GetAll")]
        public async Task<IActionResult> GetSurveyList()
        {
            IEnumerable<SurveyResponseDto> results = await _surveyService.GetSurveyList();
            return Ok(results);

        }

        [HttpPost("Api/GetById")]
        public async Task<IActionResult> GitById(int id)
        {
            var Survey = await _surveyService.GetSurveyById(id);

            return Ok(Survey);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSurvey(int SurveyId)
        {
            SurveyResponseDto Survey = await _surveyService.DeleteSurvey(SurveyId);
            return Ok(Survey);
        }

        //[HttpPost("Api/Edit")]
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var Measurement = await _unitOfWork.MeasurementRepository.GetFirstOrDefault(x => x.MeasurementID == id);
        //    if (Measurement == null)
        //    {
        //        return NotFound("There is no on by this Id.");
        //    }
        //    await _unitOfWork.MeasurementRepository.Update(Measurement);

        //    return Ok(Measurement);

        //}








    }
}