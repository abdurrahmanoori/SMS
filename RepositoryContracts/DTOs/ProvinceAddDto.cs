using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
  
   public  class ProvinceAddDto
    { 
        
        public string Name {  get; set; }
        public Province toProvince()
        {
            return new Province { Name = Name };
        }


    }
}
