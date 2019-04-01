using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first = 9;
            //int second = 0;

            //Console.WriteLine("Enter first number: ");
            //first = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //second = Int32.Parse(Console.ReadLine());

            //int result = Divide(first, second);
            //Console.WriteLine($"The result of dividing {first} and {second} is {result}");

            GetStudentInformation();
            PrintStudentDetails();
          
        }

        static int Divide(int first, int second)
        {

            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero for your second value");
            }
            return result;
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
        }

        static void PrintStudentDetails(string firstName, string secondName)
        {
            string info = firstName + secondName;
            Console.WriteLine($"{firstName} {secondName}");
            
        }
    }
}
