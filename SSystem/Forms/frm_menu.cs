using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteGears.Forms;

namespace LiteGears
{
    public partial class frm_menu : Form
    {

        ClassCon cs = new ClassCon();

        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "Select * from produtos Order by (ID_Pro) ASC";
            cs.dr = cs.cmd.ExecuteReader();
            while (cs.dr.Read())
            {
                dgv_tools.Rows.Add(cs.dr["artigo"].ToString(), cs.dr["descricao"].ToString(), cs.dr["un"].ToString(), cs.dr["qtd"].ToString(), cs.dr["familia"].ToString(), cs.dr["armazem"].ToString(), cs.dr["preco_un"].ToString(), cs.dr["iva"].ToString(), cs.dr["preco_tl"].ToString(), cs.dr["fornecedor"].ToString(), cs.dr["num_fa"].ToString(), cs.dr["data_in"].ToString(), cs.dr["data_c"].ToString());
            }
        }

        private void dgv_tools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_for.Text = this.dgv_tools.CurrentRow.Cells[9].Value.ToString();
            txt_fa.Text = this.dgv_tools.CurrentRow.Cells[10].Value.ToString();
            txt_data_in.Text = this.dgv_tools.CurrentRow.Cells[11].Value.ToString();
            txt_data_aq.Text = this.dgv_tools.CurrentRow.Cells[12].Value.ToString();
        }

        private void txt_for_TextChanged(object sender, EventArgs e)
        {
            switch (cs.pesquisa)
            {
                case 0:
                    cs.conexao();
                    cs.cmd.Connection = cs.db;
                    cs.cmd.CommandText = "Select * from produtos where Fornecedor like '" + txt_for.Text + "%' order by (Data_in) asc";
                    cs.dr = cs.cmd.ExecuteReader();

                    try
                    {
                        dgv_tools.Rows.Clear();
                    }
                    catch
                    {
                        Exception p;
                    }

                    while (cs.dr.Read())
                    {
                        dgv_tools.Rows.Add(cs.dr["artigo"].ToString(), cs.dr["descricao"].ToString(), cs.dr["un"].ToString(), cs.dr["qtd"].ToString(), cs.dr["familia"].ToString(), cs.dr["armazem"].ToString(), cs.dr["preco_un"].ToString(), cs.dr["iva"].ToString(), cs.dr["preco_tl"].ToString(), cs.dr["fornecedor"].ToString(), cs.dr["num_fa"].ToString(), cs.dr["data_in"].ToString(), cs.dr["data_c"].ToString());
                    }
                    break;
            }
        }

        private void opt_pes_fe_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_pes_fe.Checked == true)
            {
                txt_pes_fe.Enabled = true;
            }
            else
            {
                txt_pes_fe.Enabled = false;
                txt_pes_fe.Clear();
            }
        }

        private void opt_pes_fa_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_pes_fa.Checked == true)
            {
                txt_pes_fa.Enabled = true;
            }
            else
            {
                txt_pes_fa.Enabled = false;
                txt_pes_fa.Clear();
            }
        }

        private void txt_pes_fe_TextChanged(object sender, EventArgs e)
        {
            switch (cs.pesquisa)
            {
                case 0:
                    cs.conexao();
                    cs.cmd.Connection = cs.db;
                    cs.cmd.CommandText = "Select * from produtos where Descricao like '" + txt_pes_fe.Text + "%' order by (Data_in) asc";
                    cs.dr = cs.cmd.ExecuteReader();

                    try
                    {
                        dgv_tools.Rows.Clear();
                    }
                    catch
                    {
                        Exception p;
                    }

                    while (cs.dr.Read())
                    {
                        dgv_tools.Rows.Add(cs.dr["artigo"].ToString(), cs.dr["descricao"].ToString(), cs.dr["un"].ToString(), cs.dr["qtd"].ToString(), cs.dr["familia"].ToString(), cs.dr["armazem"].ToString(), cs.dr["preco_un"].ToString(), cs.dr["iva"].ToString(), cs.dr["preco_tl"].ToString(), cs.dr["fornecedor"].ToString(), cs.dr["num_fa"].ToString(), cs.dr["data_in"].ToString(), cs.dr["data_c"].ToString());
                    }
                    break;
            }
        }

        private void txt_pes_fa_TextChanged(object sender, EventArgs e)
        {
            switch (cs.pesquisa)
            {
                case 0:
                    cs.conexao();
                    cs.cmd.Connection = cs.db;
                    cs.cmd.CommandText = "Select * from produtos where Familia like '" + txt_pes_fa.Text + "%' order by (Data_in) asc";
                    cs.dr = cs.cmd.ExecuteReader();

                    try
                    {
                        dgv_tools.Rows.Clear();
                    }
                    catch
                    {
                        Exception p;
                    }

                    while (cs.dr.Read())
                    {
                        dgv_tools.Rows.Add(cs.dr["artigo"].ToString(), cs.dr["descricao"].ToString(), cs.dr["un"].ToString(), cs.dr["qtd"].ToString(), cs.dr["familia"].ToString(), cs.dr["armazem"].ToString(), cs.dr["preco_un"].ToString(), cs.dr["iva"].ToString(), cs.dr["preco_tl"].ToString(), cs.dr["fornecedor"].ToString(), cs.dr["num_fa"].ToString(), cs.dr["data_in"].ToString(), cs.dr["data_c"].ToString());
                    }
                    break;
            }
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            frm_for frm = new frm_for();
            // frm.ShowDialog();
            frm.Show();
        }

        private void btn_clie_Click(object sender, EventArgs e)
        {
            frm_cliet frm = new frm_cliet();
            frm.Show();
        }

        private void btn_tools_Click(object sender, EventArgs e)
        {
            frm_tools frm = new frm_tools();
            frm.Show();
        }
    }
}
