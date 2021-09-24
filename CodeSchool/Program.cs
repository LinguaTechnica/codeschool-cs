using System;
using System.Collections.Generic;
using CodeSchool.Core;

namespace CodeSchool
{
    class Program
    {
        private static List<Teacher> _teachers = new List<Teacher>();
        
        static void Main(string[] args)
        {
            var teacher = new Teacher() {Name = "Justin Thyme"};
            _teachers.Add(teacher);
            
            Console.WriteLine("Welcome to Code School! Who are you?");
            Console.Write(_teachers[0].Name);
        }
    }
}