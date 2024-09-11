
using RepositoryContracts.Generic;
using SMS.ServicesContracts;
using SMS.Entities;
using SMS.ServicesContracts.Dto;

namespace SMS.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<SurveyAddDto> AddSurvey(SurveyAddDto surveyAddDto)
        {
            if (surveyAddDto == null)
            {
                return null;
            }
            
            Survey survey = surveyAddDto.ToSurvey();
            await _unitOfWork.SurveyRepository.Add(survey);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return surveyAddDto;

        }

        public async Task<SurveyResponseDto> DeleteSurvey(int? SurveyId)
        {
            if (!SurveyId.HasValue)
            {
                return null;
            }
            Survey Survey = await _unitOfWork.SurveyRepository.GetById((int)SurveyId);
            if (Survey == null)
            {
                return null;
            }
            await _unitOfWork.SurveyRepository.Remove(Survey);
            await _unitOfWork.SaveChanges(default);

            return Survey.ToSurveyResponseDto();

        }


        public async Task<SurveyResponseDto> GetSurveyById(int? surveyId)
        {
            if (surveyId == null || surveyId == 0)
            {
                return null;
            }
            Survey Survey = await _unitOfWork.SurveyRepository
                .GetFirstOrDefault(x => x.SurveyID == surveyId);

            SurveyResponseDto SurveyResponseDto = Survey.ToSurveyResponseDto();
            return SurveyResponseDto;

        }

        public async Task<IEnumerable<SurveyResponseDto>> GetSurveyList()
        {
            IEnumerable<Survey> Surveys = await _unitOfWork.SurveyRepository.GetAll();
            if (Surveys is null)
            {
                return null;
            }

            IEnumerable<SurveyResponseDto> SurveyResponseDtos = Surveys
                .Select(temp => temp.ToSurveyResponseDto());

            return SurveyResponseDtos;

        }

    }
}
