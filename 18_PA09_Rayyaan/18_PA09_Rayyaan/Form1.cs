using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_PA09_Rayyaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Yen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            const decimal us = 0.74M, yen = 81.97M;

            try
            {

                decimal Amount = Convert.ToDecimal(txt_Amount.Text);
                if (rb_US.Checked)
                {
                    decimal answer = Amount * us;
                    txt_converted.Text = answer.ToString();
                }
                if (rb_Yen.Checked)
                {
                    decimal answer = Amount * yen;
                    txt_converted.Text = answer.ToString();
                }
                
                else
                {
                    txt_Amount.Text = "Choose one of the currencies";
                }

            }
            catch (FormatException)
            {
                txt_Amount.Text = "Please enter a valid amount";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_converted.Clear();
            txt_Amount.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
        }
    }
}
