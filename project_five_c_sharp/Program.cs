using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_five_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create two lists with integer data type, one for even numbers and one for odd numbers
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            // let the user enter number to loop through
            int number;
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out number))
            {
                Console.Write("Here we go again, please enter a number: ");
                input =Console.ReadLine();
            }

            // if the number is even, add it to the even list
            // if the number is odd, add it to the odd list
            for (int i = 1; i <= number; i++)
            {
                if ( i % 2 == 0)
                {
                    evenNumbers.Add(i);
                } else 
                { 
                    oddNumbers.Add(i);
                }
            }

            // print the even and odd lists
            Console.Write("Odd Numbers: ");
            for (int i = 0; i < oddNumbers.Count; i++)
            {
                Console.Write($" {oddNumbers[i]} ");
                System.Threading.Thread.Sleep(100);
            }
           
            Console.WriteLine("");

            Console.Write("Even Numbers: ");
            for (int i = 0; i < evenNumbers.Count; i++)
            {
                Console.Write($" {evenNumbers[i]} ");
                System.Threading.Thread.Sleep(100);
            }

        
            Console.ReadLine();

        }
    }
}
