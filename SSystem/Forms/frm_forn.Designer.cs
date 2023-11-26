namespace LiteGears.Forms
{
    partial class frm_for
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_for));
            this.tabControlfor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_elim = new System.Windows.Forms.Button();
            this.btn_edita = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbo_mor = new System.Windows.Forms.GroupBox();
            this.txt_ra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbo_cts = new System.Windows.Forms.GroupBox();
            this.txt_fx = new System.Windows.Forms.TextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.txt_em = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_ct = new System.Windows.Forms.TextBox();
            this.lbl_ct = new System.Windows.Forms.Label();
            this.txt_tl = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txt_nuit = new System.Windows.Forms.TextBox();
            this.txt_for = new System.Windows.Forms.TextBox();
            this.lbl_for = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_for1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_fornecedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlfor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbo_mor.SuspendLayout();
            this.gbo_cts.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlfor
            // 
            this.tabControlfor.Controls.Add(this.tabPage1);
            this.tabControlfor.Controls.Add(this.tabPage2);
            this.tabControlfor.Location = new System.Drawing.Point(0, 3);
            this.tabControlfor.Multiline = true;
            this.tabControlfor.Name = "tabControlfor";
            this.tabControlfor.SelectedIndex = 0;
            this.tabControlfor.Size = new System.Drawing.Size(685, 404);
            this.tabControlfor.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_id);
            this.tabPage1.Controls.Add(this.btn_novo);
            this.tabPage1.Controls.Add(this.btn_elim);
            this.tabPage1.Controls.Add(this.btn_edita);
            this.tabPage1.Controls.Add(this.btn_busca);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gbo_mor);
            this.tabPage1.Controls.Add(this.gbo_cts);
            this.tabPage1.Controls.Add(this.txt_nuit);
            this.tabPage1.Controls.Add(this.txt_for);
            this.tabPage1.Controls.Add(this.lbl_for);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reg. Fornecedor";
            this.tabPage1.ToolTipText = "Adicionar Fornecedor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(371, 49);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Visible = false;
            // 
            // btn_novo
            // 
            this.btn_novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novo.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(614, 6);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(57, 23);
            this.btn_novo.TabIndex = 14;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
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
            this.btn_elim.Location = new System.Drawing.Point(402, 349);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(62, 23);
            this.btn_elim.TabIndex = 13;
            this.btn_elim.Text = "Elimina";
            this.btn_elim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elim.UseVisualStyleBackColor = false;
            this.btn_elim.Click += new System.EventHandler(this.btn_elim_Click);
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
            this.btn_edita.Location = new System.Drawing.Point(340, 349);
            this.btn_edita.Name = "btn_edita";
            this.btn_edita.Size = new System.Drawing.Size(56, 23);
            this.btn_edita.TabIndex = 12;
            this.btn_edita.Text = "Edita";
            this.btn_edita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edita.UseVisualStyleBackColor = false;
            this.btn_edita.Click += new System.EventHandler(this.btn_edita_Click);
            // 
            // btn_busca
            // 
            this.btn_busca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_busca.BackColor = System.Drawing.Color.Silver;
            this.btn_busca.FlatAppearance.BorderSize = 0;
            this.btn_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busca.Image = ((System.Drawing.Image)(resources.GetObject("btn_busca.Image")));
            this.btn_busca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busca.Location = new System.Drawing.Point(274, 349);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(60, 23);
            this.btn_busca.TabIndex = 11;
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
            this.btn_save.Location = new System.Drawing.Point(212, 349);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Salva";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUIT:";
            // 
            // gbo_mor
            // 
            this.gbo_mor.Controls.Add(this.txt_ra);
            this.gbo_mor.Controls.Add(this.label5);
            this.gbo_mor.Controls.Add(this.txt_lc);
            this.gbo_mor.Controls.Add(this.label6);
            this.gbo_mor.Enabled = false;
            this.gbo_mor.Location = new System.Drawing.Point(29, 226);
            this.gbo_mor.Name = "gbo_mor";
            this.gbo_mor.Size = new System.Drawing.Size(425, 71);
            this.gbo_mor.TabIndex = 8;
            this.gbo_mor.TabStop = false;
            this.gbo_mor.Text = "Moradas";
            // 
            // txt_ra
            // 
            this.txt_ra.Location = new System.Drawing.Point(88, 16);
            this.txt_ra.MaxLength = 50;
            this.txt_ra.Name = "txt_ra";
            this.txt_ra.Size = new System.Drawing.Size(237, 20);
            this.txt_ra.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua/AV:";
            // 
            // txt_lc
            // 
            this.txt_lc.Location = new System.Drawing.Point(88, 42);
            this.txt_lc.MaxLength = 50;
            this.txt_lc.Name = "txt_lc";
            this.txt_lc.Size = new System.Drawing.Size(237, 20);
            this.txt_lc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Localidade:";
            // 
            // gbo_cts
            // 
            this.gbo_cts.Controls.Add(this.txt_fx);
            this.gbo_cts.Controls.Add(this.lbl_fax);
            this.gbo_cts.Controls.Add(this.txt_em);
            this.gbo_cts.Controls.Add(this.lbl_email);
            this.gbo_cts.Controls.Add(this.txt_ct);
            this.gbo_cts.Controls.Add(this.lbl_ct);
            this.gbo_cts.Controls.Add(this.txt_tl);
            this.gbo_cts.Controls.Add(this.lbl_tel);
            this.gbo_cts.Enabled = false;
            this.gbo_cts.Location = new System.Drawing.Point(29, 96);
            this.gbo_cts.Name = "gbo_cts";
            this.gbo_cts.Size = new System.Drawing.Size(425, 124);
            this.gbo_cts.TabIndex = 3;
            this.gbo_cts.TabStop = false;
            this.gbo_cts.Text = "Contactos";
            // 
            // txt_fx
            // 
            this.txt_fx.Location = new System.Drawing.Point(88, 94);
            this.txt_fx.MaxLength = 30;
            this.txt_fx.Name = "txt_fx";
            this.txt_fx.Size = new System.Drawing.Size(237, 20);
            this.txt_fx.TabIndex = 7;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(19, 97);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(27, 13);
            this.lbl_fax.TabIndex = 0;
            this.lbl_fax.Text = "Fax:";
            // 
            // txt_em
            // 
            this.txt_em.Location = new System.Drawing.Point(88, 68);
            this.txt_em.MaxLength = 50;
            this.txt_em.Name = "txt_em";
            this.txt_em.Size = new System.Drawing.Size(237, 20);
            this.txt_em.TabIndex = 6;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(19, 71);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email:";
            // 
            // txt_ct
            // 
            this.txt_ct.Location = new System.Drawing.Point(88, 16);
            this.txt_ct.MaxLength = 15;
            this.txt_ct.Name = "txt_ct";
            this.txt_ct.Size = new System.Drawing.Size(157, 20);
            this.txt_ct.TabIndex = 4;
            this.txt_ct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ct_KeyPress);
            // 
            // lbl_ct
            // 
            this.lbl_ct.AutoSize = true;
            this.lbl_ct.Location = new System.Drawing.Point(19, 19);
            this.lbl_ct.Name = "lbl_ct";
            this.lbl_ct.Size = new System.Drawing.Size(53, 13);
            this.lbl_ct.TabIndex = 0;
            this.lbl_ct.Text = "Contacto:";
            // 
            // txt_tl
            // 
            this.txt_tl.Location = new System.Drawing.Point(88, 42);
            this.txt_tl.MaxLength = 15;
            this.txt_tl.Name = "txt_tl";
            this.txt_tl.Size = new System.Drawing.Size(157, 20);
            this.txt_tl.TabIndex = 5;
            this.txt_tl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tl_KeyPress);
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(19, 45);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(52, 13);
            this.lbl_tel.TabIndex = 0;
            this.lbl_tel.Text = "Telefone:";
            // 
            // txt_nuit
            // 
            this.txt_nuit.Enabled = false;
            this.txt_nuit.Location = new System.Drawing.Point(117, 72);
            this.txt_nuit.MaxLength = 15;
            this.txt_nuit.Name = "txt_nuit";
            this.txt_nuit.Size = new System.Drawing.Size(104, 20);
            this.txt_nuit.TabIndex = 2;
            this.txt_nuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nuit_KeyPress);
            // 
            // txt_for
            // 
            this.txt_for.Enabled = false;
            this.txt_for.Location = new System.Drawing.Point(117, 46);
            this.txt_for.MaxLength = 50;
            this.txt_for.Name = "txt_for";
            this.txt_for.Size = new System.Drawing.Size(237, 20);
            this.txt_for.TabIndex = 1;
            // 
            // lbl_for
            // 
            this.lbl_for.AutoSize = true;
            this.lbl_for.Location = new System.Drawing.Point(47, 49);
            this.lbl_for.Name = "lbl_for";
            this.lbl_for.Size = new System.Drawing.Size(64, 13);
            this.lbl_for.TabIndex = 0;
            this.lbl_for.Text = "Fornecedor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_for1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgv_fornecedores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Fornecedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_for1
            // 
            this.txt_for1.Location = new System.Drawing.Point(214, 6);
            this.txt_for1.Name = "txt_for1";
            this.txt_for1.Size = new System.Drawing.Size(255, 20);
            this.txt_for1.TabIndex = 19;
            this.txt_for1.TextChanged += new System.EventHandler(this.txt_for1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(127, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fornecedor:";
            // 
            // dgv_fornecedores
            // 
            this.dgv_fornecedores.AllowUserToAddRows = false;
            this.dgv_fornecedores.AllowUserToDeleteRows = false;
            this.dgv_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_fornecedores.Location = new System.Drawing.Point(0, 31);
            this.dgv_fornecedores.Name = "dgv_fornecedores";
            this.dgv_fornecedores.ReadOnly = true;
            this.dgv_fornecedores.RowHeadersVisible = false;
            this.dgv_fornecedores.Size = new System.Drawing.Size(677, 344);
            this.dgv_fornecedores.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fornecedor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NUIT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Celular";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fax";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Rua/AV";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Localidade";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frm_for
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 410);
            this.Controls.Add(this.tabControlfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_for";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_for_Load);
            this.tabControlfor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbo_mor.ResumeLayout(false);
            this.gbo_mor.PerformLayout();
            this.gbo_cts.ResumeLayout(false);
            this.gbo_cts.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlfor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Button btn_edita;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbo_mor;
        private System.Windows.Forms.TextBox txt_ra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbo_cts;
        private System.Windows.Forms.TextBox txt_fx;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.TextBox txt_em;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_ct;
        private System.Windows.Forms.Label lbl_ct;
        private System.Windows.Forms.TextBox txt_tl;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.TextBox txt_nuit;
        private System.Windows.Forms.TextBox txt_for;
        private System.Windows.Forms.Label lbl_for;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_fornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txt_for1;
    }
}