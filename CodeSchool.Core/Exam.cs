using System.Collections.Generic;

namespace CodeSchool.Core
{
    public class Exam
    {
        public Course Course;
        public Student Student;
        public string[] Questions;

        public Exam(Course course, Student student)
        {
            Course = course;
            Student = student;
        }
    }
}