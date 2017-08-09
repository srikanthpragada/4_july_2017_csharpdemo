using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class FunDemo
    {
        public static void Main(string [] args)
        {
            Print();
            Print("C#");
            Print("ASPNET",2); // Positional parameters
            Print(count : 2);  // Named parameter
        }

       
        public static void Print(string message = "Hello", int count = 5)  // default function argument
        {
            for(int i = 1; i <= count; i ++)
                Console.WriteLine(message);
        }
    }
}
