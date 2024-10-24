using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class ProvinceSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>().HasData(
             new Province
             {
                 Id = 1,
                 Name = "Province A"
             },
            new Province
            {
                Id = 2,
                Name = "Province B"
            },
            new Province
            {
                Id = 3,
                Name = "Province C"

            });
        }
    }
}
