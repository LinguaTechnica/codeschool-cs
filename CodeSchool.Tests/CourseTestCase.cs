using System;
using CodeSchool.Core;
using Xunit;

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