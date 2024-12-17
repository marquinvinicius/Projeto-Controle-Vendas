using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ClienteDAO
    {
        //criando a conexão com o banco de dados
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetMyqlConnection();//instanciando ele
        }

        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular," +
                    @"cep,endereco,numero,complemento,bairro,cidade,estado) " +
                    @"values(@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco," +
                    @"@numero,@complemento,@bairro,@cidade,@estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                MessageBox.Show("Cliente Cadastrado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                throw;
            }

        }
        #endregion


        #region ListarClientes

        public DataTable ListarClientes()
        {
            try
            {
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);//prenchiemnto da tabela

                conexao.Close();
                return tabelaCliente;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion


        #region AlterarCliente

        public void alterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular," +
                    @"cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                    where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);

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
                MessageBox.Show("Cliente Aleterado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                throw;
            }
        }

        #endregion


        #region ExcluirCliente

        public void excluirCliente(Cliente obj)
        {
            try
            {
                //definir o comando sql
                string sql = @"delete from tb_clientes where id = @id";

                //organizar o cmd
                MySqlCommand excutacmd = new MySqlCommand(sql, conexao);

                excutacmd.Parameters.AddWithValue("@id", obj.codigo);

                //abrir conexão
                conexao.Open();
                excutacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Excluido com sucesso");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                throw;
            }
        }
        #endregion


        #region BuscarClientePorNome

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //criar a tabela e o comanda
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes where nome = @nome";

                //pega os dados
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //preencher e a adaptação
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        
        }
        #endregion


        #region ListarClientesPorNome
        public DataTable ListarClientesPorNome(string nome)
        {
            try
            {
                //criar a tabela e o comanda
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                //pega os dados
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //preencher e a adaptação
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        
        }
        #endregion


        #region Retorna Cliente Por Cpf

        public Cliente retornaClientePorCpf(string cpf)
        {
            try
            {
                string sql = @"select * from tb_clientes where cpf = @cpf";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();

                //ele que vai retornar a informação do sql e fazer a conexão
                //recomendado para leitura

                MySqlDataReader rd = executacmd.ExecuteReader();

                if (rd.Read())
                {
                    Cliente obj = new Cliente();
                    obj.codigo = rd.GetInt32("id");
                    obj.nome = rd.GetString("nome");

                    conexao.Close();
                    return obj;
                }
                else 
                {
                    MessageBox.Show("Cliente não encontrado");
                    conexao.Close();
                    return null;
                }
                
            }
            catch ( Exception erro)
            {
                MessageBox.Show("ERRO" + erro);
                return null;
            }
        }
        #endregion
    }
}
