using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * One to One Association
             */

            Student s1 = new Student("123", "Nobir 1", 2.5F);
            Student s2 = new Student("132", "Nobir 2", 3.6F);
            Student s3 = new Student("321", "Nobir 3", 3.7F);

            Department d1 = new Department("CS", "Computer Science");
            Department d2 = new Department("EEE", "Electrical & Electronic Engineering");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d2;

            s1.ShowInfo();
            s1.ShowDepartment();

            s2.ShowInfo();
            s2.ShowDepartment();

            s3.ShowInfo();
            s3.ShowDepartment();

            // Changing the department and
            // it will change all the student department who is associated with it
            d1.Name = "Computer Science & Engineering";

            s1.ShowInfo();
            s1.ShowDepartment();


            /**
             * One to Many Association
             */

            d1.AddStudent(s1);
            d1.AddStudent(s2);
        }
    }
}
