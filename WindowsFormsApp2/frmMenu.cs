﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRockPaperScissors frmForm2 = new frmRockPaperScissors();
            frmForm2.ShowDialog();
        }

        private void hh_Click(object sender, EventArgs e)
        {
            Form3 frmForm3 = new Form3();
            frmForm3.ShowDialog();
        }
    }
}
