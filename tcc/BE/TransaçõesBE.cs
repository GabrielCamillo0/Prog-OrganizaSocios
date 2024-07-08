
using tcc.DAO;
using tcc.VO;



namespace tcc.BE
{
    public class TransaçãoFisicaBE
    {
        public Fisica transações { get; set; }
        private TransaçõesDAO dao { get; set; }
        public TransaçãoFisicaBE()
        {
            dao = new TransaçõesDAO();
        }

        public void inserir()
        {
            dao.transações = transações;
            dao.inserir();
        }
        public void exibirsaldo()
        {
            dao.transações = transações;
            dao.exibirsaldo();

        }

        public void exibirsaldoo()
        {
            dao.transações = transações;
            dao.exibirsaldoo();

        }

    }
}
