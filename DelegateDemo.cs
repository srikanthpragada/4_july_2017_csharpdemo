using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DelegateDemo
    {
        public static void Main()
        {
            string[] names = {"Bill Gates","Larry Ellison","Jobs", "Micheal Dell"};

            // string[] selnames = Array.FindAll(names, LongName);

            string[] selnames = Array.FindAll(names, n => n.Length < 10);

            foreach (string n in selnames)
                Console.WriteLine(n);

        }

        public static bool LongName(string name)
        {
            return name.Length > 10;
        }
    }
}
