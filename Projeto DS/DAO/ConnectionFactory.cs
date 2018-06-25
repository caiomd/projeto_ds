using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS.DAO
{
   public class ConnectionFactory
    {
       public static MySqlConnection getConnection()
       {
           //acessando a string de conexão
           string conexao = ConfigurationManager.ConnectionStrings["BancoDS"].ConnectionString;

           return new MySqlConnection(conexao);


       }


    }
}
