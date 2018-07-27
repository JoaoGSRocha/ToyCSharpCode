using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_IOT_JoaoRocha_FormWithBttns
{
    public partial class frmUtilizadores : Form
    {
        public frmUtilizadores()
        {
            InitializeComponent();
        }


        private void btnNome_Click(object sender, EventArgs e)
        {
            //Create the WebBrowser control
            WebBrowser wb = new WebBrowser();
            //Add a new event to process document when download is completed   
            MessageBox.Show("Nome: " + ValidateName(txtNome.Text) + ".");
        }

        private void lblSobrenome_Click(object sender, EventArgs e)
        {
        }

        private void btnSobrenome_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Utilizador:\n" + ValidateName(txtNome.Text) + "\n" +
                ValidateName(TxtSobrenome.Text) + ".");
        }

        private void frmUtilizadores_Load(object sender, EventArgs e)
        {
        }


        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        public string GetTxtNomeVal()
        {
            return txtNome.Text;
        }

        public void SetTxtNomeVal(string txtNome)
        {
            TxtNome.Text = txtNome;
        }

        public bool Is1stNameEmpty()
        {
            if (TxtNome.Text == "")
                return true;
            return false;
        }

        /// <summary>
        /// Validates if name is not null, has numerical, punctuation or 
        /// symbol chars.
        /// If so is true, prompts a message according the values mistakenly
        /// provided
        /// </summary>
        /// <returns></returns>
        public string ValidateName(string str)
        {
            if(Is1stNameEmpty())
                return "O campo está em vazio, por favor insira o seu nome";

            foreach (char c in str.ToArray())
            {
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))  
                    return "Digitou um(ns) valor(es) inválidos, foi pedido apenas um nome";
            }
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
