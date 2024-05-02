using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Try block: Code that might throw an exception
                int result = Divide(10, 0);
                Console.WriteLine("Result of division: " + result);
            }
            //catch (DivideByZeroException ex)
            //{
            //    // Catch block: Handle the specific exception (DivideByZeroException)
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //    Console.WriteLine("Exception Details: " + ex.Message);
            //}
            catch (Exception ex)
            {
                // Catch block: Handle other exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Finally block: Code that always executes, whether an exception occurred or not
                Console.WriteLine("End of program.");
            }
            Console.ReadLine();
        }

        static int Divide(int dividend, int divisor)
        {
            // Check if the divisor is zero
            if (divisor == 0)
            {
                // Throw a DivideByZeroException
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            // Perform the division
            return dividend / divisor;
        }
    }

}
