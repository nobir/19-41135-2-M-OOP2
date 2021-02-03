using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "Nobir Hossain";
            // Can't asign Id cause it's doesn't have setter
            // student.Id = "19-xxxxx-2";
            student.Age = 21;
            student.CGPA = 2.55F;
            student.ShowInfo();

            /*
            student.SetName("Nobir Hossain");
            student.SetId("19-xxxxx-2");
            student.SetAge(21);
            student.SetCGPA(2.55F);
            student.ShowInfo();
            */
        }
    }
}
