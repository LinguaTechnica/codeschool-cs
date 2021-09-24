using System;
using Xunit;
using CodeSchool.Courses;

namespace CodeSchool.Tests
{
    public class CourseTestCase
    {
        [Fact]
        public void TestCreate()
        {
            var course = new Course();
            Assert.NotNull(course);
        }
    }
}