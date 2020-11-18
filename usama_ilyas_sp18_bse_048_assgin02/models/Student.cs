using System;
using System.Collections.Generic;
using System.Text;

namespace usama_ilyas_sp18_bse_048_assign02.models
{
    class Student
    {
        private String name;
        private String regNum;
        private String password;
        private double creditHrs = 0.0;
        private List<Course> registeredCourses = new List<Course>();

        public Student(string name, string regNum, string password, double creditHrs, List<Course> registeredCourses)
        {
            this.name = name;
            this.regNum = regNum;
            this.password = password;
            this.creditHrs = creditHrs;
            this.registeredCourses = registeredCourses;
        }

        public Student(string name, string regNum, string password)
        {
            this.name = name;
            this.regNum = regNum;
            this.password = password;
           
        }

        public string Name { get => name; set => name = value; }
        public string RegNum { get => regNum; set => regNum = value; }
        public string Password { get => password; set => password = value; }
        public double CreditHrs { get => creditHrs; set => creditHrs = value; }
        internal List<Course> RegisteredCourses { get => registeredCourses; set => registeredCourses = value; }

        public void addCourse(Course course)
        {
            if (this.registeredCourses.Count < 3)
            {
                this.registeredCourses.Add(course);
                this.creditHrs = this.creditHrs + course.CreditHrs;
            }
            else
            {
                Console.WriteLine("Sorry cannot register more than 9 credit hrs");

            }
          
        }
    }
}
