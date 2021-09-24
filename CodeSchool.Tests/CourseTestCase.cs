using System;
using CodeSchool.Core;
using CodeSchool.Core.Shared;
using Xunit;

namespace CodeSchool.Tests
{
    public class CourseTestCase
    {
        
        [Fact]
        public void TestCreate()
        {
            var course = new Course() { Subject = Subject.Art, Teacher = new Teacher() };
            Assert.Equal(Subject.Art, course.Subject);
        }

        [Fact]
        public void TestListOfExamsNull()
        {
            var course = new Course() { Subject = Subject.Art, Teacher = new Teacher() };
            Assert.Empty(course.Exams);
        }
    }
}