using System;

using System.Windows.Forms;

namespace tcc.Exibir
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
            txtExibirSaldo.ReadOnly = true;
            txtNSaldo.ReadOnly = true;
            exebe();
            limparTela();
        }
        private BE.TransaçãoFisicaBE be { get; set; }
        private VO.Fisica f { get; set; }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            be.exibirsaldoo();
            f.descrição = txtDescrição.Text;
            f.entrada = Convert.ToDouble(txtEntrada.Text);
            f.saldo = f.saldo + f.entrada;
            txtNSaldo.Text = f.saldo.ToString();
            be.inserir();
            limparTela();
            MessageBox.Show("Atualização registrada com sucesso");
            exebe();

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
            txtEntrada.Text = "";

        }

       

        private void txtExibirSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
