
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryContracts.Generic;

namespace SMS.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
          //  var survey = _unitOfWork.SurveyRepository.Add(new Survey
          //  {
          //      CreatedDate = DateTime.Now,
          //      IsActive = true,
          //      SurveyID = 10
          //  });

          //await  _unitOfWork.SaveChanges(CancellationToken.None);


            var result =await _unitOfWork.SurveyRepository.GetAll();
            


            return Ok(result);
        }
    }
}
