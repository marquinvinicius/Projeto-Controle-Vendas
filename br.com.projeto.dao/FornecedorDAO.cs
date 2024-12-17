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
    public class FornecedorDAO
    {
        //criando a conexão com o banco de dados
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetMyqlConnection();//instanciando ele
        }

        #region CadastrarFuncionario
        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular," +
                    @"cep,endereco,numero,complemento,bairro,cidade,estado) " +
                    @"values(@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco," +
                    @"@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);

                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);

                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                throw;
            }

        }

        #endregion


        #region ListarFornecedor
        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable tabelaFornecedores = new DataTable();
                string sql = "select * from tb_fornecedores";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedores);//prenchiemnto da tabela

                conexao.Close();
                return tabelaFornecedores;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion


        #region AlterarFornecedor

        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular," +
                    @"cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                    where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);

                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);

                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Aleterado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                throw;
            }
        }
        #endregion


        #region ExcluirFornecedor
        public void excluirFornecedor(Cliente obj)
        {
            try
            {
                //definir o comando sql
                string sql = @"delete from tb_fornecedores where id = @id";

                //organizar o cmd
                MySqlCommand excutacmd = new MySqlCommand(sql, conexao);

                excutacmd.Parameters.AddWithValue("@id", obj.codigo);

                //abrir conexão
                conexao.Open();
                excutacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Excluido com sucesso");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                throw;
            }
        }
        #endregion


        #region ListarFornecedorPorNome
        public DataTable ListarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedores = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedores);//prenchiemnto da tabela

                conexao.Close();
                return tabelaFornecedores;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion


        #region BuscarFornecedorPorNome
        public DataTable BuscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedores = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedores);//prenchiemnto da tabela

                conexao.Close();
                return tabelaFornecedores;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion
    }
}
