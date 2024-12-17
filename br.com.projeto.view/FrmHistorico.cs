using Projeto_Controle_Vendas.br.com.projeto.dao;
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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtinicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtinicio.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();

            tabelaHistorico.DataSource = dao.listarVendasPorPeriodo(datainicio, datafim);

        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao =  new VendaDAO();
            tabelaHistorico.DataSource = dao.ListarVendas();
            tabelaHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //passando o id pra outra tela
            //full gambiarra
            int idvenda = int.Parse(tabelaHistorico.CurrentRow.Cells[0].Value.ToString());
            Frmdetalhes tela = new Frmdetalhes(idvenda);

            //fromatação da data

            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtdata.Text = dataVenda.ToString("dd/MM/yyyy"); ;
            tela.txtcliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txttotal.Text = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtobs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();
           
            
            

            tela.ShowDialog();

        }

        private void tabelaHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
