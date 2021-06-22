using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkReport
{
    public class Student
    {
        string Name, StudentId, Gender, Location;
        int Age;
        public Student()
        {

        }
        public Student(string name, string studentid, int age, string gender, string location)
        {
            Name = name;
            StudentId = studentid;
            Age = age;
            Gender = gender;
            Location = location;
        }
        public virtual void Input()
        {
            Console.Write("Full Name: "); Name = Console.ReadLine();
            Console.Write("Student ID: "); StudentId = Console.ReadLine();
            Console.Write("Age: "); Age = int.Parse(Console.ReadLine());
            Console.Write("Gender: "); Gender = Console.ReadLine();
            Console.Write("Location: "); Location = Console.ReadLine();
        }
        public virtual void Print()
        {
            Console.WriteLine("Full Name: " + Name);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Location: " + Location);
        }
    }
}
