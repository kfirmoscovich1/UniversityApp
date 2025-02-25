namespace UniversityApp
{
    public interface ITeachable
    {
        void TeachCourse(string courseName);
        void GradeAssignment(string studentID, string assignment);
    }
}
