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
    public partial class FrmPagamentos : Form
    {
        Cliente cliente = new Cliente();

        DataTable carrinho = new DataTable();

        DateTime dataAtual;

        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //onde a magica acontecem criação das variaveis e os objetos
                decimal v_dinheiro, v_cartao, v_troco, totalpago, total;
                ProdutoDAO dao_produto = new ProdutoDAO();

                v_dinheiro = decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);
                int qtd_estoque, qtd_comprada, qtd_atualizada;

                totalpago = v_dinheiro + v_cartao;

                if (totalpago < total)
                {
                    MessageBox.Show("Tá levando calote!!");
                }
                else 
                { 
                    v_troco = totalpago - total;
                    Venda vendas = new Venda();
                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataAtual;
                    vendas.total_venda = total;
                    vendas.obs = txtbos.Text;

                    VendaDAO vDAO = new VendaDAO();

                    txttroco.Text = v_troco.ToString();
                    vDAO.cadastrarVenda(vendas);
                    
                    //cadastro dos itens da venda
                    //trabalho em conjunto com a parte de vendas

                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItemVenda itemVenda = new ItemVenda();

                        itemVenda.venda_id = vDAO.retornaIdUltimaVenda();
                        itemVenda.produto_id = int.Parse(linha["Código"].ToString());
                        itemVenda.qtd = int.Parse(linha["Qtd"].ToString());
                        itemVenda.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        //baixa estoque
                        qtd_estoque = dao_produto.RetornaEstoqueAtual(itemVenda.produto_id);
                        qtd_comprada = itemVenda.qtd;
                        qtd_atualizada = qtd_estoque - qtd_comprada;
                        dao_produto.BaixarEstoque(itemVenda.produto_id, qtd_atualizada);


                        ItemVendaDAO itDAO = new ItemVendaDAO();
                        itDAO.cadastrarItem(itemVenda);                        
                    }
                    MessageBox.Show("Venda Finalizada com Sucesso");
                    this.Dispose();                 
                    new FrmVendas().ShowDialog();
                }
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Venda não concluida!");              
            }
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {

            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";

        }
    }
}
