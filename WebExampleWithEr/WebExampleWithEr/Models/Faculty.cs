namespace WebExampleWithEr.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; } = null!;
        public int StudentQuota { get; set; }

        public virtual List<Student> Students { get; set; } = [];
    }
}
