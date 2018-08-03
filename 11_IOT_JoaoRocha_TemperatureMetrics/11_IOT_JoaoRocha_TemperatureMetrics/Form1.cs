using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_IOT_JoaoRocha_TemperatureMetrics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Int32.TryParse(textBox1.Text, out int a))
                lblConvertedVal.Text = ((Double.Parse(textBox1.Text)-32) / 1.8).ToString();
        }
    }
}
