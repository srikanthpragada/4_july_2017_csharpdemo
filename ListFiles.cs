using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ListFiles
    {
        public static void Main()
        {
            Console.Write("Enter directory : ");
            // string dirname = Console.ReadLine();
            string dirname = @"f:\classroom";

            DirectoryInfo dinfo = new DirectoryInfo(dirname);

            foreach(FileSystemInfo fsinfo in dinfo.GetFileSystemInfos())
            {
                if (fsinfo is DirectoryInfo)
                   Console.WriteLine("{0}  <Dir>",fsinfo.Name.PadRight(50));
                else
                   Console.WriteLine("{0}  {1:########}",fsinfo.Name.PadRight(50), ((FileInfo) fsinfo).Length);
            }
        }
    }
}
