﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp323232
{
    public partial class Form7 : Form
    {
        Int32[] iArray2 = new Int32[5];
        Int32[] iArray3 = new Int32[5] { 21, 22, 23, 24, 25 };

        Int32[] iArray4 = new Int32[] { 11, 12, 13, 14, 15 };

        Int32[] iArray5 = { 31, 32, 33, 34, 35 };
        public Form7()
        {
            InitializeComponent();
        }

        private void buttshow_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                iArray3[i] = 5 * i;
                MessageBox.Show(Convert.ToString(iArray3[i]));
            }
        }

        private void buttforeach_Click(object sender, EventArgs e)
        {
            foreach (int j in iArray3)
            {
                MessageBox.Show(Convert.ToString(j));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
