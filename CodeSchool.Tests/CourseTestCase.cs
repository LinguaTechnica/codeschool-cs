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
            var course = new Course() { Subject = CourseSubject.Art, Teacher = new Teacher() };
            Assert.Equal(CourseSubject.Art, course.Subject);
        }

        [Fact]
        public void TestListOfExamsNull()
        {
            var course = new Course() { Subject = CourseSubject.Art, Teacher = new Teacher() };
            Assert.Empty(course.Exams);
        }

        [Fact]
        public void TestStudentsCanRegisterDuringEnrollment()
        {
            var course = new Course() { Subject = CourseSubject.Art, Teacher = new Teacher() };
            course.Enroll(new Student());
            course.Enroll(new Student());
            Assert.Equal(2, course.GetStudents().Count);
        }
        
        [Fact]
        public void TestEnrollmentClosedWhenNoSeatsAvailable()
        {
            var course = new Course() { Subject = CourseSubject.Art, Teacher = new Teacher(), AvailableSeats = 1};
            course.Enroll(new Student());
            course.Enroll(new Student());
            Assert.Single(course.GetStudents());
        }
        
        [Fact]
        public void TestEnrollmentClosedManuallyByAdministrator()
        {
            var course = new Course() { Subject = CourseSubject.Art, Teacher = new Teacher(), AvailableSeats = 1};
            course.CloseEnrollment();
            course.Enroll(new Student());
            Assert.Empty(course.GetStudents());
        }
    }
}