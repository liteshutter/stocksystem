namespace LiteGears.Forms
{
    partial class frm_tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tools));
            this.gbo_all = new System.Windows.Forms.GroupBox();
            this.gbo_cont = new System.Windows.Forms.GroupBox();
            this.txt_pr_t = new System.Windows.Forms.TextBox();
            this.cbo_iva = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tools = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_iva = new System.Windows.Forms.CheckBox();
            this.txt_pre_un = new System.Windows.Forms.TextBox();
            this.txt_fam = new System.Windows.Forms.TextBox();
            this.txt_armazem = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.cbo_un = new System.Windows.Forms.ComboBox();
            this.txt_artigo = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_elim = new System.Windows.Forms.Button();
            this.btn_edita = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gbo_info = new System.Windows.Forms.GroupBox();
            this.cbo_for = new System.Windows.Forms.ComboBox();
            this.dtp_ii = new System.Windows.Forms.DateTimePicker();
            this.dtp_c = new System.Windows.Forms.DateTimePicker();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.lbl_in = new System.Windows.Forms.Label();
            this.lbl_fa = new System.Windows.Forms.Label();
            this.lbl_for = new System.Windows.Forms.Label();
            this.txt_fa = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_id_p = new System.Windows.Forms.Label();
            this.gbo_all.SuspendLayout();
            this.gbo_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tools)).BeginInit();
            this.gbo_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // gbo_all
            // 
            this.gbo_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbo_all.Controls.Add(this.lbl_id_p);
            this.gbo_all.Controls.Add(this.gbo_cont);
            this.gbo_all.Controls.Add(this.gbo_info);
            this.gbo_all.Enabled = false;
            this.gbo_all.Location = new System.Drawing.Point(2, 32);
            this.gbo_all.Name = "gbo_all";
            this.gbo_all.Size = new System.Drawing.Size(899, 456);
            this.gbo_all.TabIndex = 6;
            this.gbo_all.TabStop = false;
            this.gbo_all.Text = "Ferramentas";
            // 
            // gbo_cont
            // 
            this.gbo_cont.Controls.Add(this.txt_pr_t);
            this.gbo_cont.Controls.Add(this.cbo_iva);
            this.gbo_cont.Controls.Add(this.btn_add);
            this.gbo_cont.Controls.Add(this.label7);
            this.gbo_cont.Controls.Add(this.label6);
            this.gbo_cont.Controls.Add(this.label5);
            this.gbo_cont.Controls.Add(this.label4);
            this.gbo_cont.Controls.Add(this.label3);
            this.gbo_cont.Controls.Add(this.label2);
            this.gbo_cont.Controls.Add(this.label1);
            this.gbo_cont.Controls.Add(this.dgv_tools);
            this.gbo_cont.Controls.Add(this.cbx_iva);
            this.gbo_cont.Controls.Add(this.txt_pre_un);
            this.gbo_cont.Controls.Add(this.txt_fam);
            this.gbo_cont.Controls.Add(this.txt_armazem);
            this.gbo_cont.Controls.Add(this.txt_qtd);
            this.gbo_cont.Controls.Add(this.cbo_un);
            this.gbo_cont.Controls.Add(this.txt_artigo);
            this.gbo_cont.Controls.Add(this.txt_desc);
            this.gbo_cont.Location = new System.Drawing.Point(6, 97);
            this.gbo_cont.Name = "gbo_cont";
            this.gbo_cont.Size = new System.Drawing.Size(887, 354);
            this.gbo_cont.TabIndex = 18;
            this.gbo_cont.TabStop = false;
            // 
            // txt_pr_t
            // 
            this.txt_pr_t.Location = new System.Drawing.Point(796, 47);
            this.txt_pr_t.MaxLength = 10;
            this.txt_pr_t.Name = "txt_pr_t";
            this.txt_pr_t.Size = new System.Drawing.Size(85, 20);
            this.txt_pr_t.TabIndex = 22;
            this.txt_pr_t.Visible = false;
            // 
            // cbo_iva
            // 
            this.cbo_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_iva.FormattingEnabled = true;
            this.cbo_iva.Items.AddRange(new object[] {
            "17",
            "00"});
            this.cbo_iva.Location = new System.Drawing.Point(796, 73);
            this.cbo_iva.Name = "cbo_iva";
            this.cbo_iva.Size = new System.Drawing.Size(49, 21);
            this.cbo_iva.TabIndex = 21;
            this.cbo_iva.Visible = false;
            this.cbo_iva.SelectedIndexChanged += new System.EventHandler(this.cbo_iva_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(415, 68);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(33, 33);
            this.btn_add.TabIndex = 20;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Preço Unitário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "QTD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Armazém:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Família:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "UN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Artigo:";
            // 
            // dgv_tools
            // 
            this.dgv_tools.AllowUserToAddRows = false;
            this.dgv_tools.AllowUserToDeleteRows = false;
            this.dgv_tools.AllowUserToResizeColumns = false;
            this.dgv_tools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tools.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_tools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgv_tools.Location = new System.Drawing.Point(6, 103);
            this.dgv_tools.Name = "dgv_tools";
            this.dgv_tools.ReadOnly = true;
            this.dgv_tools.RowHeadersVisible = false;
            this.dgv_tools.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_tools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tools.Size = new System.Drawing.Size(875, 245);
            this.dgv_tools.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Artigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descrição";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "UN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "QTD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Família";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Armazém";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Preço Unitário";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "IVA";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Preço C/IVA";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "for";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "num_fa";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "data_ins";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "data_c";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // cbx_iva
            // 
            this.cbx_iva.AutoSize = true;
            this.cbx_iva.Location = new System.Drawing.Point(666, 73);
            this.cbx_iva.Name = "cbx_iva";
            this.cbx_iva.Size = new System.Drawing.Size(43, 17);
            this.cbx_iva.TabIndex = 6;
            this.cbx_iva.Text = "IVA";
            this.cbx_iva.UseVisualStyleBackColor = true;
            this.cbx_iva.CheckedChanged += new System.EventHandler(this.cbx_iva_CheckedChanged);
            // 
            // txt_pre_un
            // 
            this.txt_pre_un.Location = new System.Drawing.Point(666, 47);
            this.txt_pre_un.MaxLength = 30;
            this.txt_pre_un.Name = "txt_pre_un";
            this.txt_pre_un.Size = new System.Drawing.Size(101, 20);
            this.txt_pre_un.TabIndex = 5;
            this.txt_pre_un.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pre_un_KeyPress);
            // 
            // txt_fam
            // 
            this.txt_fam.Location = new System.Drawing.Point(415, 20);
            this.txt_fam.MaxLength = 30;
            this.txt_fam.Name = "txt_fam";
            this.txt_fam.Size = new System.Drawing.Size(167, 20);
            this.txt_fam.TabIndex = 4;
            // 
            // txt_armazem
            // 
            this.txt_armazem.Location = new System.Drawing.Point(415, 46);
            this.txt_armazem.MaxLength = 30;
            this.txt_armazem.Name = "txt_armazem";
            this.txt_armazem.Size = new System.Drawing.Size(167, 20);
            this.txt_armazem.TabIndex = 3;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(666, 21);
            this.txt_qtd.MaxLength = 10;
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(62, 20);
            this.txt_qtd.TabIndex = 2;
            this.txt_qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtd_KeyPress);
            // 
            // cbo_un
            // 
            this.cbo_un.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_un.FormattingEnabled = true;
            this.cbo_un.Items.AddRange(new object[] {
            "KG",
            "LT",
            "MT",
            "TON",
            "UN"});
            this.cbo_un.Location = new System.Drawing.Point(244, 20);
            this.cbo_un.Name = "cbo_un";
            this.cbo_un.Size = new System.Drawing.Size(49, 21);
            this.cbo_un.TabIndex = 1;
            // 
            // txt_artigo
            // 
            this.txt_artigo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_artigo.Location = new System.Drawing.Point(84, 20);
            this.txt_artigo.MaxLength = 30;
            this.txt_artigo.Name = "txt_artigo";
            this.txt_artigo.Size = new System.Drawing.Size(107, 20);
            this.txt_artigo.TabIndex = 0;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(84, 46);
            this.txt_desc.MaxLength = 30;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(209, 20);
            this.txt_desc.TabIndex = 0;
            // 
            // btn_elim
            // 
            this.btn_elim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_elim.BackColor = System.Drawing.Color.Silver;
            this.btn_elim.Enabled = false;
            this.btn_elim.FlatAppearance.BorderSize = 0;
            this.btn_elim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim.Image = ((System.Drawing.Image)(resources.GetObject("btn_elim.Image")));
            this.btn_elim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_elim.Location = new System.Drawing.Point(500, 493);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(62, 23);
            this.btn_elim.TabIndex = 17;
            this.btn_elim.Text = "Elimina";
            this.btn_elim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elim.UseVisualStyleBackColor = false;
            // 
            // btn_edita
            // 
            this.btn_edita.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edita.BackColor = System.Drawing.Color.Silver;
            this.btn_edita.Enabled = false;
            this.btn_edita.FlatAppearance.BorderSize = 0;
            this.btn_edita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edita.Image = ((System.Drawing.Image)(resources.GetObject("btn_edita.Image")));
            this.btn_edita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edita.Location = new System.Drawing.Point(438, 493);
            this.btn_edita.Name = "btn_edita";
            this.btn_edita.Size = new System.Drawing.Size(56, 23);
            this.btn_edita.TabIndex = 16;
            this.btn_edita.Text = "Edita";
            this.btn_edita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edita.UseVisualStyleBackColor = false;
            // 
            // btn_busca
            // 
            this.btn_busca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_busca.BackColor = System.Drawing.Color.Silver;
            this.btn_busca.FlatAppearance.BorderSize = 0;
            this.btn_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busca.Image = ((System.Drawing.Image)(resources.GetObject("btn_busca.Image")));
            this.btn_busca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busca.Location = new System.Drawing.Point(372, 493);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(60, 23);
            this.btn_busca.TabIndex = 15;
            this.btn_busca.Text = "Busca";
            this.btn_busca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.Silver;
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(310, 493);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Salva";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gbo_info
            // 
            this.gbo_info.Controls.Add(this.cbo_for);
            this.gbo_info.Controls.Add(this.dtp_ii);
            this.gbo_info.Controls.Add(this.dtp_c);
            this.gbo_info.Controls.Add(this.lbl_cp);
            this.gbo_info.Controls.Add(this.lbl_in);
            this.gbo_info.Controls.Add(this.lbl_fa);
            this.gbo_info.Controls.Add(this.lbl_for);
            this.gbo_info.Controls.Add(this.txt_fa);
            this.gbo_info.Location = new System.Drawing.Point(6, 22);
            this.gbo_info.Name = "gbo_info";
            this.gbo_info.Size = new System.Drawing.Size(526, 69);
            this.gbo_info.TabIndex = 1;
            this.gbo_info.TabStop = false;
            // 
            // cbo_for
            // 
            this.cbo_for.FormattingEnabled = true;
            this.cbo_for.Location = new System.Drawing.Point(84, 18);
            this.cbo_for.Name = "cbo_for";
            this.cbo_for.Size = new System.Drawing.Size(209, 21);
            this.cbo_for.TabIndex = 7;
            this.cbo_for.SelectedIndexChanged += new System.EventHandler(this.cbo_for_SelectedIndexChanged);
            // 
            // dtp_ii
            // 
            this.dtp_ii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ii.Location = new System.Drawing.Point(415, 43);
            this.dtp_ii.Name = "dtp_ii";
            this.dtp_ii.Size = new System.Drawing.Size(99, 20);
            this.dtp_ii.TabIndex = 12;
            // 
            // dtp_c
            // 
            this.dtp_c.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_c.Location = new System.Drawing.Point(415, 19);
            this.dtp_c.Name = "dtp_c";
            this.dtp_c.Size = new System.Drawing.Size(99, 20);
            this.dtp_c.TabIndex = 11;
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(312, 22);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(97, 13);
            this.lbl_cp.TabIndex = 10;
            this.lbl_cp.Text = "Data de Aquisição:";
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.Location = new System.Drawing.Point(312, 46);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(92, 13);
            this.lbl_in.TabIndex = 9;
            this.lbl_in.Text = "Data de Inserção:";
            // 
            // lbl_fa
            // 
            this.lbl_fa.AutoSize = true;
            this.lbl_fa.Location = new System.Drawing.Point(14, 46);
            this.lbl_fa.Name = "lbl_fa";
            this.lbl_fa.Size = new System.Drawing.Size(46, 13);
            this.lbl_fa.TabIndex = 8;
            this.lbl_fa.Text = "Factura:";
            // 
            // lbl_for
            // 
            this.lbl_for.AutoSize = true;
            this.lbl_for.Location = new System.Drawing.Point(14, 22);
            this.lbl_for.Name = "lbl_for";
            this.lbl_for.Size = new System.Drawing.Size(64, 13);
            this.lbl_for.TabIndex = 7;
            this.lbl_for.Text = "Fornecedor:";
            // 
            // txt_fa
            // 
            this.txt_fa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_fa.Location = new System.Drawing.Point(84, 43);
            this.txt_fa.MaxLength = 30;
            this.txt_fa.Name = "txt_fa";
            this.txt_fa.Size = new System.Drawing.Size(107, 20);
            this.txt_fa.TabIndex = 1;
            // 
            // btn_novo
            // 
            this.btn_novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novo.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(838, 12);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(57, 23);
            this.btn_novo.TabIndex = 15;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // lbl_id_p
            // 
            this.lbl_id_p.AutoSize = true;
            this.lbl_id_p.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_p.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_id_p.Location = new System.Drawing.Point(538, 31);
            this.lbl_id_p.Name = "lbl_id_p";
            this.lbl_id_p.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_p.TabIndex = 19;
            // 
            // frm_tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.gbo_all);
            this.Controls.Add(this.btn_elim);
            this.Controls.Add(this.btn_edita);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_busca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_tools_Load);
            this.gbo_all.ResumeLayout(false);
            this.gbo_all.PerformLayout();
            this.gbo_cont.ResumeLayout(false);
            this.gbo_cont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tools)).EndInit();
            this.gbo_info.ResumeLayout(false);
            this.gbo_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbo_all;
        private System.Windows.Forms.GroupBox gbo_info;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.Label lbl_fa;
        private System.Windows.Forms.Label lbl_for;
        private System.Windows.Forms.TextBox txt_fa;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Button btn_edita;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_ii;
        private System.Windows.Forms.DateTimePicker dtp_c;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.GroupBox gbo_cont;
        private System.Windows.Forms.CheckBox cbx_iva;
        private System.Windows.Forms.TextBox txt_pre_un;
        private System.Windows.Forms.TextBox txt_fam;
        private System.Windows.Forms.TextBox txt_armazem;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.ComboBox cbo_un;
        private System.Windows.Forms.TextBox txt_artigo;
        private System.Windows.Forms.ComboBox cbo_for;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tools;
        private System.Windows.Forms.ComboBox cbo_iva;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txt_pr_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label lbl_id_p;
    }
}