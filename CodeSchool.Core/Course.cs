using System;
using System.Collections.Generic;
using CodeSchool.Core.Shared;

namespace CodeSchool.Core
{
    public class Course
    {
        public Subject Subject;
        public int AvailableSeats;
        public Teacher Teacher;
        public List<Exam> Exams = new List<Exam>();
    }
}