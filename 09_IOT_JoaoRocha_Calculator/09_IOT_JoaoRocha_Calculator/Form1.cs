using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_IOT_JoaoRocha_Calculator
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultVal.Text = Sum(textBox1.Text, textBox2.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Um dos seus campos está sem valor.\nPreencha ambos os campos com um valor númerico");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try { 
                lblResultVal.Text = Minus(textBox1.Text, textBox2.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Um dos seus campos está sem valor. \nPreencha ambos os campos com um valor númerico");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultVal.Text = Multiply(textBox1.Text, textBox2.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Um dos seus campos está sem valor.\nPreencha ambos os campos com um valor númerico");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try { 
                lblResultVal.Text = Divide(textBox1.Text, textBox2.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Um dos seus campos está sem valor.\nPreencha ambos os campos com um valor númerico");
            }
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultVal.Text = Remainder(textBox1.Text, textBox2.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Um dos seus campos está sem valor.\nPreencha ambos os campos com um valor númerico");
            }
         
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultVal.Text = Root(textBox1.Text, textBox2.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Um dos seus campos está sem valor. \n Preencha ambos os campos com um valor númerico");
            }

        }

        #region CalcFuncs

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        private int Sum(string s1, string s2)
        {
            if(s1 == null || s2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "original");
            return Int32.Parse(s1) + Int32.Parse(s2);
        }

        private int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        private int Minus(string s1, string s2)
        {

            if (s1 == null || s2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "original"); ;
            return Int32.Parse(s1) - Int32.Parse(s2);
        }


        private int Minus(int n1, int n2)
        {
            return n1 - n2;
        }

        private double Multiply(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "original");
            return Int32.Parse(s1) * Int32.Parse(s2);
        }

        private double Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        private int Divide(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "original");
            return Int32.Parse(s1) / Int32.Parse(s2);
        }

        private int Divide(int n1, int n2)
        {
            return n1 / n2;
        }

        private float Remainder(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "original");
            return Int32.Parse(s1) % Int32.Parse(s2);
        }

        private float Remainder(int n1, int n2)
        {
            return n1 % n2;
        }

        private double Root(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "original");
            return Math.Pow(Double.Parse(s1), Double.Parse(s2));
        }

        private double Root(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        #endregion

    }

    internal interface ArithCalcs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        int Sum(int n1, int n2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        int Sum(string s1, string s2);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        int Minus(string s1, string s2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        int Minus(int n1, int n2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        double Multiply(string s1, string s2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        double Multiply(int n1, int n2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        int Divide(string s1, string s2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        int Divide(int n1, int n2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        float Remainder(string s1, string s2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        float Remainder(int n1, int n2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        double Root(string s1, string s2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        double Root(double n1, double n2);


    }
}
