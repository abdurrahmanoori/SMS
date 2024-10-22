using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public  class ProvinceResponseDto
    {
        public int ProvinceID {  get; set; }
        public string ProvinceName { get; set; }

    }
    public static class ProvinceExtension
    {
        public static ProvinceResponseDto toProvinceResponseDto(this Province province)
        {
            return new ProvinceResponseDto { ProvinceID=province.Id,ProvinceName=province.Name};
        }
    }
}
