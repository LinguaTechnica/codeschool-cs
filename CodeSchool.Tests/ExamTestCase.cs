using System;
using CodeSchool.Core;
using Xunit;

namespace CodeSchool.Tests
{
    public class ExamTestCase
    {
        [Fact]
        public void TestCreateExam()
        {
            var course = new Course();
            var exam = new Exam(new Course(), new Student());

            course.Exams.Add(exam);
            Assert.NotNull(exam);
        }
    }
}