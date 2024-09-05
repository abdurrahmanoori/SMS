﻿
using Microsoft.EntityFrameworkCore;
using SMS.Entities;

namespace Entities.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {


        }



        public DbSet<Survey> Surveys { get; set; }
    }
}