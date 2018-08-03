using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_IOT_JoaoRocha_CircleCalc
{
    ///TODO: Add validation so if a value is bigger than type can show 
    ///a message sayint it so
    public partial class Form1 : Form
    {
        private bool usesDiametro;
        private bool usesArea;
        private bool usesPerimetro;
        private bool usesVolume;
        public Form1()
        {
            InitializeComponent();
        }

        private bool hasTextBoxAValidNumb(string s)
        {
            if (s != null && Int32.TryParse(s, out int n))
                return true;
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int intResult;

            if (hasTextBoxAValidNumb(textBox1.Text))
            {
                intResult = Int32.Parse(textBox1.Text);

                if (usesDiametro)
                    lblDiametroVal.Text = DiametroCalc(intResult).ToString();
                if(usesArea)
                    lblAreaVal.Text = AreaCalc(intResult).ToString();
                if(usesPerimetro)
                    lblPerimetroVal.Text = PerimetroCalc(intResult).ToString();
                if(usesVolume)
                    lblVolumeVal.Text = VolumeCalc(intResult).ToString();
            }
          
        }


        #region CheckBoxs
        private void checkBoxDiametro_CheckedChanged(object sender, EventArgs e)
        {
            usesDiametro = checkBoxDiametro.Checked; 
        }

        private void checkBoxArea_CheckedChanged(object sender, EventArgs e)
        {
            usesArea = checkBoxArea.Checked;
        }


        private void checkBoxPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            usesPerimetro = checkBoxPerimetro.Checked;
        }

        private void checkBoxVolume_CheckedChanged(object sender, EventArgs e)
        {
            usesVolume = checkBoxVolume.Checked;
        }
        #endregion

        [System.Obsolete]
        private void label1_Click(object sender, EventArgs e)
        {

        }

        [System.Obsolete]
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        #region Circular Geometry Values Calc

        private double DiametroCalc(int raio)
        {
            return  2 * raio; 
        }

        private double AreaCalc(int raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        private double PerimetroCalc(int raio)
        {
            return 2 * Math.PI * raio;
        }

        private double VolumeCalc(int raio)
        {
            return (4 / 3) * (Math.PI * Math.Pow(raio, 3));
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            int intResult;

            if (hasTextBoxAValidNumb(textBox1.Text))
            {
                intResult = Int32.Parse(textBox1.Text);

                if (usesDiametro)
                    lblDiametroVal.Text = DiametroCalc(intResult).ToString();
                if (usesArea)
                    lblAreaVal.Text = AreaCalc(intResult).ToString();
                if (usesPerimetro)
                    lblPerimetroVal.Text = PerimetroCalc(intResult).ToString();
                if (usesVolume)
                    lblVolumeVal.Text = VolumeCalc(intResult).ToString();
            }
        }
    }
}
