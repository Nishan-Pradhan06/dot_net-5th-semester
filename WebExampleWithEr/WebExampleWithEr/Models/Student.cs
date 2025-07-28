using System.ComponentModel.DataAnnotations.Schema;

namespace WebExampleWithEr.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public string Phone { get; set; } =null!;
        public int Age { get; set; }
        public DateOnly Dob {  get; set; }
        [ForeignKey("StudentFaculty")]
        public int FacultyId { get; set; }
        public virtual Faculty StudentFaculty { get; set; } = null!;
    }
}
