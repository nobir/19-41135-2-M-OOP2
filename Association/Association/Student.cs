using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string id;
        private string name;
        private float cgpa;

        private Department dept;

        private int courseCount;
        private Course[] courses;

        public Student()
        {
            this.courses = new Course[5];
        }

        public Student(string id, string name, float cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa = cgpa;
            this.courses = new Course[5];
        }

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }

        }

        public float Cgpa
        {
            set { this.cgpa = value; }
            get { return this.cgpa; }
        }

        public Department Dept
        {
            set { this.dept = value; }
            get { return this.dept; }
        }

        public int CourseCount
        {
            set { this.courseCount = value; }
            get { return this.courseCount; }
        }

        public void AddCourse(params Course[] crs)
        {
            foreach (Course c in crs)
            {
                this.courses[this.courseCount++] = c;
                if (c.GetStudent(this.Id) == null)
                    c.AddStudent(this);
            }
        }

        /*
        public void RemoveCourse(Course c)
        {
            if (c == this.courses[this.courseCount])
            {
                this.courses[this.courseCount--] = null;
                return;
            }

            bool notFound = true;
            for (int i = 0; i < this.courseCount - 1; ++i)
            {
                if (c == this.courses[i] && notFound)
                {
                    this.courses[i] = null;
                    notFound = false;
                }

                if (!notFound)
                    this.courses[i] = this.courses[i + 1];

            }
        }
        */

        public Course GetCourse(string id)
        {
            for (int i = 0; i < this.CourseCount; ++i)
                if (id == this.courses[i].Id)
                    return this.courses[i];

            return null;
        }

        public void PrintCourse()
        {
            for (int i = 0; i < this.CourseCount; ++i)
            {
                this.courses[i].ShowCourseInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("CGPA: {0}", this.Cgpa);
        }

        public void ShowDepartment()
        {
            this.ShowInfo();
            this.Dept.ShowInfo();
        }
    }
}
