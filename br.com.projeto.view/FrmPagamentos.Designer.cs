namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmPagamentos
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
            this.txttroco = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label02 = new System.Windows.Forms.Label();
            this.txtbos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 104);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(300, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAGAMENTO";
            // 
            // txttroco
            // 
            this.txttroco.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(254, 296);
            this.txttroco.Name = "txttroco";
            this.txttroco.ReadOnly = true;
            this.txttroco.Size = new System.Drawing.Size(231, 43);
            this.txttroco.TabIndex = 18;
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtData.Location = new System.Drawing.Point(138, 296);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(101, 36);
            this.txtData.TabIndex = 17;
            this.txtData.Text = "Troco:";
            // 
            // txtcartao
            // 
            this.txtcartao.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcartao.Location = new System.Drawing.Point(254, 226);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(231, 43);
            this.txtcartao.TabIndex = 20;
            this.txtcartao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(118, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cartão:";
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinheiro.Location = new System.Drawing.Point(254, 152);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(231, 43);
            this.txtdinheiro.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dinheiro (R$):";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(254, 362);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(231, 43);
            this.txttotal.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(149, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(44, 428);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(441, 67);
            this.btnFinalizar.TabIndex = 25;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label02.Location = new System.Drawing.Point(633, 152);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(204, 36);
            this.label02.TabIndex = 26;
            this.label02.Text = "Observações";
            // 
            // txtbos
            // 
            this.txtbos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbos.Location = new System.Drawing.Point(582, 198);
            this.txtbos.Multiline = true;
            this.txtbos.Name = "txtbos";
            this.txtbos.Size = new System.Drawing.Size(313, 297);
            this.txtbos.TabIndex = 27;
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.txtbos);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPagamentos";
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.TextBox txtbos;
    }
}