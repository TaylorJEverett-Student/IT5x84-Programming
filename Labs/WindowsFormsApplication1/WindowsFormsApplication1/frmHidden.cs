﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmHidden : Form
    {
        public frmHidden()
        {
            InitializeComponent();
        }
Form frmMain = new Form1();
        private void frmHidden_Load(object sender, EventArgs e)
        {
            
            //frmMain.Show();
            //this.Close();
        }

    }
}
