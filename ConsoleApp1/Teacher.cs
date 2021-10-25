using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Teacher : Human
    {
        private int number;

        private List<Student> student = new List<Student>();
        public Teacher(string Name, string Surname, int Age, string Country, string Region, string Street) : base(Name, Surname, Age, Country, Region, Street)
        {
            number = 0;

        }

        public void Add(Student person)
        {

            student.Add(person);
            number++;
            Console.WriteLine("Added ");

        }
        public void Remove(Student person)
        {
            if (number == 0)
            {
                Console.WriteLine("List is 0");
            }
            else
            {
                student.Remove(person);
                number--;

                Console.WriteLine("Deleted");
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine("Teacher: ");
            base.GetInfo();

        }
        public void StudentInfo()
        {

            Console.WriteLine("Students list: ");
            foreach (Student a in student)
            {

                a.GetInfo();

            }

        }


    }
}