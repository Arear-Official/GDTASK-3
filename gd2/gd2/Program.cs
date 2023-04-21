using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("input a");
            while(!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("wrong number");
            }
            Console.WriteLine("input b");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("wrong number");
            }
            Console.WriteLine("input c");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("wrong number");
            }
            Console.WriteLine(Math.Sqrt((a + b + c) / 2 + (a - b + c) / 2 + (a + b - c) / 2 + (-a + b + c) / 2));
        }
    }
}
