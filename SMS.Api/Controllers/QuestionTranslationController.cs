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
    public class QuestionTranslationController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public QuestionTranslationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/questiontranslation/getAll")]
        public async Task<IActionResult> GetQuestionTranslationList()
        {
            IEnumerable<QuestionTranslation> questiontranslations = await _unitOfWork.QuestionTranslationRepository.GetAll();

            IEnumerable<QuestionTranslationResponseDto> results = questiontranslations.Select(temp => temp.ToQuestionTranslationResponseDto());

            return Ok(results);

        }


        [HttpPost("api/questiontranslation/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var questiontranslation = await _unitOfWork.QuestionTranslationRepository.GetFirstOrDefault(x => x.QuestionTranslationID == id);
            if (questiontranslation == null)
            {
                return NotFound("There is no questiontranslation by this Id.");
            }
            QuestionTranslationResponseDto questiontranslationResponseDto = questiontranslation.ToQuestionTranslationResponseDto();

            return Ok(questiontranslationResponseDto);


        }

        [HttpPost("api/questiontranslation/create")]
        public async Task<IActionResult> Create(QuestionTranslationAddDto questiontranslationAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            QuestionTranslation questiontranslation = questiontranslationAddDto.ToQuestionTranslation();
            await _unitOfWork.QuestionTranslationRepository.Add(questiontranslation);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("survey created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteQuestionTranslation(int questiontranslationId)
        {
            if (questiontranslationId <= 0)
            {
                return BadRequest();
            }
            var questiontranslation = await _unitOfWork.QuestionTranslationRepository.GetFirstOrDefault(x => x.QuestionTranslationID == questiontranslationId);
            if (questiontranslation is null)
            {
                return BadRequest();
            }
            await _unitOfWork.QuestionTranslationRepository.Remove(questiontranslation);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("questiontranslation has been deleted successfully");
        }
    }
}
