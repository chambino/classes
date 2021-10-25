using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Student : Human
    {
        private marks Rating;
        private int averagemarks;

        private int[] mass;

        public Student(string Name, string Surname, int Age, string Country, string Region, string Street) : base(Name, Surname, Age, Country, Region, Street)
        {
            mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random();
                mass[i] = rand.Next(1, 6);

            }

            int Sum = 0;
            int averagemarks;
            for (int i = 0; i < 5; i++)
            {
                Sum += mass[i];
                
            }

            averagemarks = Sum / 5;

            switch(averagemarks)
            {
                case 1:
                    Rating = marks.E;
                    break;
                case 2:
                    Rating = marks.D;
                    break;
                case 3:
                    Rating = marks.C;
                    break;
                case 4:
                    Rating = marks.B;
                    break;
                case 5:
                    Rating = marks.A;
                    break;

            }

        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"averagemark: {averagemarks} rating: {Rating}");
        }

    }

}
