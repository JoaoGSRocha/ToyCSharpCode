using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_IOT_JoaoRocha_RandNumbGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int randResult = GenerateRandNumb();
            lblPoints.Text = randResult.ToString();

            lblPoints.ForeColor = (IsNumbPair(randResult))
             ? System.Drawing.Color.Red : System.Drawing.Color.Black;
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {
            
        }

        private int GenerateRandNumb()
        {
            Random random = new Random();
            return  random.Next(0, 200);
        }

        private bool IsNumbPair(int n)
        {
            return (n % 2 == 0) ? true : false;
        }
    }
}
