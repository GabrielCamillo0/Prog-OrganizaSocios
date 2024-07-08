using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using tcc.VO;



namespace tcc.Exibir
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            Dgv();
            txtLogin.Select();
        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=cadastro;");

        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        private DataGridView dgv = new DataGridView();

        public Fisica f { get; set; }



        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {


            string query = "SELECT * FROM cadastrouser WHERE login ='" + txtLogin.Text + "' AND senha= '" + txtSenha.Text + "'";
            MySqlDataAdapter dp = new MySqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menuadm adm = new menuadm();
                this.Hide();
                adm.Show();
            }
            else
            {
                MessageBox.Show("Login não encontrado", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void exibibi()
        {
            try
            {
                strSql = "SELECT * FROM clientes WHERE saldo =@saldo";
                conexao.Open();
                cmd = new MySqlCommand(strSql, conexao);
                cmd.Parameters.AddWithValue("@saldo", f.saldo);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    f.saldo = Convert.ToDouble(dr["saldo"]);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);

            }


        }
        //dgv
        private void Dgv()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=cadastro;");
                strSql = "SELECT * FROM cadastrouser";
                da = new MySqlDataAdapter(strSql, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);

            }
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
