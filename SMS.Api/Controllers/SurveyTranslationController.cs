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
    public class SurveyTranslationController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public SurveyTranslationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/surveytranslation/getAll")]
        public async Task<IActionResult> GetSurveyTranslationList()
        {
            IEnumerable<SurveyTranslation> surveytranslations = await _unitOfWork.SurveyTranslationRepository.GetAll();

            IEnumerable<SurveyTranslationResponseDto> results = surveytranslations.Select(temp => temp.ToSurveyTranslationResponseDto());

            return Ok(results);

        }



        [HttpPost("api/surveyranslation/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var surveytranslation = await _unitOfWork.SurveyTranslationRepository.GetFirstOrDefault(x => x.SurveyTranslationID == id);
            if (surveytranslation == null)
            {
                return NotFound("There is no surveytranslation by this Id.");
            }
            SurveyTranslationResponseDto surveytranslationResponseDto = surveytranslation.ToSurveyTranslationResponseDto();

            return Ok(surveytranslationResponseDto);


        }

        [HttpPost("api/surveytranslation/create")]
        public async Task<IActionResult> Create(SurveyTranslationAddDto surveytranslationAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            SurveyTranslation surveytranslation = surveytranslationAddDto.ToSurveyTranslation();
            await _unitOfWork.SurveyTranslationRepository.Add(surveytranslation);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("surveytranslation created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteSurveyTranslation(int surveytranslationId)
        {
            if (surveytranslationId <= 0)
            {
                return BadRequest();
            }
            var surveytranslation = await _unitOfWork.SurveyTranslationRepository.GetFirstOrDefault(x => x.SurveyTranslationID == surveytranslationId);
            if (surveytranslation is null)
            {
                return BadRequest();
            }
            await _unitOfWork.SurveyTranslationRepository.Remove(surveytranslation);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("surveytranslation has been deleted successfully");
        }
    }
}
