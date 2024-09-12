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
    public class LanguageController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public LanguageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("api/language/getAll")]
        public async Task<IActionResult> GetLanguageList()
        {
            IEnumerable<Language> languages = await _unitOfWork.LanguageRepository.GetAll();

            IEnumerable<LanguageResponseDto> results = languages.Select(temp => temp.ToLanguageResponseDto());

            return Ok(results);

        }



        [HttpPost("api/language/GetById")]
        public async Task<IActionResult> GitById(int id)
        {

            var language = await _unitOfWork.LanguageRepository.GetFirstOrDefault(x => x.LanguageID == id);
            if (language == null)
            {
                return NotFound("There is no language by this Id.");
            }
            LanguageResponseDto languageResponseDto = language.ToLanguageResponseDto();

            return Ok(languageResponseDto);


        }

        [HttpPost("api/language/create")]
        public async Task<IActionResult> Create(LanguageAddDto languageAddDto)
        {
            if (ModelState.IsValid is not true)
            {
                return BadRequest();
            }
            Language language = languageAddDto.ToLanguage();
            await _unitOfWork.LanguageRepository.Add(language);
            await _unitOfWork.SaveChanges(CancellationToken.None);

            return Ok("language created successfully");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteLanguage(int languageId)
        {
            if (languageId <= 0)
            {
                return BadRequest();
            }
            var language = await _unitOfWork.LanguageRepository.GetFirstOrDefault(x => x.LanguageID == languageId);
            if (language is null)
            {
                return BadRequest();
            }
            await _unitOfWork.LanguageRepository.Remove(language);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return Ok("language has been deleted successfully");
        }
    }
}
