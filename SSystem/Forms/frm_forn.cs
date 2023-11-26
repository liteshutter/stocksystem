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
    public partial class frm_for : Form
    {

        ClassCon cs = new ClassCon();

        public frm_for()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_for.Enabled = true;
            txt_nuit.Enabled = true;
            gbo_cts.Enabled = true;
            gbo_mor.Enabled = true;

            btn_edita.Enabled = true;
            btn_elim.Enabled = true;
            btn_novo.Visible = false;
            btn_save.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_for.Text == "")
            {
                error.SetError(txt_for, "Por favor, Informe pelo menos nome do Fornecedor");
                return;
            }
            else
            {
                error.SetError(txt_for, null);
            }

            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "INSERT INTO Fornecedor (Nome_For, Contacto_For, Telefone_For, Email_For, Nuit_For, Rua_AV_For, Locl_FOR) VALUES('" + txt_for.Text + "', '" + txt_ct.Text + "', '" + txt_tl.Text + "', '" + txt_em.Text + "', '" + txt_nuit.Text + "', '" + txt_ra.Text + "', '" + txt_lc.Text + "')";
            cs.cmd.ExecuteNonQuery();
            MessageBox.Show("Registo gravado com sucesso!!", "LiteGears", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpa_campos();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            cs.conexao();
            String Busca = Interaction.InputBox("Informe o Fornecedor!");
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "SELECT * from Fornecedor where Nome_For like '" + Busca + "'";
            cs.dr = cs.cmd.ExecuteReader();
            if (cs.dr.Read())
            {
                lbl_id.Text = cs.dr["ID_For"].ToString();
                txt_for.Text = cs.dr["Nome_For"].ToString();
                txt_nuit.Text = cs.dr["Nuit_For"].ToString();
                txt_ct.Text = cs.dr["Contacto_For"].ToString();
                txt_tl.Text = cs.dr["Telefone_For"].ToString();
                txt_em.Text = cs.dr["Email_for"].ToString();
                txt_fx.Text = cs.dr["Fax_For"].ToString();
                txt_ra.Text = cs.dr["Rua_AV_For"].ToString();
                txt_lc.Text = cs.dr["Locl_For"].ToString();

                gbo_cts.Enabled = true;
                gbo_mor.Enabled = true;
                txt_for.Enabled = true;
                txt_nuit.Enabled = true;
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

        private void btn_edita_Click(object sender, EventArgs e)
        {
            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "Update Fornecedor set Nome_For = '" + txt_for.Text + "', Nuit_For = '" + txt_nuit.Text + "', Contacto_For = '" + txt_ct.Text + "', Telefone_For = '" + txt_tl.Text + "', Email_for = '" + txt_em.Text + "', Fax_For = '" + txt_fx.Text + "', Rua_AV_For = '" + txt_ra.Text + "', Locl_For = '" + txt_lc.Text + "' where ID_For like '" + lbl_id.Text + "'";
            cs.cmd.ExecuteNonQuery();
            MessageBox.Show("Dados actualizados com sucesso!!", "LiteGears", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpa_campos();
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer realmente deletar este registo???", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cs.conexao();
                cs.cmd.Connection = cs.db;
                cs.cmd.CommandText = "Delete from Fornecedor where ID_For like '" + lbl_id.Text + "'";
                cs.cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Apagados com sucesso");
                limpa_campos();
            }
        }

        private void frm_for_Load(object sender, EventArgs e)
        {
            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "Select * from Fornecedor Order by (ID_For) ASC";
            cs.dr = cs.cmd.ExecuteReader();
            while (cs.dr.Read())
            {
                dgv_fornecedores.Rows.Add(cs.dr["Nome_For"].ToString(), cs.dr["Nuit_For"].ToString(), cs.dr["Contacto_For"].ToString(), cs.dr["Telefone_For"].ToString(), cs.dr["Email_For"].ToString(), cs.dr["Fax_For"].ToString(), cs.dr["Rua_AV_For"].ToString(), cs.dr["Locl_For"].ToString());
            }
        }

        private void limpa_campos()
        {
            txt_for.Clear();
            txt_nuit.Clear();
            txt_ct.Clear();
            txt_em.Clear();
            txt_fx.Clear();
            txt_lc.Clear();
            txt_ra.Clear();
            txt_tl.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_nuit.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_tl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_tl.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_for1_TextChanged(object sender, EventArgs e)
        {
            switch (cs.pesquisa)
            {
                case 0:
                    cs.conexao();
                    cs.cmd.Connection = cs.db;
                    cs.cmd.CommandText = "Select * from Fornecedor where Nome_For like '" + txt_for1.Text + "%' order by (Nome_For) asc";
                    cs.dr = cs.cmd.ExecuteReader();

                    try
                    {
                        dgv_fornecedores.Rows.Clear();
                    }
                    catch
                    {
                        Exception p;
                    }

                    while (cs.dr.Read())
                    {
                        dgv_fornecedores.Rows.Add(cs.dr["Nome_For"].ToString(), cs.dr["Nuit_For"].ToString(), cs.dr["Contacto_For"].ToString(), cs.dr["Email_For"].ToString(), cs.dr["Rua_AV_For"].ToString(), cs.dr["Locl_For"].ToString());
                    }
                    break;
            }
        }

        private void txt_ct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_ct.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
