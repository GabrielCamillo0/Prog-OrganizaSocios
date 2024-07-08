using System;

using tcc.DAO;

namespace tcc.modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";


        public String cadastrar(String email, String senha, String confSenha)
        {
            TransaçõesDAO trans = new TransaçõesDAO();
            this.mensagem = trans.cadastrar(email, senha, confSenha);



            return mensagem;
        }



    }
}
