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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //carregar o cb dos fornecedores
            FornecedorDAO f_dao = new FornecedorDAO();
            
            cbfornecedor.DataSource = f_dao.ListarFornecedor();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.ListarProduto();

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.estoque = int.Parse(txtestoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();

            dao.cadastrarProduto(obj);
            new Helpers().LimparTela(this);
            tabelaProdutos.DataSource = dao.ListarProduto();

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtestoque.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();

            cbfornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabCadProduto;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.estoque = int.Parse(txtestoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();

            dao.alterarProduto(obj);

            new Helpers().LimparTela(this);

            tabelaProdutos.DataSource = dao.ListarProduto();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();

            dao.excluirProduto(obj);

            new Helpers().LimparTela(this);

            tabelaProdutos.DataSource = dao.ListarProduto();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.ListarProdutoPorNome(nome);
        }

        private void btnpesquisarFornecedor_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.ListarProdutoPorNome(nome);

            if (tabelaProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado");
                tabelaProdutos.DataSource = dao.ListarProduto();
            }
        }
    }
}
