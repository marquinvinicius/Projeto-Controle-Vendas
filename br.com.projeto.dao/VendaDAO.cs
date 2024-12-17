using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class VendaDAO
    {

        private MySqlConnection conexao;

        public VendaDAO ()
        {
            this.conexao = new ConnectionFactory().GetMyqlConnection();
        }

        #region CadastrarVenda

        public void cadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                                values (@cliente_id, @data_venda, @total_venda, @obs)";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                conexao.Open();
                executacmd.ExecuteNonQuery();
             
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu erro na venda" + erro);
            }
        }
        #endregion


        #region Retorna id DA ULTIMA VENDA
        public int retornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;
                string sql = @"select max(id) id from tb_vendas";
                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                conexao.Open();

                MySqlDataReader rd = executacmd.ExecuteReader();

                if (rd.Read())
                {
                    idvenda = rd.GetInt32("id");                                     
                }
                conexao.Close();
                return idvenda;

            }
            catch (Exception erro)
            {
                conexao.Close();
                MessageBox.Show("Erro " + erro);
                return 0;
            }
        }
        #endregion


        #region Exibir histórico de Vendas Mostrando bem o uso do join
        public DataTable listarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"select vd.id as 'Código',
                                vd.data_venda as 'Data da Venda',
                                cl.nome as 'Cliente',
                                vd.total_venda as 'Total',
                                vd.observacoes as 'Obs'
                                from tb_vendas as vd 
                                join tb_clientes as cl on (vd.cliente_id = cl.id)
                                where vd.data_venda between @datainicio and @datafim";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@datainicio", datainicio);
                executacmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                //criãção do dataadapter e preencher o datable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);
                conexao.Close();
                return tabelaHistorico;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na listagem" + erro);
                return null;
            }
        }
        #endregion

        #region ListarTodasasVendas

        public DataTable ListarVendas()
        {
            try
            {
                DataTable tabelahistorico = new DataTable();
                string sql = @"select v.id as 'Código', v.data_venda as 'Data da Venda', 
                                c.nome as 'Cliente', v.total_venda as 'Total', v.observacoes as 'Obs' from tb_vendas as v
                        join tb_clientes as c on (v.cliente_id = c.id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                da.Fill(tabelahistorico);
                conexao.Close();
                return tabelahistorico;
        
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao listar" + erro);              
                conexao.Close();
                return null;
            }
        }
        #endregion

    }
}
