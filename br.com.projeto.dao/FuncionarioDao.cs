using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using Projeto_Controle_Vendas.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class FuncionarioDao
    {
        private MySqlConnection conexao;

        public FuncionarioDao()
        {
            this.conexao = new ConnectionFactory().GetMyqlConnection();

        }

        #region CadastrarFuncionario
        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //comando sql
                string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso," +
                             @"telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)" +
                             @"values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone," +
                             @"@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // executar o comando

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //organizar o comando

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);

                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);

                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);

                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //abrir conexão
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com Sucesso!!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
                throw;
            }
        }


        #endregion


        #region AlterarFuncionario
        
        public void alterarFuncionario(Funcionario obj)

        {
            try
            {
                //comando sql
                string sql = "update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@celular," +
                             "cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado " +
                             "where id=@codigo";
                // executar o comando

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //organizar o comando

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email); 

                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);

                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);

                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                //abrir conexão
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com Sucesso!!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
                throw;
            }
        }

        #endregion


        #region ExcluirFuncionario

        public void deletarFuncionario(Funcionario obj)

        {
            try
            {
                //comando sql
                string sql = "delete from tb_funcionarios where id = @codigo";
                // executar o comando

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                //abrir conexão
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com Sucesso!!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
                throw;
            }
        }
        #endregion


        #region ListarFuncionarios
        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable tabelaFuncoinario = new DataTable();
                string sql = "select * from tb_funcionarios";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncoinario);//prenchiemnto da tabela

                conexao.Close();
                return tabelaFuncoinario;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion


        #region ListarFuncionarioPorNome
        public DataTable BuscarFuncionariosPorNome( string nome)
        {
            try
            {
                DataTable tabelaFuncoinario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncoinario);//prenchiemnto da tabela

                conexao.Close();
                return tabelaFuncoinario;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion


        #region ListarFuncionarioPorNome
        public DataTable ListarFuncionariosPorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncoinario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                //pega os dados e cria a tabela clientes
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncoinario);//prenchiemnto da tabela

                conexao.Close();
                return tabelaFuncoinario;


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando sql {erro}");
                return null;
                throw;
            }
        }
        #endregion

        #region Efetuar Login

        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios where email = @email and senha = @senha";

                // executar o comando

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //organizar o comando

                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader rd = executacmd.ExecuteReader();
                

                //definindo niveis de acesso
                
                

                

                if (rd.Read())
                {
                    string nivel = rd.GetString("nivel_acesso");
                    string nome = rd.GetString("nome");

                    FrmMenu menu = new FrmMenu();
                    menu.txtUsuario.Text = nome;


                    if (nivel.Equals("Administrador"))
                    {
                        MessageBox.Show($"Bem vindo {nivel} {nome}");
                        
                        menu.Show();
                    }
                    else if(nivel.Equals("Usuário"))
                    {
                        menu.MenuProdutos.Visible = false;
                        menu.Show();
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Email ou senha errados");
                    return false;
                } 
                
            }
            catch ( Exception erro)
            {

                MessageBox.Show("Deu erro no login" + erro);
                return false;
            }
        }
        #endregion
    }
}
