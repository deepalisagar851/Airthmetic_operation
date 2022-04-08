using System;

namespace Airthmetic_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Addition is: {0}", num1 + num2);
            Console.WriteLine("The Substraction is: {0}", num1 - num2);
            Console.WriteLine("The Multiplication is: {0}", num1 * num2);
            Console.WriteLine("The Division is: {0}", num1 / num2);
        }
    }
}
