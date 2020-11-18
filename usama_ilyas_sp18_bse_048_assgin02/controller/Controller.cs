using System;
using System.Collections.Generic;
using System.Text;
using usama_ilyas_sp18_bse_048_assign02.models;
using System.Linq;

namespace usama_ilyas_sp18_bse_048_assign02.controller
{
    class Controller
    {
        public static List<Student> students = new List<Student>();

        public static int currentUser = -1;

       static Course sda = new Course("Software Design and Architecture");
        static Course hci = new Course("Human Computer Interaction");
        static Course vp = new Course("Visual Programming");
        static Course sqe = new Course("Software Quality Engineering");
        static Course spm = new Course("Software Project Management");
       

        static List<Course> courses =new List<Course> {sda,hci,vp,sqe,spm};


        public static void addAccount(Student student)
        {
            students.Add(student);
            Console.WriteLine("Account Created");

        }
        public static bool authentication(String regNum, String password)
        {
            bool userMatched = false;

            for(int i = 0;i< students.Count; i++)
            {
                if (regNum.Equals(students.ElementAt(i).RegNum ) && password.Equals(students.ElementAt(i).Password))
                {
                    Console.WriteLine("Welcome" + students.ElementAt(i).Name);
                    currentUser = i;
                    userMatched = true;
                    
                }
                
            }

            return userMatched;
        }

    }
}
