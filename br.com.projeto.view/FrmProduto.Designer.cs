namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmProduto
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
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabCadProduto = new System.Windows.Forms.TabPage();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.btnpesquisarFornecedor = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProdutos.SuspendLayout();
            this.tabCadProduto.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneditar.Location = new System.Drawing.Point(542, 560);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(140, 40);
            this.btneditar.TabIndex = 17;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalvar.Location = new System.Drawing.Point(345, 560);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(140, 40);
            this.btnsalvar.TabIndex = 16;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexcluir.Location = new System.Drawing.Point(754, 560);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(140, 40);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnovo.Location = new System.Drawing.Point(144, 560);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(140, 40);
            this.btnnovo.TabIndex = 14;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabCadProduto);
            this.tabProdutos.Controls.Add(this.tabConsulta);
            this.tabProdutos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(12, 89);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(919, 456);
            this.tabProdutos.TabIndex = 13;
            // 
            // tabCadProduto
            // 
            this.tabCadProduto.Controls.Add(this.cbfornecedor);
            this.tabCadProduto.Controls.Add(this.label5);
            this.tabCadProduto.Controls.Add(this.txtPreco);
            this.tabCadProduto.Controls.Add(this.label4);
            this.tabCadProduto.Controls.Add(this.txtestoque);
            this.tabCadProduto.Controls.Add(this.label6);
            this.tabCadProduto.Controls.Add(this.txtdesc);
            this.tabCadProduto.Controls.Add(this.label3);
            this.tabCadProduto.Controls.Add(this.txtcodigo);
            this.tabCadProduto.Controls.Add(this.label2);
            this.tabCadProduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadProduto.Location = new System.Drawing.Point(4, 25);
            this.tabCadProduto.Name = "tabCadProduto";
            this.tabCadProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadProduto.Size = new System.Drawing.Size(911, 427);
            this.tabCadProduto.TabIndex = 0;
            this.tabCadProduto.Text = "Dados Pessoais";
            this.tabCadProduto.UseVisualStyleBackColor = true;
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(128, 193);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(389, 29);
            this.cbfornecedor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fornecedor: ";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(709, 88);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(156, 27);
            this.txtPreco.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(610, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço (R$):";
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(128, 147);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(98, 27);
            this.txtestoque.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(7, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Qtd Estoque:";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(128, 91);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(389, 27);
            this.txtdesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(128, 40);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(105, 27);
            this.txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tabelaProdutos);
            this.tabConsulta.Controls.Add(this.btnpesquisarFornecedor);
            this.tabConsulta.Controls.Add(this.txtpesquisa);
            this.tabConsulta.Controls.Add(this.label16);
            this.tabConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(911, 427);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(31, 95);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.Size = new System.Drawing.Size(897, 277);
            this.tabelaProdutos.TabIndex = 7;
            this.tabelaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProdutos_CellClick);
            // 
            // btnpesquisarFornecedor
            // 
            this.btnpesquisarFornecedor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnpesquisarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisarFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpesquisarFornecedor.Location = new System.Drawing.Point(500, 44);
            this.btnpesquisarFornecedor.Name = "btnpesquisarFornecedor";
            this.btnpesquisarFornecedor.Size = new System.Drawing.Size(140, 27);
            this.btnpesquisarFornecedor.TabIndex = 6;
            this.btnpesquisarFornecedor.Text = "Pesquisar";
            this.btnpesquisarFornecedor.UseVisualStyleBackColor = false;
            this.btnpesquisarFornecedor.Click += new System.EventHandler(this.btnpesquisarFornecedor_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(92, 44);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(389, 27);
            this.txtpesquisa.TabIndex = 5;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(27, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 21);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 83);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 652);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.tabProdutos.ResumeLayout(false);
            this.tabCadProduto.ResumeLayout(false);
            this.tabCadProduto.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.Button btnpesquisarFornecedor;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabControl tabProdutos;
        public System.Windows.Forms.TabPage tabCadProduto;
        public System.Windows.Forms.TabPage tabConsulta;
    }
}