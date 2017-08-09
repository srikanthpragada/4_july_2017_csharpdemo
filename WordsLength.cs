using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class WordsLength
    {
        public static void Main()
        {
            string line;


            Console.Write("Enter a string :");
            line = Console.ReadLine();

            Console.WriteLine(line[0]);

            string  [] words = line.Split(' ', ',', '.', ':');
                        

            foreach (string w in words)
                Console.WriteLine("{0} - {1}", w, w.Length);

        }
    }
}
