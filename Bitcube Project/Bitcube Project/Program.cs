using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Bitcube_Project
{

    //base class
    public class TrainingFacility
    {
        //child class1
        public class Student : TrainingFacility

        {
            private string forename;
            private string surname;
            private string email;
            private int DoB;
            private string Degree;

            public void StudentDetails()
            {
                Console.WriteLine("ForeName" + forename);
                Console.WriteLine("Surname"+ surname);
                Console.WriteLine("Email"+ email);
                Console.WriteLine("DateOfBirth" + DoB);
                Console.WriteLine("Degree" + Degree);
            }
                
        }
        //child class2
        public class Lecturer : TrainingFacility
        {
            private string forename;
            private string surname;
            private string email;
            private int DoB;
            private string DegreesResponsibleFor;

            public void LecturerDetails()
            {
                Console.WriteLine("ForeName" + forename);
                Console.WriteLine("Surname" + surname);
                Console.WriteLine("Email" + email);
                Console.WriteLine("Date Of Birth" + DoB);
                Console.WriteLine("Degrees Responsible For" + DegreesResponsibleFor);
            }
        }
        //child class3
        public class Degree : TrainingFacility
        {
            private string DegreeName;
            private string Courses;
            private int DurationInYears;
            private string LecturerInCharge;

            public void DegreeDetails()
            {
                Console.WriteLine("Degree Name" + DegreeName);
                Console.WriteLine("Courses" + Courses);
                Console.WriteLine("Duration" + DurationInYears);
                Console.WriteLine("Lecturer In Charge" + LecturerInCharge);
                
            }
        }
        //child class4
        public class Course : TrainingFacility
        {
            private string CourseName;
            private string DurationInMonths;
            private string CoursesPartOfDegree;

            public void CourseDetails()
            {
                Console.WriteLine("Course Name" + CourseName);
                Console.WriteLine("Duration In Months" + DurationInMonths);
                Console.WriteLine("Courses Part Of Degree" + CoursesPartOfDegree);
            }
        }


        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

       
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
