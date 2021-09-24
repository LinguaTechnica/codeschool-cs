using System;
using System.Collections.Generic;
using CodeSchool.Core;
using CodeSchool.Core.Shared;

namespace CodeSchool
{
    class Program
    {
        private static List<Teacher> _teachers = new List<Teacher>();
        private static List<Course> _availableCourses = new List<Course>();
        
        static void Main(string[] args)
        {
            var teacher = new Teacher() {Name = "Justin Thyme"};
            _teachers.Add(teacher);
            
            Console.WriteLine("Welcome to Code School! Who are you?");
            Console.WriteLine("\t1 - Student\n\t2 - Teacher");
            var response = Console.ReadLine();

            if (response.Equals("1"))
            {
                RunEnrollmentTerminal();
            } else if (response.Equals("2"))
            {
                RunAdminTerminal();
            }
            
            Console.Write(_teachers[0].Name);
        }

        public static void RunEnrollmentTerminal()
        {
            Console.WriteLine("Which course would you like to enroll in?");
            var topicNames = Enum.GetNames(typeof(CourseSubject));
            var choiceNumber = 1;
            
            foreach (var course in _availableCourses)
            {
                Console.WriteLine($"{choiceNumber} - {course.Subject}");
                choiceNumber += 1;
            }

            var choice = Console.ReadLine();
            // TODO: Need a map or something to select the right course based on user choice.
        }

        public static void RunAdminTerminal()
        {
            
        }
    }
}