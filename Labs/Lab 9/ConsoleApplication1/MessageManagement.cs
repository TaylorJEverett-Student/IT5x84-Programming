using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MessageManagement
    {
        public void DisplayMessage(string TextMessage)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(TextMessage);
            Console.WriteLine("=================================");
        }
        public void DisplayErrorMessage()
        {
            DisplayMessage(" *** Error: Please check input. ***");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
