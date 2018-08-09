using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSection
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Universe!");

            Console.WriteLine(Add(356, 564));

            Console.ReadLine();
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
