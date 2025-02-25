namespace UniversityApp
{
    public class GradeEntry
    {
        public string CourseID { get; set; }
        public int Score { get; set; }
    }

    public class Grade
    {
        public string UserID { get; set; }
        public List<GradeEntry> Grades { get; set; }
    }
}
