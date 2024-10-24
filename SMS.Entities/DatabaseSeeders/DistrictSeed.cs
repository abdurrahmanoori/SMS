using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class DistrictSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>().HasData(
             new District
             {
                 DistrictId = 1,
                 DistrictName = "District A",
                 ProvinceId = 1
             },
            new District
            {
                DistrictId = 2,
                DistrictName = "District B",
                ProvinceId = 1
            },
            new District
            {
                DistrictId = 3,
                DistrictName = "District C",
                ProvinceId = 2

            });
        }
    }
}
