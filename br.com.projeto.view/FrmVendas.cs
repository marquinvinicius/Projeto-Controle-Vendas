using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmVendas : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO cDAO = new ClienteDAO();

        Produto pr = new Produto();
        ProdutoDAO prDAO = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, total;

        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == 13)
            {
                cliente = cDAO.retornaClientePorCpf(txtcpf.Text);
            if (cliente != null)
            {
                txtnome.Text = cliente.nome;
            }
            else
            {
                txtcpf.Clear();
                txtcpf.Focus();

            }
            }
        }


        private void FrmVendas_Load(object sender, EventArgs e)
        {
            txtDataCompra.Text = DateTime.Now.ToShortDateString();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtqtd.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);
                txtTotal.Text = total.ToString();
                txtcodigo.Clear();
                txtdesc.Clear();
                txtqtd.Clear();
                txtPreco.Clear();

                txtcodigo.Focus();
            }
            catch (Exception  erro)
            {
                MessageBox.Show("Digite o codigo do Produto!" + erro);
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {

            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProdutos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);

            carrinho.AcceptChanges();

            total -= subproduto;

            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //passando o cliente e o carrinho para o banco de dados, tbm na tela de pagamentos
            DateTime dataAtual = DateTime.Parse(txtDataCompra.Text);
            
            FrmPagamentos tela = new FrmPagamentos(cliente, carrinho, dataAtual);
            tela.txttotal.Text = total.ToString();
            this.Hide();
            tela.ShowDialog(); //show ou show dialog é a criterio, diferença é que não pode fechar antes
            this.Close();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                pr = prDAO.RetornaProdutoPorCodigo(int.Parse(txtcodigo.Text));
                if (pr != null)
                {
                    txtdesc.Text = pr.descricao;
                    txtPreco.Text = pr.preco.ToString();
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
     
            }
        }


    }
}
