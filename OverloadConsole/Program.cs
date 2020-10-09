using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadConsole
{
    class Program
    {
        public void add(int FirstNumber,int SecondNumber)
        {
            Console.WriteLine("Sum=" + (FirstNumber + SecondNumber));
        }
        public void add(int FirstNumber, int SecondNumber,int ThirdNumber)
        {
            Console.WriteLine("Sum=" + (FirstNumber + SecondNumber+ ThirdNumber));
           
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add(10, 20);
            obj.add(10, 20,30);
            Console.ReadKey();
        }
    }
}
