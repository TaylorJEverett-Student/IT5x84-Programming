using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace StudentGrade
{
    public partial class frmSalary : Form
    {
        double d_GrossPay;
        double d_Tax;
        double d_Loan;
        double d_KiwiSaverOwn;
        double d_KiwiSaverBoss;
        double d_Awesomeness;
        double d_Politeness;

        public frmSalary()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private double CalcNetPay()
        {
            return d_GrossPay - d_Tax - d_Loan - d_Awesomeness - d_KiwiSaverOwn + d_KiwiSaverBoss + d_Politeness;
        }

        private void GetDataFromUser()
        {
            //To get input from form and convert them into number format
            double d_getHourWorked;
            double.TryParse(txtHours.Text, out d_getHourWorked);

            double d_getPayRate;
            //d_getPayRate = Convert.ToDouble(txtRate.Text);
            double.TryParse(txtRate.Text, out d_getPayRate);

            double d_getTaxRate;
            //d_getTaxRate = Convert.ToDouble(txtTaxRate.Text);
            double.TryParse(txtTaxRate.Text, out d_getTaxRate);

            double d_getLoanRate;
            double.TryParse(txtLoanRate.Text, out d_getLoanRate);

            //if (double.TryParse(txtLoanRate.Text,out d_getLoanRate))
            //{
            //    d_getLoanRate = Convert.ToDouble(txtLoanRate.Text);
            //}
            //else { d_getLoanRate = 0; }


            double d_KiwiSaverOwnRate;
            //d_KiwiSaverOwnRate = Convert.ToDouble(txtKiwiSaverOwn.Text);
            double.TryParse(txtKiwiSaverOwn.Text, out d_KiwiSaverOwnRate);


            //From the input, call associated methods to perform calculation
            //Verify if corresponding checkbox is selected prior to calculation
            d_GrossPay = CalcGrossPay(d_getHourWorked, d_getPayRate);
            d_Tax = CalcTax(d_GrossPay, d_getTaxRate);

            if (chkLoan.Checked)
            { d_Loan = CalcStudentLoan(d_GrossPay, d_getLoanRate); }
            else { d_Loan = 0; }

            if (chkKiwiSaverOwn.Checked)
            { d_KiwiSaverOwn = CalcKiwiSaverOwn(d_GrossPay, d_KiwiSaverOwnRate); }
            else { d_KiwiSaverOwn = 0; }

            if (chkKiwiSaverBoss.Checked)
            { d_KiwiSaverBoss = CalcKiwiSaverBoss(d_GrossPay); }
            else { d_KiwiSaverBoss = 0; }

            if (chkAwesomeness.Checked)
            //{ d_Awesomeness = Convert.ToDouble(txtAwesomeness.Text); }
            { double.TryParse(txtAwesomeness.Text, out d_Awesomeness); }
            else { d_Awesomeness = 0; }

            if (chkPoliteness.Checked)
            //{ d_Politeness = Convert.ToDouble(txtPoliteness.Text); }
            { double.TryParse(txtPoliteness.Text, out d_Politeness); }
            else { d_Politeness = 0; }
        }

        private double CalcGrossPay (double HoursWorked, double PayRate)
        {
            return HoursWorked * PayRate;
        }

        private double CalcTax (double GrossPay, double TaxRate)
        {
            return GrossPay * TaxRate / 100;
        }

        private double CalcStudentLoan (double GrossPay, double LoanRate)
        {
            return GrossPay * LoanRate / 100;
        }

        private double CalcKiwiSaverOwn (double GrossPay, double KiwiSaverOwnRate)
        {
            return GrossPay * KiwiSaverOwnRate / 100;
        }

        private double CalcKiwiSaverBoss (double GrossPay)
        {
            return GrossPay * 3 / 100;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetDataFromUser();
            lblResult.Text = CalcNetPay().ToString();
        }
    }
}
