using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {

            Student person = new Student("Egor", "Tolkov", 18, "Ukraine", "Kherson", "Sinyavina");
            person.GetInfo();

            Teacher teacher = new Teacher("Jeck", "Vorobey", 35, "Iran", "Tigeran", "Azadi");
            teacher.GetInfo();

            Teacherlist teacherlist = new Teacherlist();



        }
    }
}
