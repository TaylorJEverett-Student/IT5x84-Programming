using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai_StaffID = new int[10];
            string[] as_Name = new string[10];
            int[] ai_Age = { 45, 60, 28, 54, 67, 49, 24, 34, 44, 34 };

            ai_StaffID[0] = 120;
            ai_StaffID[1] = 231;
            ai_StaffID[2] = 321;
            ai_StaffID[3] = 325;
            ai_StaffID[4] = 123;
            ai_StaffID[5] = 543;
            ai_StaffID[6] = 432;
            ai_StaffID[7] = 634;
            ai_StaffID[8] = 907;
            ai_StaffID[9] = 146;

            as_Name[0] = "Mark";
            as_Name[1] = "John";
            as_Name[2] = "Alex";
            as_Name[3] = "Rob";
            as_Name[4] = "Bob";
            as_Name[5] = "Mary";
            as_Name[6] = "Eve";
            as_Name[7] = "Joel";
            as_Name[8] = "Dita";
            as_Name[9] = "Liz";

            for (int i_Count = 0; i_Count <= 9; i_Count++)
            {
                Console.WriteLine(ai_StaffID[i_Count] + ", " + as_Name[i_Count] + ", " + ai_Age[i_Count]);
            }
        }
    }
}
