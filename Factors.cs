using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Factors
    {
        public static void Main()
        {
            int num;

            Console.Write("Enter a number :");
            num = Int32.Parse(Console.ReadLine());

            bool prime = true;

            Console.WriteLine($"Factors for number {num}");     // 6.0
            Console.WriteLine("Factors for number {0}", num);

            for (int i =2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is factor of {1}",i, num);
                    prime = false; 
                }
            }

            if (prime)
                Console.WriteLine("Prime Number!");

        }
    }
}
