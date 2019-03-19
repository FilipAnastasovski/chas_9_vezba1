using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please write a number");
            //int number = 0;

            // try catch without exception

            //try
            //{
            //     number = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"the number is {number}");
            //}
            //catch
            //{
            //    Console.WriteLine("There was an error. Please contact Bor4e");
            //    Console.WriteLine("+38970999999999");
            //}


            // try/catch pecific ex and use to show ex
            //try
            //{
            //    number = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"the number is {number}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"There was an error. {ex.Message}");
            //    Console.WriteLine( " Please contact Bor4e");
            //    Console.WriteLine("+38970999999999");
            //}
            //finally
            //{
            //    Console.WriteLine("Application is done.");
            //}


            Console.WriteLine("please enter a or b");
            char letter = ' ';

            try
            {
                letter = char.Parse(Console.ReadLine());

                if (letter != 'a' && letter != 'b')
                {
                    throw new Exception("that was not a or b, you broke the app");
                }
                Console.WriteLine($"you entered {letter}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"ova e format exception {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"There was an error {ex.Message}");
                Console.WriteLine("contact supp");
            }
            
         



            Console.ReadLine();


        }
    }
}
