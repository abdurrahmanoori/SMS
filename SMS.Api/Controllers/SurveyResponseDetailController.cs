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
    public class SurveyResponseDetailController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public SurveyResponseDetailController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/surveyresponsedetail/getAll")]
        public async Task<IActionResult> GetSurveyResponseDetailList()
        {
            IEnumerable<SurveyResponseDetail> surveyresponsedetails = await _unitOfWork.SurveyResponseDetailRepository.GetAll();

            IEnumerable<SurveyResponseDetailResponseDto> results = surveyresponsedetails.Select(temp => temp.ToSurveyResponseDetailResponseDto());

            return Ok(results);

        }



        [HttpPost("api/surveyresponsedetail/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var surveyresponsedetail = await _unitOfWork.SurveyResponseDetailRepository.GetFirstOrDefault(x => x.SurveyResponseDetailID == id);
            if (surveyresponsedetail == null)
            {
                return NotFound("There is no surveyresponsedetail by this Id.");
            }
            SurveyResponseDetailResponseDto surveyresponsedetailResponseDto = surveyresponsedetail.ToSurveyResponseDetailResponseDto();

            return Ok(surveyresponsedetailResponseDto);


        }

        [HttpPost("api/surveyresponsedetail/create")]
        public async Task<IActionResult> Create(SurveyResponseDetailAddDto surveyresponsedetailAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            SurveyResponseDetail surveyresponsedetail = surveyresponsedetailAddDto.ToSurveyResponseDetail();
            await _unitOfWork.SurveyResponseDetailRepository.Add(surveyresponsedetail);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("surveyresponsedetail created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteSurveyResponseDetail(int surveyresponsedetailId)
        {
            if (surveyresponsedetailId <= 0)
            {
                return BadRequest();
            }
            var surveyresponsedetail = await _unitOfWork.SurveyResponseDetailRepository.GetFirstOrDefault(x => x.SurveyResponseDetailID == surveyresponsedetailId);
            if (surveyresponsedetail is null)
            {
                return BadRequest();
            }
            await _unitOfWork.SurveyResponseDetailRepository.Remove(surveyresponsedetail);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("surveyresponsedetail has been deleted successfully");
        }
    }
}
