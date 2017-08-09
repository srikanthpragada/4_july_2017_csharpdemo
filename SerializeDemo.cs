using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class SerializeDemo
    {
        public static void Main()
        {
            Person p = new Person { Name = "Scott",
                                    Email = "scott@microsoft.com",
                                    Mobile = "3939393939" };

            FileStream fs = new FileStream(@"f:\classroom\july4\scott.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p);
            fs.Close();


        }
    }
}
