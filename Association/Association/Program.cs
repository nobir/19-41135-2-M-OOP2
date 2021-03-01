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

            d1.PrintStudent();

            /**
             * Many to Many Association
             */

            Course c1 = new Course("mat101", "Math 1");
            Course c2 = new Course("mat102", "Math 2");
            Course c3 = new Course("mat103", "Math 3");
            Course c4 = new Course("mat104", "Math 4");

            Student s4 = new Student("213", "Nobir 4", 3.8F);
            Student s5 = new Student("231", "Nobir 5", 2.85F);
            Student s6 = new Student("312", "Nobir 6", 3.83F);
            Student s7 = new Student("321", "Nobir 7", 3.82F);
            Student s8 = new Student("341", "Nobir 8", 3.86F);
            Student s9 = new Student("512", "Nobir 9", 3.81F);

            c1.AddStudent(s1, s2, s3, s4);
            c2.AddStudent(s1, s6, s3, s8, s9);

            c1.PrintStudent();
            c2.PrintStudent();

            s1.PrintCourse();
            s3.PrintCourse();
        }
    }
}
