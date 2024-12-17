namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmVendas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 104);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(468, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataCompra);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCompra.Location = new System.Drawing.Point(74, 44);
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(144, 27);
            this.txtDataCompra.TabIndex = 16;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.a.Location = new System.Drawing.Point(11, 47);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(59, 21);
            this.a.TabIndex = 15;
            this.a.Text = "Data: ";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(74, 129);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(413, 27);
            this.txtnome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(74, 90);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(141, 27);
            this.txtcpf.TabIndex = 12;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnremover);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.txtPreco);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 264);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnremover.Location = new System.Drawing.Point(282, 198);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(169, 40);
            this.btnremover.TabIndex = 21;
            this.btnremover.Text = "Remover Item";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Location = new System.Drawing.Point(53, 198);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 40);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Adicionar Item";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(124, 137);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(156, 27);
            this.txtPreco.TabIndex = 19;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preço (R$):";
            // 
            // txtqtd
            // 
            this.txtqtd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd.Location = new System.Drawing.Point(415, 134);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(72, 27);
            this.txtqtd.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(363, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Qtd:";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(124, 85);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(363, 27);
            this.txtdesc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(124, 37);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(105, 27);
            this.txtcodigo.TabIndex = 13;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(25, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Código:";
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(549, 126);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.Size = new System.Drawing.Size(533, 446);
            this.tabelaProdutos.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(549, 578);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(180, 38);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 27);
            this.txtTotal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(56, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total (R$):";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(872, 683);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPagamento.Location = new System.Drawing.Point(588, 683);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(165, 40);
            this.btnPagamento.TabIndex = 22;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 754);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelaProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.Label a;
    }
}