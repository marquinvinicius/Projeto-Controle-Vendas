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
    public class ProdutoDAO
    {
        MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetMyqlConnection();
        }

        #region CadastrarProduto
        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id)
                               values (@descricao, @preco, @qtd_estoque, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com sucesso");
                conexao.Close();

            }
            catch ( Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                throw;
            }
        }

        #endregion


        #region ListarProduto

        public DataTable ListarProduto()
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select pr.id as 'Código', pr.descricao as 'Descrição', 
                                pr.preco as 'Preço', pr.qtd_estoque as 'Qtd_Estoque',
                                fr.nome as 'Fornecedor'
                                from tb_produtos as pr
                                join tb_fornecedores as fr on (pr.for_id = fr.id);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                conexao.Close() ;

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
                throw;
            }
        }
        #endregion


        #region AlterarProduto

        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, 
                                qtd_estoque=@qtd_estoque, for_id=@for_id where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                throw;
            }
        }

        #endregion


        #region ExcluirProduto

        public void excluirProduto(Produto obj)
        {
            try
            {
                string sql = @"delete from tb_produtos where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                throw;
            }
        }
        #endregion


        #region ListarPorNome
        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select pr.id as 'Código', pr.descricao as 'Descrição', 
                                pr.preco as 'Preço', pr.qtd_estoque as 'Qtd_Estoque',
                                fr.nome as 'Fornecedor'
                                from tb_produtos as pr
                                join tb_fornecedores as fr on (pr.for_id = fr.id)
                                where pr.descricao like @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                conexao.Close();

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
                throw;
            }
        }

        #endregion


        #region BuscarPorNome

        public DataTable BuscarProdutoPorNome()
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select pr.id as 'Código', pr.descricao as 'Descrição', 
                                pr.preco as 'Preço', pr.qtd_estoque as 'Qtd_Estoque',
                                fr.nome as 'Fornecedor'
                                from tb_produtos as pr
                                join tb_fornecedores as fr on (pr.for_id = fr.id)
                                where pr.descricao = @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                conexao.Close();

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
                throw;
            }
        }

        #endregion


        #region Retorna produto por codigo

        public Produto RetornaProdutoPorCodigo(int id)
        {
            try
            {

                string sql = @"select * from tb_produtos where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                
                MySqlDataReader rd = executacmd.ExecuteReader();

                if (rd.Read())
                {
                    Produto p = new Produto();
                    p.id = rd.GetInt32("id");
                    p.descricao = rd.GetString("descricao");
                    p.preco = rd.GetDecimal("preco");
                    conexao.Close();
                    return p;
                }
                else 
                {
                    MessageBox.Show("Não há produto com esse id");
                    conexao.Close();
                    return null;
                }
            }
            catch ( Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                return null;
                throw;
            }
        }

        #endregion


        #region Baixa estoque
        public void BaixarEstoque(int id, int qtd_estoque)
        {
            try
            {

                string sql = @"update tb_produtos set qtd_estoque= @qtd where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@qtd", qtd_estoque);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro no baixa estoque" + erro);
                conexao.Close() ;
            }
        }
        #endregion


        #region Estoque Atual

        public int RetornaEstoqueAtual(int idproduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where id = @id";
                int qtd_estoque = 0;
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();

                MySqlDataReader rd = executacmd.ExecuteReader();

                if (rd.Read())
                {
                    qtd_estoque = rd.GetInt32("qtd_estoque");
                    conexao.Close();
                }
                return qtd_estoque;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Errou" + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion
    }
}
