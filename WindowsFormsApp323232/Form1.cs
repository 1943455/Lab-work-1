using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1log_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Successful");
        }

        private void button1radio_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2 ();
            frm.ShowDialog();
        }

        private void button3combo_Click(object sender, EventArgs e)
        { 
            Form4 frm = new Form4 ();
            frm.ShowDialog();

        }

        private void button1random_Click(object sender, EventArgs e)
        {

            Form5 frm = new Form5 ();
            frm.ShowDialog();

        }

        private void button2randcombo_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6 ();
            frm.ShowDialog();

        }

        private void button4array_Click(object sender, EventArgs e)
        {

            Form7 frm = new Form7 ();
            frm.ShowDialog();
        }

        private void button2food_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3 ();
            frm.ShowDialog();
        }
    }
}
