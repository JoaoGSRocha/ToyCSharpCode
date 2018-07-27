using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_IOT_JoaoRocha_FormWithUsersName
{
    public partial class frmUtilizador : Form
    {
        public frmUtilizador()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Janela com Título", "Olá");
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "O nome do utilizador aparece no título da janela", 
                txtNome.Text);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
