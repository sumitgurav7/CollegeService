using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeService.Entities;
using CollegeService.Models;

namespace CollegeService.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        bool Add(Student student);
        bool Update(Student student);
        bool Remove(int id);

    }
}
