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
    public partial class Form5 : Form
    {
        Random y = new Random();
        public Form5()
        {
            InitializeComponent();
        }

        private void buttogerc_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            buttogerc.BackColor = Color.FromArgb(r, g, b);
            label1rgb.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
        }

        private void buttorannum_Click(object sender, EventArgs e)
        {
            buttorannum.Text = Convert.ToString(y.Next(1, 100));

        }

        private void buttoBack12_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
