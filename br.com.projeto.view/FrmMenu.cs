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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //defindo a hora
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuCadastrarCliente_Click(object sender, EventArgs e)
        {
            //abrir a tela
            Frmclientes tela = new Frmclientes();
            tela.Show();
        }

        private void menuConsultaCliente_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.tabclientes.SelectedTab = tela.tabConsulta;
            tela.Show();
        }

        private void menuCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.Show();
        }

        private void menuConsultaFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.tabfuncionarios.SelectedTab = tela.tabConsulta;
            tela.Show();
        }

        private void menuCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.Show();
        }

        private void menuConsultaFornecedor_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.tabFornecedor.SelectedTab = tela.tabConsulta;
            tela.Show();
        }

        private void menuCadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmProduto tela = new FrmProduto();
            tela.Show();

        }

        private void menuConsultaProduto_Click(object sender, EventArgs e)
        {
            FrmProduto tela = new FrmProduto();
            tela.tabProdutos.SelectedTab = tela.tabConsulta;
            tela.Show();

        }

        private void menuNovaVenda_Click(object sender, EventArgs e)
        {
            FrmVendas tela = new FrmVendas();
            tela.Show();
        }

        private void menuConsultaVendas_Click(object sender, EventArgs e)
        {
            FrmHistorico tela = new FrmHistorico();
            tela.Show();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voce deseja sair?", "Atenção!!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voce deseja trocar de Usuário?", "Atenção!!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
                FrmLogin tela = new FrmLogin();
                tela.Show();
            }
        }
    }
}
