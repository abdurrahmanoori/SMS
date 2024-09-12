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
    public class SurveyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet("api/survey/getAll")]
        public async Task<IActionResult> GetSurveyList()
        {
               IEnumerable<Survey> surveys =  await _unitOfWork.SurveyRepository.GetAll();

            IEnumerable<SurveyResponseDto> results =  surveys.Select(temp=>temp.ToSurveResponseDto());

            return Ok(results);

        }



        [HttpPost("api/survey/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var survey = await _unitOfWork.SurveyRepository.GetFirstOrDefault(x => x.SurveyID == id);
            if(survey == null)
            {
                return NotFound("There is no survey by this Id.");
            }
            SurveyResponseDto  surveyResponseDto = survey.ToSurveResponseDto();

            return Ok(surveyResponseDto);
            

        }

        [HttpPost("api/survey/create")]
        public async Task<IActionResult> Create(SurveyAddDto surveyAddDto)
        {
            if(ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            Survey survey = surveyAddDto.ToSurvey();
             await _unitOfWork.SurveyRepository.Add(survey);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("survey created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteSurvey(int surveyId)
        {
            if( surveyId <= 0)
            {
                return BadRequest();
            }
            var survey = await _unitOfWork.SurveyRepository.GetFirstOrDefault(x => x.SurveyID == surveyId);
            if(survey is null)
            {
                return BadRequest();
            }
            await _unitOfWork.SurveyRepository.Remove(survey);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("survey has been deleted successfully");
        }

    }
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





//}public class CustomerController : ControllerBase
//{
//    //private readonly IUnitOfWork _unitOfWork;
//    private readonly ICustomerService _customerService;

//    public CustomerController(ICustomerService customerService)
//    {
//        _customerService = customerService;
//    }

//    [HttpPost("Api/Create")]
//    public async Task<IActionResult> Create(CustomerAddDto addCustomerDto)
//    {
//        var result = await _customerService.AddCustomer(addCustomerDto);
//        return Ok(result);

//    }



//    [HttpGet("Api/GetAll")]
//    public async Task<IActionResult> GetCustomerList()
//    {
//        IEnumerable<CustomerResponseDto> results =await _customerService.GetCustomerList();
//        return Ok(results);

//    }

//    [HttpPost("Api/GetById")]
//    public async Task<IActionResult> GitById(int id)
//    {
//        var customer = await _customerService.GetCustomerById(id);

//        return Ok(customer);

//    }

//    [HttpDelete]
//    public async Task<IActionResult> DeleteCustomer(int customerId)
//    {
//        CustomerResponseDto customer = await _customerService.DeleteCustomer(customerId);
//        return Ok(customer);
//    }

//    //[HttpPost("Api/Edit")]
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





//}










//public class CustomerController : ControllerBase
//{
//    //private readonly IUnitOfWork _unitOfWork;
//    private readonly ICustomerService _customerService;

//    public CustomerController(ICustomerService customerService)
//    {
//        _customerService = customerService;
//    }

//    [HttpPost("Api/Create")]
//    public async Task<IActionResult> Create(CustomerAddDto addCustomerDto)
//    {
//        var result = await _customerService.AddCustomer(addCustomerDto);
//        return Ok(result);

//    }



//    [HttpGet("Api/GetAll")]
//    public async Task<IActionResult> GetCustomerList()
//    {
//        IEnumerable<CustomerResponseDto> results = await _customerService.GetCustomerList();
//        return Ok(results);

//    }

//    [HttpPost("Api/GetById")]
//    public async Task<IActionResult> GitById(int id)
//    {
//        var customer = await _customerService.GetCustomerById(id);

//        return Ok(customer);

//    }

//    [HttpDelete]
//    public async Task<IActionResult> DeleteCustomer(int customerId)
//    {
//        CustomerResponseDto customer = await _customerService.DeleteCustomer(customerId);
//        return Ok(customer);
//    }

//    //[HttpPost("Api/Edit")]
//    //public async Task<IActionResult> Edit(int id)
//    //{
//    //    var Measurement = await _unitOfWork.MeasurementRepository.GetFirstOrDefault(x => x.MeasurementID == id);
//    //    if (Measurement == null)
//    //    {
//    //        return NotFound("There is no on by this Id.");
//    //    }
//    //    await _unitOfWork.MeasurementRepository.Update(Measurement);

//    //    return Ok(Measurement);

//    //}





//}