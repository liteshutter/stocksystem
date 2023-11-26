using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LiteGears.Forms
{
    public partial class frm_tools : Form
    {

        ClassCon cs = new ClassCon();

        decimal iva = Convert.ToDecimal(0.17); 
        decimal pr_t;
        decimal pr;
        string ivaa;
        public frm_tools()
        {
            InitializeComponent();
        }

        private void cbo_for_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbx_iva_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_iva.Checked == true)
            {
                //iva = Convert.ToInt32(0.17);
                //ivaa = iva * 100;
                //qtd = Convert.ToDouble(txt_qtd.Text);
                pr = Convert.ToDecimal(txt_pre_un.Text);
                pr_t = (pr * iva + pr);// * qtd;
                txt_pr_t.Text = Convert.ToString(pr_t);
                ivaa = "17%";
            }
            else
            {
                pr_t = pr;
                txt_pre_un.Text = Convert.ToString(pr_t);
                ivaa = "0%";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //pr = Convert.ToInt32(txt_pre_un.Text);
            //pr_t = pr * iva;

            if (txt_artigo.Text == "")
            {
                error.SetError(txt_artigo, "Por favor, Informe pelo menos nome do Fornecedor");
                return;
            }
            else
            {
                error.SetError(txt_artigo, null);
            }

            if (txt_desc.Text == "")
            {
                error.SetError(txt_desc, "Por favor, Informe pelo menos nome do Fornecedor");
                return;
            }
            else
            {
                error.SetError(txt_desc, null);
            }

            if (txt_qtd.Text == "")
            {
                error.SetError(txt_qtd, "Por favor, Informe pelo menos nome do Fornecedor");
                return;
            }
            else
            {
                error.SetError(txt_qtd, null);
            }


            dgv_tools.Rows.Add(txt_artigo.Text, txt_desc.Text, cbo_un.Text, txt_qtd.Text, txt_fam.Text, txt_armazem.Text, txt_pre_un.Text, ivaa, pr_t, cbo_for.Text, txt_fa.Text, dtp_ii.Text, dtp_c.Text);

            txt_artigo.Clear();
            txt_desc.Clear();
            cbo_un.SelectedIndex = -1;
            txt_fam.Clear();
            txt_armazem.Clear();
            txt_qtd.Clear();
            txt_pre_un.Clear();
            txt_pr_t.Clear();

        }

        private void cbo_iva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            gbo_all.Enabled = true;

            btn_edita.Enabled = true;
            btn_elim.Enabled = true;
            btn_novo.Visible = false;
            btn_save.Enabled = true;
        }

        private void frm_tools_Load(object sender, EventArgs e)
        {
            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "Select Nome_for from Fornecedor Order By ID_For";
            cs.dr = cs.cmd.ExecuteReader();
            while (cs.dr.Read())
            {
                cbo_for.Items.Add(cs.dr["Nome_for"].ToString());
            }
        }

        private void txt_qtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_qtd.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_pre_un_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*char ch = e.KeyChar;

            if (ch == 46 && txt_pre_un.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }*/
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_tools.Rows.Count; i++)
            {
                cs.conexao();
                cs.cmd.Connection = cs.db;
                cs.cmd.CommandText = "Insert into Produtos(Fornecedor, Num_fa, data_c, data_in, Artigo, Descricao, un, Qtd, familia, armazem, preco_un, iva, preco_tl) Values('" + dgv_tools.Rows[i].Cells["Column10"].Value + "', '" + dgv_tools.Rows[i].Cells["Column11"].Value + "', '" + Convert.ToDateTime(dtp_c.Text).ToString("yyyy-MM-dd") + "', '" + Convert.ToDateTime(dtp_ii.Text).ToString("yyyy-MM-dd") + "', '" + dgv_tools.Rows[i].Cells["Column1"].Value + "', '" + dgv_tools.Rows[i].Cells["Column2"].Value + "', '" + dgv_tools.Rows[i].Cells["Column3"].Value + "', '" + dgv_tools.Rows[i].Cells["Column4"].Value + "', '" + dgv_tools.Rows[i].Cells["Column5"].Value + "', '" + dgv_tools.Rows[i].Cells["Column6"].Value + "', '" + Convert.ToDecimal(dgv_tools.Rows[i].Cells["Column7"].Value) + "', '" + dgv_tools.Rows[i].Cells["Column8"].Value + "', '" + Convert.ToDecimal(dgv_tools.Rows[i].Cells["Column9"].Value) + "')";
                cs.cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Produto(s) Registados(s) com Sucesso!!", "LiteGears", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                dgv_tools.Rows.Clear();
            }
            catch
            {
                Exception p;
            }

            limpa_campos();

        }

        private void limpa_campos()
        {
            cbo_for.SelectedIndex = -1;
            txt_fa.Clear();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            cs.conexao();
            String Busca = Interaction.InputBox("Informe o artigo!");
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "SELECT * from Produtos where Artigo like '" + Busca + "'";
            cs.dr = cs.cmd.ExecuteReader();
            if (cs.dr.Read())
            {
                cbo_for.Text = cs.dr["Fornecedor"].ToString();
                txt_fa.Text = cs.dr["Num_Fa"].ToString();
                dtp_c.Text = cs.dr["Data_C"].ToString();
                dtp_ii.Text = cs.dr["Data_In"].ToString();
                txt_artigo.Text = cs.dr["Artigo"].ToString();
                txt_desc.Text = cs.dr["Descricao"].ToString();
                cbo_un.Text = cs.dr["Un"].ToString();
                txt_fam.Text = cs.dr["Familia"].ToString();
                txt_armazem.Text = cs.dr["Armazem"].ToString();
                txt_qtd.Text = cs.dr["qtd"].ToString();
                txt_pre_un.Text = cs.dr["preco_un"].ToString();
                txt_pr_t.Text = cs.dr["preco_tl"].ToString();
                lbl_id_p.Text = cs.dr["ID_Pro"].ToString();

                gbo_all.Enabled = true;
                btn_novo.Enabled = true;
                btn_save.Enabled = false;
                btn_edita.Enabled = true;
                btn_elim.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registo não encontrado!!", "LiteGears", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpa_campos();
            }
        }
    }
}
