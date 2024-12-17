using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        //metodo de conexão
        public MySqlConnection GetMyqlConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
