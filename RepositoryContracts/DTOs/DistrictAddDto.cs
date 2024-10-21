using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class DistrictAddDto
    {
        public string Name { get; set; }
        public int ProvinceId { get; set; }
        public District toDistrict() {
            return new District { DistrictName = Name, ProvinceId=ProvinceId };
        }
    }
}
