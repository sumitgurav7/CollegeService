namespace CollegeService.Models
{
    public class StudentDto
    {
        public string Name {get;set;}
        public int Id {get; set;}
        public int Department {get; set;}

        public override string ToString() {

            return $"Name : {Name} , Id : {Id}, Department Id : {Department}";
        }

        
    }
    
}