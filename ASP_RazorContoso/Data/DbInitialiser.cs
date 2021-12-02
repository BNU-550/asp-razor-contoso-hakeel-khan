using ASP_RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {

            AddStudents(context);
            AddCourses(context);
            AddEnrollments(context);
            AddModules(context);

        }

            private static void AddStudents(ApplicationDbContext context)
            {
                // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
                };

                context.Students.AddRange(students);
                context.SaveChanges();
            }

            private static void AddCourses(ApplicationDbContext context)
            {
                if (context.Modules.Any())
                {
                return; //DB has been seeded
                }

            Module co550 = new Module
            {
                ModuleID = "CO550",
                Title = "Web applications"
            };

            Module co588 = new Module
            {
                ModuleID = "CO588",
                Title = "Database Design"
            };

            Module co567 = new Module
            {
                ModuleID = "CO567",
                Title = "OO Systems Development"
            };

            Module co566 = new Module
            {
                ModuleID = "CO566",
                Title = "Mobile Systems"
            };

            var modules = new Module[]
            {
                co550, co566, co567, co588
            };

            context.Modules.AddRange(modules);
            context.SaveChanges();

            if (context.Courses.Any())
            {
                return; //DB has been seeded
            }

            var courses = new Course[]
            {
                new Course
                {
                    CourseID = "BT1CTG1",
                    Title = "Computing",
                    Modules = new List<Module>(co550,co566,co567,co588)
                },
                new Course
                {
                    CourseID = "BT1CWD1",
                    Title = "Computing and Web",
                    Modules = new List<Module>(co550,co566,co567,co588)
                },
                    new Course{CourseID="BB1DSC1",Title="Data Science"},
                    new Course{CourseID="BT1SFT1",Title="Software Engineering"},
                    new Course{CourseID="BB1ARI1",Title="Artificial Intelligence"},
                    new Course{CourseID="MT1CYS1",Title="Cyber Security"},
                    new Course{CourseID="BT1GDV1",Title="Games Development"}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            ///var courses = new Course[]
            //{
            //new Course{CourseID=1050,Title="Computing",Credits=3},
            //new Course{CourseID=4022,Title="Computing and Web",Credits=3},
            //new Course{CourseID=4041,Title="Data Science",Credits=3},
            //new Course{CourseID=1045,Title="Software Engineering",Credits=4},
            //new Course{CourseID=3141,Title="Artificial Intelligence",Credits=4},
            //new Course{CourseID=2021,Title="Cyber Security",Credits=3},
            //new Course{CourseID=2042,Title="Games Development",Credits=4}
            //};

            //context.Courses.AddRange(courses);
            ///context.SaveChanges();///
        }

        private static void AddEnrollments(ApplicationDbContext context)
            {
                var enrollments = new Enrollment[]
                {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
                };

                context.Enrollments.AddRange(enrollments);
                context.SaveChanges();
            }

        private static void AddModules(ApplicationDbContext context)
        {
            if (context.Modules.Any())
            {
                return; //DB has been seeded
            }

            var modules = new Module[]
            {
                new Module
                {
                    ModuleID = "CO550",
                    Title = "Web Application",
                    Courses = new List<Course> {computing, computingWeb}
                },
                new Module
                {
                    ModuleID = "CO558",
                    Title = "Database Design",
                    Courses = new List<Course> {computing, computingWeb}
                },
                new Module
                {
                    ModuleID = "CO567",
                    Title = "DO Systems Development",
                    Courses = new List<Course> {computing, computingWeb}
                },
                new Module
                {
                    ModuleID = "CO566",
                    Title = "Mobile Systems",
                    Courses = new List<Course> {computing, computingWeb}
                },
            };

            context.Modules.AddRange(modules);
            context.SaveChanges(true);
        }
    }
}

