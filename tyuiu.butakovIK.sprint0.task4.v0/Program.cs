using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.butakovIK.sprint0.task4.v0.lib;

namespace tyuiu.butakovIK.sprint0.task4.v0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(10, 5));
            Console.WriteLine(DataService.Subtraction(15, 5));
            Console.WriteLine(DataService.Multiplication(10, 15));
            Console.WriteLine(DataService.Division(100, 5));
            Console.ReadKey();
        }
    }
}
