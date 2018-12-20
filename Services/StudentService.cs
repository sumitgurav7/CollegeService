using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeService.Context;
using CollegeService.Entities;
using CollegeService.Models;

namespace CollegeService.Services
{
    public class StudentService:IStudentService
    {
        private CollegeServiceDBContext _context;

        public StudentService(CollegeServiceDBContext context)
        {
            _context = context;
        }
        public Student Get(int id)
        {
          return  _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public bool Add(StudentDto student)
        {

            if (student.Id != 0)
            {
                _context.Students.Add(new Student()
                {

                    Name = student.Name,
                    DepartmentId = student.Department,

                });
               

            }
            return _context.SaveChanges() >= 1;

        }

        public bool Update(Student student)
        {
           _context.Students.Update(student);
            return true;
        }

        public IEnumerable<Student> GetAll()
        {
          return  _context.Students.ToList();
        }

        public bool Remove(int id)
        {
           return _context.Students.Remove(Get(id))!=null;
        }
    }
}
