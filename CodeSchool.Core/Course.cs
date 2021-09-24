using System;
using System.Collections.Generic;
using CodeSchool.Core.Shared;

namespace CodeSchool.Core
{
    public class Course
    {
        public Guid Id = Guid.NewGuid();
        public Subject Subject;
        public int AvailableSeats;
        public Teacher Teacher;
        public List<Exam> Exams = new List<Exam>();
        private List<Student> Students { get; } = new List<Student>();
        public bool IsOpen => AvailableSeats == 0 | _isOpen;
        private bool _isOpen = true;

        public void CloseEnrollment()
        {
            _isOpen = false;
        }

        public void Enroll(Student student)
        {
            if (AvailableSeats == 0)
            {
                _isOpen = false;
                Console.WriteLine("There are no available seats.");
            }
            else if (IsOpen)
            {
                Students.Add(student);
                AvailableSeats -= 1;
            }
        }
        
        public void DisEnroll(Student student)
        {
            Students.Remove(student);
            AvailableSeats += 1;
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
