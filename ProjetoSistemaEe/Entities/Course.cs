namespace ProjetoSistemaEe.Entidades
{
    public class Course
    {
        private int courseId;
        private string courseName;

        public int CourseId { get => courseId; set => courseId = value; }
        public string CourseName { get => courseName; set => courseName = value; }

        public Course()
        {
        }

        public Course(int courseid)
        {
            this.courseId = courseid;
        }

        public Course(int courseid, string coursename)
        {
            this.courseId = courseid;
            this.courseName = coursename;
        }

        public override string ToString()
        {
            return courseName;
        }
    }
}