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
    public class RespondentController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public RespondentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/respondent/getAll")]
        public async Task<IActionResult> GetRespondentList()
        {
            IEnumerable<Respondent> respondents = await _unitOfWork.RespondentRepository.GetAll();

            IEnumerable<RespondentResponseDto> results = respondents.Select(temp => temp.ToRespondentResponseDto());

            return Ok(results);

        }



        [HttpPost("api/respondent/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var respondent = await _unitOfWork.RespondentRepository.GetFirstOrDefault(x => x.RespondentID == id);
            if (respondent == null)
            {
                return NotFound("There is no respondent by this Id.");
            }
            RespondentResponseDto respondentResponseDto = respondent.ToRespondentResponseDto();

            return Ok(respondentResponseDto);


        }

        [HttpPost("api/respondent/create")]
        public async Task<IActionResult> Create(RespondentAddDto respondentAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            Respondent respondent = respondentAddDto.ToRespondent();
            await _unitOfWork.RespondentRepository.Add(respondent);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("respondent created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteSurvey(int respondentId)
        {
            if (respondentId <= 0)
            {
                return BadRequest();
            }
            var respondent = await _unitOfWork.RespondentRepository.GetFirstOrDefault(x => x.RespondentID == respondentId);
            if (respondent is null)
            {
                return BadRequest();
            }
            await _unitOfWork.RespondentRepository.Remove(respondent);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("respondent has been deleted successfully");
        }
    }
}
