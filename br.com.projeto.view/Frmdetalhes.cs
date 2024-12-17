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
    public partial class Frmdetalhes : Form
    {
        //do histórico para cá
        int venda_id;
        public Frmdetalhes(int idvenda)
        { 
            venda_id = idvenda;
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabelahistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDAO dao = new ItemVendaDAO();


            tabelaDetalhes.DataSource = dao.ListarItensPorVenda(venda_id);
        }
    }
}
