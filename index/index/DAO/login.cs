using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace index.DAO 
{
    class login
    {
  
        public String loginUser(string user, string pass)
        {
            string retorno = "";
            string user1 = "";
            string password = "";

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.ConexaoString;

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SELECT user_login, user_pass from TB_USER WHERE user_login= '" + user +
                   "' AND user_pass='" + pass +"'";
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                try
                {
                    SqlDataReader DR;
                    DR = comando.ExecuteReader();
                    DR.Read();
                    user1 = Convert.ToString(DR.GetSqlString(0));
                    password = Convert.ToString(DR.GetSqlString(1));
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    retorno = Convert.ToString(ex);
                    conexao.Close();
                }
            }
            catch (Exception)
            {
                conexao.Close();
            }

            if (user == user1 && pass == password)
            {

                retorno = user1;
                return retorno;
            }
            else
            {
                retorno = "";
                return retorno;
            }


           
        }
    }
}
