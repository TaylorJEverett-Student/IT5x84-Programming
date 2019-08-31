using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public class CalculateSalary
        {
            public double CalculateNetPay(double Grosspay, double TaxRate, double Allowance, double Deduction)
            {
                return Grosspay * TaxRate / 100 + Allowance - Deduction;
            }
        }
        private static void mv_Payment()
        {
            CalculateSalary c_CalcSalary = new CalculateSalary();
            MessageManagement c_Message = new MessageManagement();
            double d_GrossPay, d_TaxRate, d_Allowance, d_Deduction, d_Netpay;

            try
            {
                Console.Write("Enter Gross pay   : $ ");
                d_GrossPay = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Tax rate (%)   : ");
                d_TaxRate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Allowance   : $ ");
                d_Allowance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Deduction   : $ ");
                d_Deduction = Convert.ToDouble(Console.ReadLine());

                d_Netpay = c_CalcSalary.CalculateNetPay(d_GrossPay, d_TaxRate, d_Allowance, d_Deduction);
                c_Message.DisplayMessage("Your Net Pay is     : $ " + d_Netpay);
            }
            catch
            {
                c_Message.DisplayErrorMessage();
                Console.Clear();
                goto StartInput;
            }
        }

        static void Main(string[] args)
        {
            mv_Payment();
        }
    }
}
