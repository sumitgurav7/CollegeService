using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CollegeService.Context
{
    public class CollegeServiceDBContext:DbContext
    {
        public CollegeServiceDBContext(DbContextOptions<CollegeServiceDBContext> option):base(option)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
