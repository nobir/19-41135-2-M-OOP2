using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Student
    {
        string name;
        int age;
        readonly string id;
        float cgpa;

        public Student()
        {
            this.name = "";
            this.age = 0;
            this.id = "19-xxxxx-2";
            this.cgpa = 0.0F;
        }

        public Student(string name, int age, string id, float cgpa)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.cgpa = cgpa;
        }

        /**
         * Properties or Accessores
         */

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        public string Id
        {
            // Can't set value cause it's a readonly property
            // set { this.id = value; }
            get { return this.id; }
        }

        public float CGPA
        {
            set { this.cgpa = value; }
            get { return this.cgpa; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("CGPA: {0}", this.CGPA);
        }

        /*

        internal void SetName(string name)
        {
            this.name = name;
        }

        protected void SetAge(int age)
        {
            this.age = age;
        }

        internal void SetId(string id)
        {
            this.id = id;
        }

        internal void SetCGPA(float cgpa)
        {
            this.cgpa = cgpa;
        }

        internal string GetName()
        {
            return this.name;
        }

        protected int GetAge()
        {
            return this.age;
        }

        internal string GetId()
        {
            return this.id;
        }

        internal float GetCGPA()
        {
            return this.cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", this.GetName());
            Console.WriteLine("ID: {0}", this.GetId());
            Console.WriteLine("Age: {0}", this.age);
            Console.WriteLine("CGPA: {0}", this.cgpa);
        }
        */
    }
}
