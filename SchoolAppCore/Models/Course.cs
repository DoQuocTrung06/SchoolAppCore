namespace SchoolAppCore.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; } // Khóa ngoại trỏ về Department
    }
}