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
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetMyqlConnection();
        }

        #region Cadastar um item de venda

        public void cadastrarItem(ItemVenda obj)
        {
            try
            {

                string sql = @"insert into tb_itensvendas(venda_id, produto_id, qtd, subtotal)
                                values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro no cadastro de itens" + erro);
            }
        }

        #endregion

        #region ListarItensPorVenda

        public DataTable ListarItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();
                string sql = @"select it.id as'Código', 
                                pr.descricao as 'Descrição',
                                it.qtd as 'Quantidade',
                                pr.preco as 'Preço',
                                it.subtotal as 'SubTotal'
                                from tb_itensvendas as it
                                join tb_produtos as pr on (it.produto_id = pr.id)
                                where venda_id = @venda_id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", venda_id);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                //criãção do dataadapter e preencher o datable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaItens);
                conexao.Close();
                return tabelaItens;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na listagem" + erro);
                return null;
            }
        }
        #endregion
    }
}
