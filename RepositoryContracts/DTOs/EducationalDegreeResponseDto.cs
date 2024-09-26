using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class EducationalDegreeResponseDto
    {
        public int EducationalDegreeID { get; set; }
        public string EducationalDegreeDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public static class EducationalDegreeExtention
    {
        public static EducationalDegreeResponseDto ToEducationalDegreeResponse(this EducationalDegree educationaldegree)
        {
            return new EducationalDegreeResponseDto
            {
                EducationalDegreeID = educationaldegree.EducationalDegreeID,
                EducationalDegreeDescription = educationaldegree.EducationalDegreeDescription,
                CreatedDate = educationaldegree.CreatedDate,
            };
        }
    }
}
