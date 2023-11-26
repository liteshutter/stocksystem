namespace LiteGears
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_tools = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_clie = new System.Windows.Forms.Button();
            this.opt_pes_for = new System.Windows.Forms.GroupBox();
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
            this.gbo_info = new System.Windows.Forms.GroupBox();
            this.txt_for = new System.Windows.Forms.TextBox();
            this.txt_fa = new System.Windows.Forms.TextBox();
            this.txt_data_aq = new System.Windows.Forms.TextBox();
            this.txt_data_in = new System.Windows.Forms.TextBox();
            this.lbl_for = new System.Windows.Forms.Label();
            this.lbl_fa = new System.Windows.Forms.Label();
            this.lbl_in = new System.Windows.Forms.Label();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.gbo_search = new System.Windows.Forms.GroupBox();
            this.txt_pes_fe = new System.Windows.Forms.TextBox();
            this.txt_pes_fa = new System.Windows.Forms.TextBox();
            this.opt_pes_fe = new System.Windows.Forms.RadioButton();
            this.opt_pes_fa = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.opt_pes_for.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tools)).BeginInit();
            this.gbo_info.SuspendLayout();
            this.gbo_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_for
            // 
            this.btn_for.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_for.BackColor = System.Drawing.Color.Silver;
            this.btn_for.FlatAppearance.BorderSize = 0;
            this.btn_for.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_for.Image = ((System.Drawing.Image)(resources.GetObject("btn_for.Image")));
            this.btn_for.Location = new System.Drawing.Point(6, 140);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(55, 55);
            this.btn_for.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_for, "Gestão de Fornecedores");
            this.btn_for.UseVisualStyleBackColor = false;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_tools
            // 
            this.btn_tools.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_tools.BackColor = System.Drawing.Color.Silver;
            this.btn_tools.FlatAppearance.BorderSize = 0;
            this.btn_tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tools.Image = ((System.Drawing.Image)(resources.GetObject("btn_tools.Image")));
            this.btn_tools.Location = new System.Drawing.Point(6, 201);
            this.btn_tools.Name = "btn_tools";
            this.btn_tools.Size = new System.Drawing.Size(55, 55);
            this.btn_tools.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_tools, "Gestão de Ferramentas");
            this.btn_tools.UseVisualStyleBackColor = false;
            this.btn_tools.Click += new System.EventHandler(this.btn_tools_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sales.BackColor = System.Drawing.Color.Silver;
            this.btn_sales.FlatAppearance.BorderSize = 0;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_sales.Image")));
            this.btn_sales.Location = new System.Drawing.Point(6, 323);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(55, 55);
            this.btn_sales.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_sales, "Gestão de Vendas");
            this.btn_sales.UseVisualStyleBackColor = false;
            // 
            // btn_clie
            // 
            this.btn_clie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_clie.BackColor = System.Drawing.Color.Silver;
            this.btn_clie.FlatAppearance.BorderSize = 0;
            this.btn_clie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clie.Image = ((System.Drawing.Image)(resources.GetObject("btn_clie.Image")));
            this.btn_clie.Location = new System.Drawing.Point(6, 262);
            this.btn_clie.Name = "btn_clie";
            this.btn_clie.Size = new System.Drawing.Size(55, 55);
            this.btn_clie.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_clie, "Gestão de Clientes");
            this.btn_clie.UseVisualStyleBackColor = false;
            this.btn_clie.Click += new System.EventHandler(this.btn_clie_Click);
            // 
            // opt_pes_for
            // 
            this.opt_pes_for.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opt_pes_for.Controls.Add(this.gbo_search);
            this.opt_pes_for.Controls.Add(this.gbo_info);
            this.opt_pes_for.Controls.Add(this.dgv_tools);
            this.opt_pes_for.Location = new System.Drawing.Point(67, 12);
            this.opt_pes_for.Name = "opt_pes_for";
            this.opt_pes_for.Size = new System.Drawing.Size(824, 491);
            this.opt_pes_for.TabIndex = 5;
            this.opt_pes_for.TabStop = false;
            this.opt_pes_for.Text = "Ferramentas";
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
            this.dgv_tools.Location = new System.Drawing.Point(6, 97);
            this.dgv_tools.Name = "dgv_tools";
            this.dgv_tools.ReadOnly = true;
            this.dgv_tools.RowHeadersVisible = false;
            this.dgv_tools.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_tools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tools.Size = new System.Drawing.Size(812, 367);
            this.dgv_tools.TabIndex = 0;
            this.dgv_tools.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tools_CellContentClick);
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
            // gbo_info
            // 
            this.gbo_info.Controls.Add(this.lbl_cp);
            this.gbo_info.Controls.Add(this.lbl_in);
            this.gbo_info.Controls.Add(this.lbl_fa);
            this.gbo_info.Controls.Add(this.lbl_for);
            this.gbo_info.Controls.Add(this.txt_data_in);
            this.gbo_info.Controls.Add(this.txt_data_aq);
            this.gbo_info.Controls.Add(this.txt_fa);
            this.gbo_info.Controls.Add(this.txt_for);
            this.gbo_info.Location = new System.Drawing.Point(6, 22);
            this.gbo_info.Name = "gbo_info";
            this.gbo_info.Size = new System.Drawing.Size(483, 69);
            this.gbo_info.TabIndex = 1;
            this.gbo_info.TabStop = false;
            // 
            // txt_for
            // 
            this.txt_for.Location = new System.Drawing.Point(84, 19);
            this.txt_for.Name = "txt_for";
            this.txt_for.Size = new System.Drawing.Size(209, 20);
            this.txt_for.TabIndex = 0;
            this.txt_for.TextChanged += new System.EventHandler(this.txt_for_TextChanged);
            // 
            // txt_fa
            // 
            this.txt_fa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_fa.Enabled = false;
            this.txt_fa.Location = new System.Drawing.Point(84, 43);
            this.txt_fa.Name = "txt_fa";
            this.txt_fa.Size = new System.Drawing.Size(107, 20);
            this.txt_fa.TabIndex = 1;
            // 
            // txt_data_aq
            // 
            this.txt_data_aq.BackColor = System.Drawing.Color.White;
            this.txt_data_aq.Location = new System.Drawing.Point(410, 19);
            this.txt_data_aq.Name = "txt_data_aq";
            this.txt_data_aq.Size = new System.Drawing.Size(65, 20);
            this.txt_data_aq.TabIndex = 2;
            // 
            // txt_data_in
            // 
            this.txt_data_in.BackColor = System.Drawing.Color.White;
            this.txt_data_in.Location = new System.Drawing.Point(410, 43);
            this.txt_data_in.Name = "txt_data_in";
            this.txt_data_in.Size = new System.Drawing.Size(65, 20);
            this.txt_data_in.TabIndex = 6;
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
            // lbl_fa
            // 
            this.lbl_fa.AutoSize = true;
            this.lbl_fa.Location = new System.Drawing.Point(14, 46);
            this.lbl_fa.Name = "lbl_fa";
            this.lbl_fa.Size = new System.Drawing.Size(46, 13);
            this.lbl_fa.TabIndex = 8;
            this.lbl_fa.Text = "Factura:";
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
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(312, 22);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(97, 13);
            this.lbl_cp.TabIndex = 10;
            this.lbl_cp.Text = "Data de Aquisição:";
            // 
            // gbo_search
            // 
            this.gbo_search.Controls.Add(this.opt_pes_fa);
            this.gbo_search.Controls.Add(this.opt_pes_fe);
            this.gbo_search.Controls.Add(this.txt_pes_fa);
            this.gbo_search.Controls.Add(this.txt_pes_fe);
            this.gbo_search.Location = new System.Drawing.Point(495, 22);
            this.gbo_search.Name = "gbo_search";
            this.gbo_search.Size = new System.Drawing.Size(323, 69);
            this.gbo_search.TabIndex = 2;
            this.gbo_search.TabStop = false;
            // 
            // txt_pes_fe
            // 
            this.txt_pes_fe.Enabled = false;
            this.txt_pes_fe.Location = new System.Drawing.Point(9, 43);
            this.txt_pes_fe.Name = "txt_pes_fe";
            this.txt_pes_fe.Size = new System.Drawing.Size(150, 20);
            this.txt_pes_fe.TabIndex = 11;
            this.txt_pes_fe.TextChanged += new System.EventHandler(this.txt_pes_fe_TextChanged);
            // 
            // txt_pes_fa
            // 
            this.txt_pes_fa.Enabled = false;
            this.txt_pes_fa.Location = new System.Drawing.Point(165, 43);
            this.txt_pes_fa.Name = "txt_pes_fa";
            this.txt_pes_fa.Size = new System.Drawing.Size(150, 20);
            this.txt_pes_fa.TabIndex = 12;
            this.txt_pes_fa.TextChanged += new System.EventHandler(this.txt_pes_fa_TextChanged);
            // 
            // opt_pes_fe
            // 
            this.opt_pes_fe.AutoSize = true;
            this.opt_pes_fe.Location = new System.Drawing.Point(15, 22);
            this.opt_pes_fe.Name = "opt_pes_fe";
            this.opt_pes_fe.Size = new System.Drawing.Size(136, 17);
            this.opt_pes_fe.TabIndex = 13;
            this.opt_pes_fe.TabStop = true;
            this.opt_pes_fe.Text = "Pesquisa P/Ferramenta";
            this.opt_pes_fe.UseVisualStyleBackColor = true;
            this.opt_pes_fe.CheckedChanged += new System.EventHandler(this.opt_pes_fe_CheckedChanged);
            // 
            // opt_pes_fa
            // 
            this.opt_pes_fa.AutoSize = true;
            this.opt_pes_fa.Location = new System.Drawing.Point(179, 22);
            this.opt_pes_fa.Name = "opt_pes_fa";
            this.opt_pes_fa.Size = new System.Drawing.Size(120, 17);
            this.opt_pes_fa.TabIndex = 14;
            this.opt_pes_fa.TabStop = true;
            this.opt_pes_fa.Text = "Pesquisa P/ Família";
            this.opt_pes_fa.UseVisualStyleBackColor = true;
            this.opt_pes_fa.CheckedChanged += new System.EventHandler(this.opt_pes_fa_CheckedChanged);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.opt_pes_for);
            this.Controls.Add(this.btn_clie);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_tools);
            this.Controls.Add(this.btn_for);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.opt_pes_for.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tools)).EndInit();
            this.gbo_info.ResumeLayout(false);
            this.gbo_info.PerformLayout();
            this.gbo_search.ResumeLayout(false);
            this.gbo_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_tools;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_clie;
        private System.Windows.Forms.GroupBox opt_pes_for;
        private System.Windows.Forms.DataGridView dgv_tools;
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
        private System.Windows.Forms.GroupBox gbo_info;
        private System.Windows.Forms.GroupBox gbo_search;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.Label lbl_fa;
        private System.Windows.Forms.Label lbl_for;
        private System.Windows.Forms.TextBox txt_data_in;
        private System.Windows.Forms.TextBox txt_data_aq;
        private System.Windows.Forms.TextBox txt_fa;
        private System.Windows.Forms.TextBox txt_for;
        private System.Windows.Forms.RadioButton opt_pes_fe;
        private System.Windows.Forms.TextBox txt_pes_fa;
        private System.Windows.Forms.TextBox txt_pes_fe;
        private System.Windows.Forms.RadioButton opt_pes_fa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

