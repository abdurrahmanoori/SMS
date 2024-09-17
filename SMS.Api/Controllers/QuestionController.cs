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
    public class QuestionController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public QuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/question/getAll")]
        public async Task<IActionResult> GetQuestionList()
        {
            IEnumerable<Question> questions = await _unitOfWork.QuestionRepository.GetAll();

            IEnumerable<QuestionResponseDto> results = questions.Select(temp => temp.ToQuestionResponseDto());

            return Ok(results);

        }



        [HttpPost("api/question/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var question = await _unitOfWork.QuestionRepository.GetFirstOrDefault(x => x.QuestionID == id);
            if (question == null)
            {
                return NotFound("There is no question by this Id.");
            }
            QuestionResponseDto questionResponseDto = question.ToQuestionResponseDto();

            return Ok(questionResponseDto);


        }

        [HttpPost("api/question/create")]
        public async Task<IActionResult> Create(QuestionAddDto questionAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            Question question = questionAddDto.ToQuestion();
            await _unitOfWork.QuestionRepository.Add(question);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("question created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteQuestion(int questionId)
        {
            if (questionId <= 0)
            {
                return BadRequest();
            }
            var question = await _unitOfWork.QuestionRepository.GetFirstOrDefault(x => x.QuestionID == questionId);
            if (question is null)
            {
                return BadRequest();
            }
            await _unitOfWork.QuestionRepository.Remove(question);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("question has been deleted successfully");
        }
    }
}

