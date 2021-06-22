using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkReport
{
    public class Mark : Student
    {
        double Math, Literature, English;
        public Mark() : base()
        {

        }
        public Mark(string name, string studentid, int age, string gender, string location, double math, double literature, double english)
            : base(name, studentid, age, gender, location)
        {
            Math = math;
            Literature = literature;
            English = english;
        }

        double Total()
        {
            double total = (Math + Literature + English) / 3;
            return (total);
        }
        public override void Input()
        {
            Console.WriteLine("=== Input Information ===");
            base.Input();
            Console.WriteLine("=========================");
            Console.Write("Math Score: "); Math = double.Parse(Console.ReadLine());
            Console.Write("Literature Score: "); Literature = double.Parse(Console.ReadLine());
            Console.Write("English Score: "); English = double.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("=========================");
            Console.WriteLine("====== Mark Report ======");
            base.Print();
            Console.WriteLine("=========================");
            Console.WriteLine("Math scores: " + Math);
            Console.WriteLine("Literature scores: " + Literature);
            Console.WriteLine("English scores: " + English);
            Console.WriteLine("=========================");
            Console.WriteLine("Total: " + Total());
            Console.ReadKey();
        }
    }
}
