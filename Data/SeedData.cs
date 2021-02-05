using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using SampleTest.Models;

namespace SampleTest.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<SampleContext>();

            //Check if database contains anything (only check one)
            if (context.Students.Any())
                return;

            context.Courses.AddRange(
                new Course 
                {
                    CourseID = 1,
                    Title = "Web Development Tech",
                    Credits = 3,
                    DepartmentID = 1
                }, new Course 
                {
                    CourseID = 2,
                    Title = "Databases",
                    Credits = 4,
                    DepartmentID = 2
                }, new Course
                {
                    CourseID = 3,
                    Title = "Biology",
                    Credits = 4,
                    DepartmentID = 3
                }, new Course 
                {
                    CourseID = 4,
                    Title = "Engineering Practices",
                    Credits = 1,
                    DepartmentID = 4
                });

            context.CourseAssignments.AddRange(
                new CourseAssignment
                {
                    CourseID = 1,
                    InstructorID = 1
                }, new CourseAssignment
                {
                    CourseID = 2,
                    InstructorID = 2
                }, new CourseAssignment
                {
                    CourseID = 3,
                    InstructorID = 3
                }, new CourseAssignment
                {
                    CourseID = 4,
                    InstructorID = 3
                });

            context.Departments.AddRange(
                new Department 
                { 
                    DepartmentID = 1,
                    Name = "IT Department",
                    Budget = 300,
                    StartDate = DateTime.Now.Date,
                    InstructorID = 1
                }, new Department
                {
                    DepartmentID = 2,
                    Name = "Technology Department",
                    Budget = 700,
                    StartDate = DateTime.Now.Date,
                    InstructorID = 2
                }, new Department
                {
                    DepartmentID = 3,
                    Name = "Science Department",
                    Budget = 1300,
                    StartDate = DateTime.Now.Date,
                    InstructorID = 3
                }, new Department
                {
                    DepartmentID = 4,
                    Name = "Engineering Department",
                    Budget = 2200,
                    StartDate = DateTime.Now.Date,
                    InstructorID = 3
                });

            context.Enrollments.AddRange(
                new Enrollment 
                { 
                    EnrollmentID = 1,
                    CourseID = 1,
                    StudentID = 1
                }, new Enrollment
                {
                    EnrollmentID = 2,
                    CourseID = 2,
                    StudentID = 1
                }, new Enrollment
                {
                    EnrollmentID = 3,
                    CourseID = 3,
                    StudentID = 2
                }, new Enrollment
                {
                    EnrollmentID = 4,
                    CourseID = 1,
                    StudentID = 3
                });

            context.Instructors.AddRange(
                new Instructor 
                {
                    ID = 1,
                    LastName = "Kalra",
                    FirstMidName = "Shekhar",
                    HireDate = DateTime.Now.AddMonths(2).Date
                }, new Instructor
                {
                    ID = 2,
                    LastName = "Bolger",
                    FirstMidName = "Matthew",
                    HireDate = DateTime.Now.AddMonths(1).Date
                }, new Instructor
                {
                    ID = 3,
                    LastName = "Harja",
                    FirstMidName = "Steven",
                    HireDate = DateTime.Now.Date
                });

            context.OfficeAssignments.AddRange(
                new OfficeAssignment
                {
                    InstructorID = 1,
                    Location = "123 Fake Street"
                }, new OfficeAssignment
                {
                    InstructorID = 2,
                    Location = "456 Real Street"
                }, new OfficeAssignment
                {
                    InstructorID = 3,
                    Location = "678 TooReal Street"
                });

            context.Students.AddRange(
                new Student 
                {
                    ID = 1,
                    LastName = "Krana",
                    FirstMidName = "Jason",
                    EnrollmentDate = DateTime.Now.Date
                }, new Student
                {
                    ID = 2,
                    LastName = "Terra",
                    FirstMidName = "Anna",
                    EnrollmentDate = DateTime.Now.AddDays(3).Date
                }, new Student
                {
                    ID = 3,
                    LastName = "Blanca",
                    FirstMidName = "Arti",
                    EnrollmentDate = DateTime.Now.AddMonths(1).Date
                });
            context.SaveChanges();
        }
    }
}
