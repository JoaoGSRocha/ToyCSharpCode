using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_IOT_JoaoRocha_DynamicValForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            lbl01Val.Text = textBox1.Text.Trim();
            lbl02Val.Text = textBox1.Text.Length.ToString();
            lbl03Val.Text = textBox1.Text.ToUpper();
            lbl04Val.Text = textBox1.Text.ToLower();
            if(int.TryParse(textBox1.Text.ToString(), out int n)) {
                lbl05Val.Text = textBox1.Text.ToString() + " €";
                lbl06Val.Text = (float.Parse(textBox1.Text) / 100).ToString() + " %";
                lbl08Val.Text = (float.Parse(textBox1.Text) / 100).ToString();
            }
            lbl07Val.Text = textBox1.Text;
     
            lbl09Val.Text = textBox1.Text.ToString().Trim().ToUpper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lbl02Val.Text = textBox2.Text.Length.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lbl03Val.Text = textBox3.Text.ToUpper();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lbl04Val.Text = textBox4.Text.ToLower();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text.ToString(), out int n))
                lbl05Val.Text = textBox5.Text.ToString() + " €";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text.ToString(), out int n))
            lbl06Val.Text = (float.Parse(textBox6.Text)/100).ToString() + " %";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            lbl07Val.Text = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox8.Text.ToString(), out int n))
            lbl08Val.Text = (float.Parse(textBox8.Text) / 100).ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            lbl09Val.Text = textBox9.Text.ToString().Trim().ToUpper();
        }

        private void lbl06Val_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            lbl01Val.Text = "...";
            lbl03Val.Text = "..ABC";
            lbl04Val.Text = "...abc";
            lbl05Val.Text = "0 €";
            lbl06Val.Text = "0";
            lbl07Val.Text = "0";
            lbl08Val.Text = "0";
            lbl09Val.Text = "...";
        }
    }
}
