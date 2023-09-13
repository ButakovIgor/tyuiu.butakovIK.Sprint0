using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.butakovIK.sprint0.task5.v0.lib;

namespace tyuiu.butakovIK.sprint0.task5.v0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B =" + DataService.Addition(10, 5));
            Console.WriteLine("A - B =" + DataService.Subtraction(20, 5));
            Console.WriteLine("A * B =" + DataService.Multiplication(10, 15));
            Console.WriteLine("A / B =" + DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}
