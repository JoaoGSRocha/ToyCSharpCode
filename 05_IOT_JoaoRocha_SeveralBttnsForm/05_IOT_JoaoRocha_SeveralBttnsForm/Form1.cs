using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_IOT_JoaoRocha_SeveralBttnsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste - criação de botões.", "Mensagem");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnBotao2_Click(object sender, EventArgs e)
        {
            btnBotao2.Visible = false;
        }
        
        private void btnBotao3_Click(object sender, EventArgs e)
        {
            btnBotao2.Visible = true;
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja sair da Aplicação?",
                "Fechar a Aplicação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (IsRespostaOK(resposta))
                Application.Exit();
        }

        public bool IsRespostaOK(DialogResult resposta)
        {
            if (resposta.Equals(DialogResult.OK))
                return true;
            else
                return false;
        }
    }
}