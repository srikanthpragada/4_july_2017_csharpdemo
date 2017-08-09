using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class DeserializeDemo
    {
        public static void Main()
        {
            Person p;

            FileStream fs = new FileStream(@"f:\classroom\july4\scott.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            p =(Person) bf.Deserialize(fs);

            Console.WriteLine("{0} {1} {2}", p.Name, p.Email, p.Mobile);
            fs.Close();
        }
    }
}
