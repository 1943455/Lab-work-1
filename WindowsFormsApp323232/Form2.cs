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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radiobRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobRed.Checked == true)
                radiobRed.ForeColor = Color.FromName("red");
            else
                radiobRed.ForeColor = Color.FromName("black");
        }

        private void radiobGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobGreen.Checked == true)
                radiobGreen.ForeColor = Color.FromName("green");
            else
                radiobGreen.ForeColor = Color.FromName("black");
        }

        private void radiobBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobBlue.Checked == true)
                radiobBlue.ForeColor = Color.FromName("blue");
            else
                radiobBlue.ForeColor = Color.FromName("black");
        }

        private void radiobYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobYellow.Checked == true)
                radiobYellow.ForeColor = Color.FromName("yellow");
            else
                radiobYellow.ForeColor = Color.FromName("black");
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonRed.ForeColor = Color.FromName("red");
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGreen.ForeColor = Color.FromName("green");
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonBlue.ForeColor = Color.FromName("blue");

        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonYellow.ForeColor = Color.FromName("yellow");

        }

        private void button1Rest_Click(object sender, EventArgs e)
        {
            radiobRed.Checked = false;
            radiobGreen.Checked = false;
            radiobBlue.Checked = false;
            radiobYellow.Checked = false;

            radiobRed.ForeColor = Color.FromName("black");
            radiobGreen.ForeColor = Color.FromName("black");
            radiobBlue.ForeColor = Color.FromName("black");
            radiobYellow.ForeColor = Color.FromName("black");
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
