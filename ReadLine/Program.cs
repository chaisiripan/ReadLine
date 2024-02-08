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

            Console.Write("Enter number 1 : ");
            string num1 = Console.ReadLine();
            Console.Write("Enter number 2 : ");
            string num2 = Console.ReadLine();
            Console.WriteLine("You insert number 1 is {0} and number 2 is {1}", num1, num2);

            Console.Write("Enter number 3 : ");
            string num3 = Console.ReadLine();
            Console.Write("Enter number 4 : ");
            string num4 = Console.ReadLine();
            Console.WriteLine("You insert number 3 is {0} and number 4 is {1}", num3, num4);
        }
    }
}
