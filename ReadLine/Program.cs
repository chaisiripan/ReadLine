using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();
            Console.Write("Enter you age: ");
            string age = Console.ReadLine();
            Console.WriteLine("You name is {0} and you age is {1} year olds", name, age);
        }
    }
}
