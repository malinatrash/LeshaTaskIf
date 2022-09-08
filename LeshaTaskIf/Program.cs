using System;
using System.Runtime.ConstrainedExecution;

namespace LeshaTaskIf
{
    public class Logic
    {
        public static int Calculate(int number)
        {
            var maxNumber = number / 10 % 10;

            if (number / 100 > maxNumber)
            {
                maxNumber = number / 100;
            }
            if (number % 10 > maxNumber)
            {
                maxNumber = number % 10;
            }

            return (maxNumber);
        }
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var anyNumber = int.Parse(Console.ReadLine());

            var response = Logic.Calculate(anyNumber);
            Console.WriteLine(response);
        }
    }
}