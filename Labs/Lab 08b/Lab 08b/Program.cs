using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] as_Content = System.IO.File.ReadAllText("TextWithValue.csv").Split(',');
                for (int i_count = 0; i_count < as_Content.Length; i_count++)
                {
                    Console.WriteLine(as_Content[i_count]);
                }
                Console.WriteLine("Specific code:" + as_Content[15]);
            }
            catch
            {
                Console.WriteLine("File not found or out of bounds");
            }
            try
            {
                string[] as_AllContentByLine = System.IO.File.ReadAllLines("textMultiRowWithValues.coolext");
                string[,] as_Parts = new string[4, as_AllContentByLine.Length];
                for (int i_count = 0; i_count < as_AllContentByLine.Length; i_count++)
                {
                    string[] as_temp = as_AllContentByLine[i_count].Split(',');
                    as_Parts[0, i_count] = as_temp[0];
                    as_Parts[1, i_count] = as_temp[1];
                    as_Parts[2, i_count] = as_temp[2];
                    as_Parts[3, i_count] = as_temp[3];
                }
                Console.WriteLine(as_Parts[0, 3]);
            }
            catch
            {
                Console.WriteLine("File not found of index is out of bound!");
            }
        }
    }
}
