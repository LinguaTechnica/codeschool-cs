using CodeSchool.Core;
using Xunit;

namespace CodeSchool.Tests
{
    public class TeacherTestCase
    {
        [Fact]
        public void TestCreateTeacher()
        {
            var teacher = new Teacher();
            Assert.NotNull(teacher);
        }
    }
}