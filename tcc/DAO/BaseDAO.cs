using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace tcc.DAO
{
    internal class BaseDAO
    {
        public string ConnectionString = "server=localhost;uid=root;pwd='';database=cadastro;";
        public MySqlConnection cn { get; set; }
        public MySqlCommand cmd { get; set; }
        public MySqlDataAdapter adapt { get; set; }
        public string sql { get; set; }
        public MySqlDataReader dr;
        public List<MySqlParameter> parametros { get; set; }

        public BaseDAO()
        {
            if (cn == null)
            {
                cn = new MySqlConnection(ConnectionString);
            }
            cmd = new MySqlCommand();
            adapt = new MySqlDataAdapter();
            parametros = new List<MySqlParameter>();
        }


        #region
        public void execute()
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                foreach (var item in parametros)
                {
                    cmd.Parameters.Add(item);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }
        public void executee()
        {
            try
            {
                
                cmd = new MySqlCommand(sql, cn);
                foreach (var item in parametros)
                {
                    cmd.Parameters.Add(item);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public MySqlDataReader executeReader()
        {
            try
            {
                cmd = new MySqlCommand(sql, cn);
                cn.Open();
                return this.cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                cn.Dispose();
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public MySqlDataReader executeReadeer()
        {
            try
            {
                cmd = new MySqlCommand(sql, cn);
                
                return this.cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                cn.Dispose();
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

    }
}
#endregion