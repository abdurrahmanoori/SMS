using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
   public class DistrictResponseDto
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int ProvinceId { get; set; }

    }
    public static class DistrictExtension {
        public static DistrictResponseDto toDistrictResponseDto(this District district) 
        { 
         return new DistrictResponseDto { 
             DistrictId=district.DistrictId,
             DistrictName=district.DistrictName,
             ProvinceId=district.ProvinceId
         };
        }
    }
}
