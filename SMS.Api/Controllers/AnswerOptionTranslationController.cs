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
    public class AnswerOptionTranslationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnswerOptionTranslationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/answeroptiontranslation/getAll")]
        public async Task<IActionResult> GetAnswerOptionTranslationList()
        {
            IEnumerable<AnswerOptionTranslation> answeroptiontranslations = await _unitOfWork.AnswerOptionTranslationRepository.GetAll();

            IEnumerable<AnswerOptionTranslationResponseDto> results = answeroptiontranslations.Select(temp => temp.ToAnswerOptionTranslationResponseDto());

            return Ok(results);

        }



        [HttpPost("api/answeroptiontranslation/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var answeroptiontranslation = await _unitOfWork.AnswerOptionTranslationRepository.GetFirstOrDefault(x => x.AnswerOptionTranslationID == id);
            if (answeroptiontranslation == null)
            {
                return NotFound("There is no answeroptiontranslation by this Id.");
            }
            AnswerOptionTranslationResponseDto answeroptiontranslationResponseDto = answeroptiontranslation.ToAnswerOptionTranslationResponseDto();

            return Ok(answeroptiontranslationResponseDto);


        }

        [HttpPost("api/answeroptiontranslation/create")]
        public async Task<IActionResult> Create(AnswerOptionTranslationAddDto answeroptiontranslationAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            AnswerOptionTranslation answeroptiontranslation = answeroptiontranslationAddDto.ToAnswerOptionTranslation();
            await _unitOfWork.AnswerOptionTranslationRepository.Add(answeroptiontranslation);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("answeroptionoranslation created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteAnswerOptionTranslation(int answeroptiontranslationId)
        {
            if (answeroptiontranslationId <= 0)
            {
                return BadRequest();
            }
            var answeroptiontranslation = await _unitOfWork.AnswerOptionTranslationRepository.GetFirstOrDefault(x => x.AnswerOptionTranslationID == answeroptiontranslationId);
            if (answeroptiontranslation is null)
            {
                return BadRequest();
            }
            await _unitOfWork.AnswerOptionTranslationRepository.Remove(answeroptiontranslation);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("answeroptiontranslation has been deleted successfully");
        }
    }
}
