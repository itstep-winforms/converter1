using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                temp1.ReadOnly = false;
                temp1.Focus();
                temp2.ReadOnly = true;
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked == true)
            {
                temp2.ReadOnly = false;
                temp2.Focus();
                temp1.ReadOnly = true;
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio1.Checked)
                {
                    double f = double.Parse(temp1.Text);
                    double c = (f - 32) * 5 / 9;
                    temp2.Text = c.ToString("F");
                }
                else
                {
                    double c = double.Parse(temp2.Text);
                    double f = 32 + c * 1.8;
                    temp1.Text = f.ToString("F");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка выполнения:\n{err.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {

        }
    }
}
