namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmclientes
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
            this.tabclientes = new System.Windows.Forms.TabControl();
            this.tabDadosPessoais = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tabelaCliente = new System.Windows.Forms.DataGridView();
            this.btnpesquisarFuncionarios = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabclientes.SuspendLayout();
            this.tabDadosPessoais.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 83);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // tabclientes
            // 
            this.tabclientes.Controls.Add(this.tabDadosPessoais);
            this.tabclientes.Controls.Add(this.tabConsulta);
            this.tabclientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabclientes.Location = new System.Drawing.Point(3, 89);
            this.tabclientes.Name = "tabclientes";
            this.tabclientes.SelectedIndex = 0;
            this.tabclientes.Size = new System.Drawing.Size(978, 435);
            this.tabclientes.TabIndex = 1;
            // 
            // tabDadosPessoais
            // 
            this.tabDadosPessoais.Controls.Add(this.button1);
            this.tabDadosPessoais.Controls.Add(this.cbuf);
            this.tabDadosPessoais.Controls.Add(this.label15);
            this.tabDadosPessoais.Controls.Add(this.txtcomplemento);
            this.tabDadosPessoais.Controls.Add(this.label14);
            this.tabDadosPessoais.Controls.Add(this.txtcidade);
            this.tabDadosPessoais.Controls.Add(this.label13);
            this.tabDadosPessoais.Controls.Add(this.txtendereco);
            this.tabDadosPessoais.Controls.Add(this.label12);
            this.tabDadosPessoais.Controls.Add(this.txtnumero);
            this.tabDadosPessoais.Controls.Add(this.label11);
            this.tabDadosPessoais.Controls.Add(this.txtbairro);
            this.tabDadosPessoais.Controls.Add(this.label10);
            this.tabDadosPessoais.Controls.Add(this.txtcep);
            this.tabDadosPessoais.Controls.Add(this.label9);
            this.tabDadosPessoais.Controls.Add(this.txttelefone);
            this.tabDadosPessoais.Controls.Add(this.label8);
            this.tabDadosPessoais.Controls.Add(this.txtcelular);
            this.tabDadosPessoais.Controls.Add(this.label7);
            this.tabDadosPessoais.Controls.Add(this.txtrg);
            this.tabDadosPessoais.Controls.Add(this.txtcpf);
            this.tabDadosPessoais.Controls.Add(this.txtemail);
            this.tabDadosPessoais.Controls.Add(this.label6);
            this.tabDadosPessoais.Controls.Add(this.label5);
            this.tabDadosPessoais.Controls.Add(this.label4);
            this.tabDadosPessoais.Controls.Add(this.txtnome);
            this.tabDadosPessoais.Controls.Add(this.label3);
            this.tabDadosPessoais.Controls.Add(this.txtcodigo);
            this.tabDadosPessoais.Controls.Add(this.label2);
            this.tabDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDadosPessoais.Location = new System.Drawing.Point(4, 25);
            this.tabDadosPessoais.Name = "tabDadosPessoais";
            this.tabDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPessoais.Size = new System.Drawing.Size(970, 406);
            this.tabDadosPessoais.TabIndex = 0;
            this.tabDadosPessoais.Text = "Dados Pessoais";
            this.tabDadosPessoais.UseVisualStyleBackColor = true;
            this.tabDadosPessoais.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(515, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPesqusisarCep);
            // 
            // cbuf
            // 
            this.cbuf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(485, 340);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(143, 29);
            this.cbuf.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label15.Location = new System.Drawing.Point(441, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 21);
            this.label15.TabIndex = 28;
            this.label15.Text = "UF:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.Location = new System.Drawing.Point(146, 342);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(151, 27);
            this.txtcomplemento.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label14.Location = new System.Drawing.Point(12, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Complemento:";
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(453, 245);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(206, 27);
            this.txtcidade.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label13.Location = new System.Drawing.Point(374, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cidade:";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(105, 291);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(276, 27);
            this.txtendereco.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Location = new System.Drawing.Point(441, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bairro:";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(774, 248);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(97, 27);
            this.txtnumero.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Location = new System.Drawing.Point(681, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Numero:";
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(510, 288);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(206, 27);
            this.txtbairro.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Location = new System.Drawing.Point(10, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Endereço:";
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(382, 183);
            this.txtcep.Mask = "00000-999";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(127, 27);
            this.txtcep.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(331, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "CEP:";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(105, 245);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(224, 27);
            this.txttelefone.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(5, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefone:";
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(105, 184);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(189, 27);
            this.txtcelular.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(7, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular:";
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(610, 65);
            this.txtrg.Mask = "##,###,###-##";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(261, 27);
            this.txtrg.TabIndex = 11;
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(607, 119);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(264, 27);
            this.txtcpf.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(105, 119);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(386, 27);
            this.txtemail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(7, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(569, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(564, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(105, 65);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(389, 27);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(105, 18);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(105, 27);
            this.txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tabelaCliente);
            this.tabConsulta.Controls.Add(this.btnpesquisarFuncionarios);
            this.tabConsulta.Controls.Add(this.txtpesquisa);
            this.tabConsulta.Controls.Add(this.label16);
            this.tabConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(970, 406);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tabelaCliente
            // 
            this.tabelaCliente.AllowUserToAddRows = false;
            this.tabelaCliente.AllowUserToDeleteRows = false;
            this.tabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCliente.Location = new System.Drawing.Point(31, 95);
            this.tabelaCliente.Name = "tabelaCliente";
            this.tabelaCliente.ReadOnly = true;
            this.tabelaCliente.Size = new System.Drawing.Size(897, 277);
            this.tabelaCliente.TabIndex = 7;
            this.tabelaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCliente_CellClick);
            // 
            // btnpesquisarFuncionarios
            // 
            this.btnpesquisarFuncionarios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnpesquisarFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisarFuncionarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpesquisarFuncionarios.Location = new System.Drawing.Point(500, 44);
            this.btnpesquisarFuncionarios.Name = "btnpesquisarFuncionarios";
            this.btnpesquisarFuncionarios.Size = new System.Drawing.Size(140, 27);
            this.btnpesquisarFuncionarios.TabIndex = 6;
            this.btnpesquisarFuncionarios.Text = "Pesquisar";
            this.btnpesquisarFuncionarios.UseVisualStyleBackColor = false;
            this.btnpesquisarFuncionarios.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(92, 44);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(389, 27);
            this.txtpesquisa.TabIndex = 5;
            this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
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
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnovo.Location = new System.Drawing.Point(128, 550);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(140, 40);
            this.btnnovo.TabIndex = 2;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexcluir.Location = new System.Drawing.Point(738, 550);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(140, 40);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalvar.Location = new System.Drawing.Point(329, 550);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(140, 40);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneditar.Location = new System.Drawing.Point(526, 550);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(140, 40);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 640);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabclientes);
            this.Controls.Add(this.panel1);
            this.Name = "Frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabclientes.ResumeLayout(false);
            this.tabDadosPessoais.ResumeLayout(false);
            this.tabDadosPessoais.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnpesquisarFuncionarios;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView tabelaCliente;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TabControl tabclientes;
        public System.Windows.Forms.TabPage tabDadosPessoais;
        public System.Windows.Forms.TabPage tabConsulta;
    }
}