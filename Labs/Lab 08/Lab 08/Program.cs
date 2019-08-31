using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s_TextContent;
                s_TextContent = System.IO.File.ReadAllText("textfile.helloext");
                Console.WriteLine(s_TextContent);
            }
            catch
            {
                Console.WriteLine("File not found");
            }
            try
            {
                string[] as_s_TextContentByLines = System.IO.File.ReadAllLines("textfile.helloext");
                for (int i_count = 0; i_count < as_s_TextContentByLines.Length; i_count++)
                {
                    Console.WriteLine(as_s_TextContentByLines[i_count]);
                }
            }
            catch
            {
                Console.WriteLine("File not found or array index out of bound!");
            }
            //Console.Clear();
        }
    }
}
