
using System;
using System.Windows.Forms;


namespace tcc.Exibir
{
    public partial class menuadm : Form
    {


        public menuadm()
        {
            InitializeComponent();
            txtExibirSaldo.ReadOnly = true;
            exebe();
            

        }
        

        private BE.TransaçãoFisicaBE be { get; set; }
        private VO.Fisica f { get; set; }


        private void button3_Click(object sender, EventArgs e)
        {

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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Saida saida = new Saida();
            saida.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CadastreSe cadastre = new CadastreSe();
            cadastre.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}