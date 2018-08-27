using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseWhichIsBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            String nam = Console.ReadLine();
            Console.WriteLine("Enter 2 Numbers: ");
            Console.WriteLine("Enter first Number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int biggerNum = secondNumber;

            if (firstNumber > secondNumber)
            {
                biggerNum = firstNumber;
            }
            Console.WriteLine("Hello, " + nam + " Thanks For playing");
            Console.WriteLine("The Bigger Number is: " + biggerNum);

            Console.ReadLine();




        }
    }
}
