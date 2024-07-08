using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using tcc.VO;


namespace tcc.DAO
{
    internal class TransaçõesDAO : BaseDAO
    {

        public List<Fisica> listaTransações;

        public Fisica transações { get; set; }

        public bool tem = false;
        public String mensagem = "";

        public bool verificarLogin(String login, String senha)
        {
            this.sql = "SELECT * FROM cadastrouser" /*where login=@login and  senha=@senha " */;
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@login", login));
            parametros.Add(new MySqlParameter("@senha", senha));
            using (var dr = executeReader())
            {
                if (dr.Read())
                {
                    tem = true;
                }

            }

            return tem;
        }
        public String cadastrar(String login, String senha, String confSenha)
        {
            if (senha.Equals(confSenha))
            {
                this.sql = " insert into cadastrouser(login,senha) values (@login,@senha);";
                cmd.CommandText = this.sql;
                parametros.Add(new MySqlParameter("@login", login));
                parametros.Add(new MySqlParameter("@senha", senha));
                this.mensagem = "Cadastrado com sucesso";
                execute();


            }
            else
            {
                this.mensagem = "erro";
            }

            return mensagem;

        }


        public void exibirsaldo()
        {
            this.sql = "SELECT * FROM extrato ";

            using (var dr = executeReader())
            {
                while (dr.Read())
                {

                    transações.saldo = Convert.ToDouble(dr["saldo"]);


                }
            }
        }

        public void exibirsaldoo()
        {
            this.sql = "SELECT * FROM extrato ";

            using (var dr = executeReadeer())
            {
                while (dr.Read())
                {

                    transações.saldo = Convert.ToDouble(dr["saldo"]);


                }
            }
        }


        public void inserir()
        {
            this.sql = "insert into extrato(descricao,saldo) values (@descricao,@saldo);";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@descricao", transações.descrição));
            parametros.Add(new MySqlParameter("@saldo", transações.saldo));
            executee();
            

        }

    }
}





