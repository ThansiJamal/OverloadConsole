using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadConsole
{
    class Program
    {
        public static void Add(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("Sum=" + (FirstNumber + SecondNumber));
        }
        public static void Add(int FirstNumber, int SecondNumber,int ThirdNumber)
        {
            Console.WriteLine("Sum=" + (FirstNumber + SecondNumber+ ThirdNumber));
           
        }
        static void Main(string[] args)
        {
            Add(10 ,10);
            Add(10, 20,30);
            Console.ReadKey();
        }
    }
}
