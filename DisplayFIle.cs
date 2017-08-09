using System;
using System.IO;

namespace csharpdemo
{
    class DisplayFile
    {
        public static void Main()
        {
            string sourcefilename = @"f:\classroom\names.txt";
            try
            {
                StreamReader sr = new StreamReader(sourcefilename);
                // Console.WriteLine(sr.ReadToEnd());

                int count = 1;
                int total = 0;
                while(true)
                {
                    string line = sr.ReadLine();
                    if (line == null)  // EOF
                        break;

                    if (line.Length == 0)
                        continue;

                    Console.WriteLine("{0:000} :{1}",count++,line);
                    total += line.Length;
                }

                Console.WriteLine("Average Length : {0}", total / count - 1);
                sr.Close();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry! File cannot be opened! Error : " + ex.Message );
            }


        }
    }
}
