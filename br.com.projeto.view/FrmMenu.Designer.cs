namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClientes,
            this.MenuFuncionarios,
            this.MenuFornecedores,
            this.MenuProdutos,
            this.MenuVendas,
            this.MenuConfiguracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuClientes
            // 
            this.MenuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarCliente,
            this.menuConsultaCliente});
            this.MenuClientes.Image = global::Projeto_Controle_Vendas.Properties.Resources.cliente;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(141, 84);
            this.MenuClientes.Text = "Clientes";
            // 
            // menuCadastrarCliente
            // 
            this.menuCadastrarCliente.Name = "menuCadastrarCliente";
            this.menuCadastrarCliente.Size = new System.Drawing.Size(182, 22);
            this.menuCadastrarCliente.Text = "Cadastro de Clientes";
            this.menuCadastrarCliente.Click += new System.EventHandler(this.menuCadastrarCliente_Click);
            // 
            // menuConsultaCliente
            // 
            this.menuConsultaCliente.Name = "menuConsultaCliente";
            this.menuConsultaCliente.Size = new System.Drawing.Size(182, 22);
            this.menuConsultaCliente.Text = "Consulta de Clientes";
            this.menuConsultaCliente.Click += new System.EventHandler(this.menuConsultaCliente_Click);
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarFuncionario,
            this.menuConsultaFuncionario});
            this.MenuFuncionarios.Image = global::Projeto_Controle_Vendas.Properties.Resources.funcionarios;
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(167, 84);
            this.MenuFuncionarios.Text = "Funcionários";
            // 
            // menuCadastrarFuncionario
            // 
            this.menuCadastrarFuncionario.Name = "menuCadastrarFuncionario";
            this.menuCadastrarFuncionario.Size = new System.Drawing.Size(208, 22);
            this.menuCadastrarFuncionario.Text = "Cadastro de Funcionários";
            this.menuCadastrarFuncionario.Click += new System.EventHandler(this.menuCadastrarFuncionario_Click);
            // 
            // menuConsultaFuncionario
            // 
            this.menuConsultaFuncionario.Name = "menuConsultaFuncionario";
            this.menuConsultaFuncionario.Size = new System.Drawing.Size(208, 22);
            this.menuConsultaFuncionario.Text = "Consulta de Funcionários";
            this.menuConsultaFuncionario.Click += new System.EventHandler(this.menuConsultaFuncionario_Click);
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarFornecedor,
            this.menuConsultaFornecedor});
            this.MenuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources.fornecedor;
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(170, 84);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // menuCadastrarFornecedor
            // 
            this.menuCadastrarFornecedor.Name = "menuCadastrarFornecedor";
            this.menuCadastrarFornecedor.Size = new System.Drawing.Size(211, 22);
            this.menuCadastrarFornecedor.Text = "Cadastro de Fornecedores";
            this.menuCadastrarFornecedor.Click += new System.EventHandler(this.menuCadastrarFornecedor_Click);
            // 
            // menuConsultaFornecedor
            // 
            this.menuConsultaFornecedor.Name = "menuConsultaFornecedor";
            this.menuConsultaFornecedor.Size = new System.Drawing.Size(211, 22);
            this.menuConsultaFornecedor.Text = "Consulta de Fornecedores";
            this.menuConsultaFornecedor.Click += new System.EventHandler(this.menuConsultaFornecedor_Click);
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarProduto,
            this.menuConsultaProduto});
            this.MenuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources.mais_vendidos;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(147, 84);
            this.MenuProdutos.Text = "Produtos";
            // 
            // menuCadastrarProduto
            // 
            this.menuCadastrarProduto.Name = "menuCadastrarProduto";
            this.menuCadastrarProduto.Size = new System.Drawing.Size(188, 22);
            this.menuCadastrarProduto.Text = "Cadastro de Produtos";
            this.menuCadastrarProduto.Click += new System.EventHandler(this.menuCadastrarProduto_Click);
            // 
            // menuConsultaProduto
            // 
            this.menuConsultaProduto.Name = "menuConsultaProduto";
            this.menuConsultaProduto.Size = new System.Drawing.Size(188, 22);
            this.menuConsultaProduto.Text = "Consulta de Produtos";
            this.menuConsultaProduto.Click += new System.EventHandler(this.menuConsultaProduto_Click);
            // 
            // MenuVendas
            // 
            this.MenuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuConsultaVendas});
            this.MenuVendas.Image = global::Projeto_Controle_Vendas.Properties.Resources.crescimento;
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(136, 84);
            this.MenuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(180, 22);
            this.menuNovaVenda.Text = "Nova Venda";
            this.menuNovaVenda.Click += new System.EventHandler(this.menuNovaVenda_Click);
            // 
            // menuConsultaVendas
            // 
            this.menuConsultaVendas.Name = "menuConsultaVendas";
            this.menuConsultaVendas.Size = new System.Drawing.Size(180, 22);
            this.menuConsultaVendas.Text = "Histórico de Vendas";
            this.menuConsultaVendas.Click += new System.EventHandler(this.menuConsultaVendas_Click);
            // 
            // MenuConfiguracao
            // 
            this.MenuConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeUsuárioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.MenuConfiguracao.Image = global::Projeto_Controle_Vendas.Properties.Resources.configuracoes;
            this.MenuConfiguracao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuConfiguracao.Name = "MenuConfiguracao";
            this.MenuConfiguracao.Size = new System.Drawing.Size(176, 84);
            this.MenuConfiguracao.Text = "Configurações";
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            this.trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            this.trocarDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarDeUsuárioToolStripMenuItem.Text = "Trocar de Usuário";
            this.trocarDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarDeUsuárioToolStripMenuItem_Click);
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Data atual";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtData
            // 
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(65, 17);
            this.txtData.Text = "17/08/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel3.Text = "Horario:";
            // 
            // txtHora
            // 
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(34, 17);
            this.txtHora.Text = "10:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel5.Text = "Usuário Logado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(52, 17);
            this.txtUsuario.Text = "Marquin";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources._4075174;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 652);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuCadastrarProduto;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}