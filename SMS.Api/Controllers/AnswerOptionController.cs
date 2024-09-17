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
    public class AnswerOptionController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public AnswerOptionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/answeroption/getAll")]
        public async Task<IActionResult> GetSurveyList()
        {
            IEnumerable<AnswerOption> answeroptions = await _unitOfWork.AnswerOptionRepository.GetAll();

            IEnumerable<AnswerOptionResponseDto> results = answeroptions.Select(temp => temp.ToAnswerOptionResponseDto());

            return Ok(results);

        }



        [HttpPost("api/answeroption/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var answeroption = await _unitOfWork.AnswerOptionRepository.GetFirstOrDefault(x => x.AnswerOptionID == id);
            if (answeroption == null)
            {
                return NotFound("There is no answeroption by this Id.");
            }
            AnswerOptionResponseDto answeroptionResponseDto = answeroption.ToAnswerOptionResponseDto();

            return Ok(answeroptionResponseDto);


        }

        [HttpPost("api/answeroption/create")]
        public async Task<IActionResult> Create(AnswerOptionAddDto answeroptionAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            AnswerOption answeroption = answeroptionAddDto.ToAnswerOption();
            await _unitOfWork.AnswerOptionRepository.Add(answeroption);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("answeroption created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteAnswerOption(int answeroptionId)
        {
            if (answeroptionId <= 0)
            {
                return BadRequest();
            }
            var answeroption = await _unitOfWork.AnswerOptionRepository.GetFirstOrDefault(x => x.AnswerOptionID == answeroptionId);
            if (answeroption is null)
            {
                return BadRequest();
            }
            await _unitOfWork.AnswerOptionRepository.Remove(answeroption);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("survey has been deleted successfully");
        }
    }
}
