using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Human
    {
        private string name;
        private string surname;
        private int age;

        private Adress_ adress = new Adress_();

        public string Name { set; get; }
        public string Surname { set; get; }
        public int Age { set; get; }

        public Human(string Name, string Surname, int Age, string Region, string Country, string Street)
        {
            name = Name;
            surname = Surname;
            age = Age;
            adress.Adress1(Region, Country, Street);
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name = {0} Surname = {1} Age = {2}", this.name, this.surname, this.age); adress.GetInfo();
        }
    }
}
