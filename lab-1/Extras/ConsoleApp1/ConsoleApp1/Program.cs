using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public class Student
{
    public string Name;

    public int id;

    public int yearOfStudy;

    public Student(string aName, int anId, int aYearOfStudy)
    {

        Name = aName;

        id = anId;

        yearOfStudy = aYearOfStudy;

    }

    public int yearInc(int year)
    {

        year++;

        return year;

    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mike", 1234, 1);

            Console.WriteLine(student1.Name);

            Student.yearInc(student1.yearOfStudy);

            Console.WriteLine(student1.yearOfStudy);

            Console.ReadLine();
        }

        
    }
}
