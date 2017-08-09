using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DatesDemo
    {
        public static void Main()
        {
            Console.Write("Enter DOB [yyyy-mm-dd] : ");
            string dobstr = Console.ReadLine();


            DateTime today = DateTime.Now;
            DateTime dob;

            if (DateTime.TryParse(dobstr, out dob))
            {
                TimeSpan diff = today.Subtract(dob);
                Console.WriteLine(diff.Days / 365);
            }
            else
                Console.WriteLine("Sorry! Invalid Date");
        }
    }
}
