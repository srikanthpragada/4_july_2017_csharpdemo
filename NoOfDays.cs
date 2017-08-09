using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class NoOfDays
    {
        public static void Main()
        {
            Console.Write("Enter month number [1-12] :");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter year :");
            int year = Int32.Parse(Console.ReadLine());

            int nodays; 

            switch(month)
            {
                case 2 :
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        nodays = 29;
                    else
                        nodays = 28;
                    break;
                case 4 :
                case 6 :
                case 9 :
                case 11: nodays = 30; break;
                default:
                    nodays = 31;
                    break;
            }

            Console.WriteLine($"No. of days in month {month} is {nodays}");

        }
    }
}
