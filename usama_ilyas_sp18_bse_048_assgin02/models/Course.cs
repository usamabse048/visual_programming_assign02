using System;
using System.Collections.Generic;
using System.Text;

namespace usama_ilyas_sp18_bse_048_assign02.models
{
    class Course
    {
        private String name;
        private double creditHrs = 3.0;
        bool registered = false;

     

        public Course(string name, double creditHrs, bool registered)
        {
            this.name = name;
            this.creditHrs = creditHrs;
            this.registered = registered;
        }

        public Course(String name)
        {
            this.name = name;
        }


        public double CreditHrs { get => creditHrs; set => creditHrs = value; }
        public bool Registered { get => registered; set => registered = value; }
        public string Name { get => name; set => name = value; }
    }
}
