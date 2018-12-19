namespace CollegeService.Models
{
    public class DepartmentDto
    {
        public int Id {get; set;}
        public string DepartmentName {get; set;}

        public override string ToString()
        {
            return $"Department ID: {Id}, Department Name: {DepartmentName}";
        }
    }
    
}