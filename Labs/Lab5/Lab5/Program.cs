using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        private struct strEmployee
        {
            public int i_StaffID;
            public string s_Name;
            public int i_Age;
        }
        static void Main(string[] args)
        {
            strEmployee[] str_StaffInfo = new strEmployee[10];
            str_StaffInfo[0].i_StaffID = 120;
            str_StaffInfo[1].i_StaffID = 231;
            str_StaffInfo[2].i_StaffID = 321;
            str_StaffInfo[3].i_StaffID = 323;
            str_StaffInfo[4].i_StaffID = 123;
            str_StaffInfo[5].i_StaffID = 543;
            str_StaffInfo[6].i_StaffID = 432;
            str_StaffInfo[7].i_StaffID = 634;
            str_StaffInfo[8].i_StaffID = 907;
            str_StaffInfo[9].i_StaffID = 148;

            str_StaffInfo[0].s_Name = "Mark";
            str_StaffInfo[1].s_Name = "John";
            str_StaffInfo[2].s_Name = "Alex";
            str_StaffInfo[3].s_Name = "Rob";
            str_StaffInfo[4].s_Name = "Bob";
            str_StaffInfo[5].s_Name = "Mary";
            str_StaffInfo[6].s_Name = "Eve";
            str_StaffInfo[7].s_Name = "Joel";
            str_StaffInfo[8].s_Name = "Dita";
            str_StaffInfo[9].s_Name = "Liz";

            str_StaffInfo[0].i_Age = 45;
            str_StaffInfo[1].i_Age = 60;
            str_StaffInfo[2].i_Age = 28;
            str_StaffInfo[3].i_Age = 54;
            str_StaffInfo[4].i_Age = 67;
            str_StaffInfo[5].i_Age = 49;
            str_StaffInfo[6].i_Age = 24;
            str_StaffInfo[7].i_Age = 34;
            str_StaffInfo[8].i_Age = 44;
            str_StaffInfo[9].i_Age = 34;

            for (int i_Count = 0; i_Count <= 9; i_Count++)
            {
                Console.WriteLine(str_StaffInfo[i_Count].i_StaffID + ", " + str_StaffInfo[i_Count].s_Name + ", " + str_StaffInfo[i_Count].i_Age);
            }
        }
    }
}
