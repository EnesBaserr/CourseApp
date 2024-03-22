using System.Diagnostics.CodeAnalysis;

namespace CourseApp.Models
{
    public class Course
    {
        
        public int Id { get; set; }
        [NotNull]
        public string Title { get; set; }
        [NotNull]
        public string Description { get; set; }
        public int Credits { get; set; }

        public List<Student> Students { get; set; } = new List<Student>(); // Initialize the list
        public Teacher Assigned { get; set; }
      
    }
}
