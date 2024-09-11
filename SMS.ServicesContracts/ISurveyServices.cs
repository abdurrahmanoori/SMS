using SMS.ServicesContracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.ServicesContracts
{
    public interface ISurveyService
    {
        public Task<SurveyAddDto> AddSurvey(SurveyAddDto addSurveyDto);
        public Task<SurveyResponseDto> GetSurveyById(int? SurveyId);

        public Task<IEnumerable<SurveyResponseDto>> GetSurveyList();

        public Task<SurveyResponseDto> DeleteSurvey(int? SurveyId);

    }
}
