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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1Show_Click(object sender, EventArgs e)
        {
            String msg = "";

            if (checkCoffee.Checked == true)
            {
                msg = checkCoffee.Text;
            }

            if (checkDount.Checked == true)
            {
                msg = msg + " " + checkDount.Text; ;
            }


            if (checkBrownie.Checked == true)
            {
                msg = msg + " " + checkBrownie.Text; ;
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected");
            }
            else
                MessageBox.Show("Nothing selected");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
