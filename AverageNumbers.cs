using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Negative Number")
        {

        }
    }
    class AverageNumbers
    {
        public static void Main()
        {
            int num, sum = 0;

            for(int i=1; i <= 5;  )
            {
                try
                {
                    Console.Write("Enter a number :");
                    num = Int32.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new NegativeNumberException();

                    sum += num;
                    i++;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Sorry! Invalid Number. Please try again!");
                }
                catch (NegativeNumberException ex)
                {
                    Console.WriteLine("Sorry! Negative number is not allowed. Please try again!");
                }
                finally
                {
                    Console.WriteLine("Finally Block");
                }
            }

            Console.WriteLine("Average  : {0}", sum / 5);

        }
    }
}
