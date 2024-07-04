using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace OrganizaSocios
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "PEDRO")
            {
                if (textBox2.Text == "12345")
                {
                    using (Form2 form2 = new Form2())
                    {
                        form2.ShowDialog();
                        base.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e Senha Inválidos!!!");
                }
            }
            else
            {
                MessageBox.Show("Inserir Corretamente o Login e Senha!!!");
            }
        }
    }
}
