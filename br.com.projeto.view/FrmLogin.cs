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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string senha = txtSenha.Text;
            FuncionarioDao dao = new FuncionarioDao();

            if (dao.EfetuarLogin(email, senha))
            {
                this.Show();
            }

        }
    }
}
