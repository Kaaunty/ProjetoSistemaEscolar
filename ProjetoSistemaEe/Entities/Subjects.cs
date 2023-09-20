using System.Data;

namespace ProjetoSistemaEe.Entidades
{
    public class Subjects
    {
        private int subjectId;
        private string subjectName;
        private Course course = new Course();

        public Subjects()
        {
        }

        public Subjects(int subjectId, string subjectName)
        {
            this.subjectId = subjectId;
            this.subjectName = subjectName;
        }

        public Subjects(int courseId, int subjectId, string subjectName, string courseName)
        {
            this.course.CourseId = courseId;
            this.subjectId = subjectId;
            this.subjectName = subjectName;
            this.course.CourseName = courseName;
        }

        public int SubjectId { get => subjectId; set => subjectId = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public Course Course { get => course; set => course = value; }

        public override string ToString()
        {
            return subjectName;
        }
    }
}