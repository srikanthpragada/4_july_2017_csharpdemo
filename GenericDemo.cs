using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
     
    class MyClass<T>
    {
        private T value;
        public void print()
        {
            Console.WriteLine(value);
        }

        public void setValue(T value)
        {
            this.value = value;
        }
    }


    class GenericDemo
    {
        public static void Main()
        {
            dynamic obj = new String('*', 10);
            Console.WriteLine(obj.Length);

            obj = DateTime.Now;
            Console.WriteLine(obj.Year);
        }

    }
}
