using System;
using System.Windows.Forms;

namespace tcc.Exibir
{
    public partial class Saida : Form
    {
        public Saida()
        {
            InitializeComponent();
            txtExibirSaldo.ReadOnly = true;
            txtNSaldo.ReadOnly = true;
            exebe();
            limparTela();
        }
        private BE.TransaçãoFisicaBE be { get; set; }
        private VO.Fisica f { get; set; }


        private void button2_Click(object sender, EventArgs e)
        {
            be.exibirsaldoo();
            f.descrição = txtDescrição.Text;
            f.saida = Convert.ToDouble(txtSaida.Text);
            f.saldo = f.saldo - f.saida;
            txtNSaldo.Text = f.saldo.ToString();
            txtExibirSaldo.Text = f.saldo.ToString();
            be.inserir();
            limparTela();
            MessageBox.Show("Atualização registrada com sucesso");
           

        }
        public void exebe()
        {
            f = new VO.Fisica();
            be = new BE.TransaçãoFisicaBE();
            be.transações = f;
            be.exibirsaldo();
            txtExibirSaldo.Text = f.saldo.ToString();
        }
        private void limparTela()
        {
            txtDescrição.Text = "";
            txtSaida.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

  

        private void txtDescrição_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
