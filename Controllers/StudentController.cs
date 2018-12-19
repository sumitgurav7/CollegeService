using System.Collections.Generic;
using CollegeService.Entities;
using CollegeService.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeService.Controllers
{
    [Route("api/student")]
    public class StudentController : Controller
    {
        private readonly IStudentService _provider;

        public StudentController(IStudentService provider)
        {
            _provider = provider;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _provider.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _provider.Get(id);
        }

        // POST api/<controller>
        [HttpPost("{id}/CreateStudent")]
        public void Post([FromBody]Student student)
        {
            _provider.Add(student);
        }
        
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Student student)
        {
            _provider.Update(student);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _provider.Remove(id);
        }
    }
}
