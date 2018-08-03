using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_IOT_JoaoRocha_GradesCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   internal class Pesos
    {
        const short peso1 = 65;
        const short peso2 = 15;
        const short peso3 = 20;

        public static short Peso1 => peso1;
    }
}
