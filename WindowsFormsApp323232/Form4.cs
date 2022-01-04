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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox11.Items.Add("Sunday");

            comboBox11.Items.Add("Monday");

            comboBox11.Items.Add("Tuesday");

            comboBox11.Items.Add("Wednesday");

            comboBox11.Items.Add("Thursday");

            comboBox11.Items.Add("Friday");

            comboBox11.Items.Add("Saturday");

            comboBox11.Items.Add("Funday");

            comboBox11.Items.Add("Examday");
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttoshose_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox11.Text);
        }

        private void buttoreby_Click(object sender, EventArgs e)
        {
            comboBox11.Items.Remove("Friday");
        }

        private void buttorebynmbr_Click(object sender, EventArgs e)
        {
            comboBox11.Items.RemoveAt(1);

        }

        private void buttorelast_Click(object sender, EventArgs e)
        {
            comboBox11.Items.RemoveAt(comboBox11.Items.Count - 1);
            if (comboBox11.Items.Count >= 1)

            {

                comboBox11.Items.RemoveAt(comboBox11.Items.Count - 1);

            }

            else

            {

                MessageBox.Show("Can't remove last item");
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}


