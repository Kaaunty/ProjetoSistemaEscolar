namespace ProjetoSistemaEe.Entidades
{
    public class ReportCard
    {
        private int id;
        private double grade1;
        private double grade2;
        private double grade3;
        private double grade4;
        private double average;
        private string situation;
        private Course course = new Course();
        private Professor professor = new Professor();
        private Student student = new Student();
        private Subjects subject = new Subjects();

        public ReportCard(int id, double grade1, double grade2, double grade3, double grade4, double average, string situation)
        {
            this.id = id;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
            this.grade4 = grade4;
            this.average = average;
            this.situation = situation;
        }

        public ReportCard(int ra, int professorId, int subjectId, int courseId, double grade1, double grade2, double grade3, double grade4, double average, string situation)
        {
            Student.Ra = ra;
            Professor.Id = professorId;
            Subject.SubjectId = subjectId;
            Course.CourseId = courseId;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
            this.grade4 = grade4;
            this.average = average;
            this.situation = situation;
        }

        public ReportCard(int id, int ra, string studentName, int courseId, string courseName, int subjectId, string subjectName, double grade1, double grade2, double grade3, double grade4, double average, string situation)
        {
            this.id = id;
            Student.Ra = ra;
            Student.Name = studentName;
            Course.CourseId = courseId;
            Course.CourseName = courseName;
            Subject.SubjectId = subjectId;
            Subject.SubjectName = subjectName;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
            this.grade4 = grade4;
            this.average = average;
            this.situation = situation;
        }

        public ReportCard(int id, int ra, string studentName, int courseId, string courseName, int subjectId, string subjectName, int professorId, string professorName, double grade1, double grade2, double grade3, double grade4, double average, string situation)
        {
            this.id = id;
            Student.Ra = ra;
            Student.Name = studentName;
            Course.CourseId = courseId;
            Course.CourseName = courseName;
            Subject.SubjectId = subjectId;
            Subject.SubjectName = subjectName;
            Professor.Id = professorId;
            Professor.Name = professorName;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
            this.grade4 = grade4;
            this.average = average;
            this.situation = situation;
        }

        public int Id { get => id; set => id = value; }
        public double Grade1 { get => grade1; set => grade1 = value; }
        public double Grade2 { get => grade2; set => grade2 = value; }
        public double Grade3 { get => grade3; set => grade3 = value; }
        public double Grade4 { get => grade4; set => grade4 = value; }
        public double Average { get => average; set => average = value; }
        public string Situation { get => situation; set => situation = value; }
        public Course Course { get => course; set => course = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public Student Student { get => student; set => student = value; }
        public Subjects Subject { get => subject; set => subject = value; }
    }
}