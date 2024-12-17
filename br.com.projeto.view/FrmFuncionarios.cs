using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            //criando o dao

            FuncionarioDao dao = new FuncionarioDao();

            dao.CadastrarFuncionario(obj);
            new Helpers().LimparTela(this);
            tabelaFuncionarios.DataSource = dao.ListarFuncionarios();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDao dao = new FuncionarioDao();
            tabelaFuncionarios.DataSource = dao.ListarFuncionarios();

        }

        private void tabelaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = tabelaFuncionarios.CurrentRow.Cells[16].Value.ToString();

            tabfuncionarios.SelectedTab = tabDadosPessoais;
            
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //criar o objeto
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDao dao = new FuncionarioDao();

            dao.deletarFuncionario(obj);

            tabelaFuncionarios.DataSource = dao.ListarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            obj.codigo = int.Parse(txtcodigo.Text);
            //criando o dao

            FuncionarioDao dao = new FuncionarioDao();

            dao.alterarFuncionario(obj);
            
            tabelaFuncionarios.DataSource = dao.ListarFuncionarios();
            new Helpers().LimparTela(this);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //
            string nome = txtpesquisa.Text;

            FuncionarioDao dao = new FuncionarioDao();

            tabelaFuncionarios.DataSource = dao.BuscarFuncionariosPorNome(nome);
            if (tabelaFuncionarios.Rows.Count == 0|| txtpesquisa.Text == string.Empty)//verifica se o campo está vazio
            {
                MessageBox.Show("Funcionario não encontrado");
                tabelaFuncionarios.DataSource = dao.ListarFuncionarios();
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%"; //excluir um % as vezes por ser bom
            FuncionarioDao dao =new FuncionarioDao();
            tabelaFuncionarios.DataSource = dao.ListarFuncionariosPorNome(nome);
            
        }

        private void btnpesquisarcep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado.\nDigite seu endereço manualmente");
                throw;
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }
    }
}
