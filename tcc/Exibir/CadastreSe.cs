using System;

using System.Windows.Forms;
using tcc.modelo;

namespace tcc.Exibir
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            Controle con = new Controle();
            String mensagem = con.cadastrar(txtLogin.Text, txtSenhaC.Text, txtCSenhaC.Text);
            if (con.tem)
            {
                MessageBox.Show(mensagem, "cadastrado");

            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
