using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number Amount");
            int i_Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any key");
            String thing = Convert.ToString(Console.ReadLine());
            for (int x = 1; x <= i_Size; x++)
            {
                for (int y = 1; y <= i_Size - x; y++)
                {
                    Console.Write(" ");
                }

                for (int z = 1; z <= x; z++)
                {
                    Console.Write(thing + " ");
                }
                Console.WriteLine();
            }
            for (int x = i_Size - 1; x >= 1; x--)
            {
                for (int y = 1; y <= i_Size - x; y++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= x; z++)
                {
                    Console.Write(thing + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
