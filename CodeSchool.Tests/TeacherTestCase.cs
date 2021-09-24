using CodeSchool.Core;
using Xunit;

namespace CodeSchool.Tests
{
    public class TeacherTestCase
    {
        [Fact]
        public void TestCreateTeacher()
        {
            var teacher = new Teacher()
            {
                Name = "Willy Wonka", Email = "willy@example.com"
            };
            Assert.Equal("Willy Wonka", teacher.Name);
        }
    }
}