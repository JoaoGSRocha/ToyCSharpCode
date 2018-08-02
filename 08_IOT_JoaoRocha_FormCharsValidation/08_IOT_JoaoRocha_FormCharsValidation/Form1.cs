using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _08_IOT_JoaoRocha_FormCharsValidation
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = HasText3ValidChars(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = HasText3ValidChars(textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Enabled = HasText3ValidChars(textBox3);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Determines whether TextBox.Text has 3 characterss, not including 
        /// the whitespace
        /// </summary>
        /// <param name="textbox"></param>
        /// <returns></returns>
        private bool HasText3ValidChars(TextBox textbox)
        {
            string tmpText = Regex.Replace(textbox.Text, @"\s+", "");
            if (tmpText.Length >= 3)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determines whether TextBox.Text has 3 characterss, not including 
        /// the whitespace
        /// </summary>
        /// <param name="textbox"></param>
        /// <returns></returns>
        private bool HasText3ValidChars(RichTextBox textbox)
        {
            string tmpText = Regex.Replace(textbox.Text, @"\s+", "");
            if (tmpText.Length >= 3)
                return true;
            else
                return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
