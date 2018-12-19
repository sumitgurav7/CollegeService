using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeService.Entities
{
    public class Student
    {
        
       
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
