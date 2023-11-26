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
    public partial class frm_cliet : Form
    {

        ClassCon cs = new ClassCon();

        public frm_cliet()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_cli.Enabled = true;
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
            if (txt_cli.Text == "")
            {
                error.SetError(txt_cli, "Por favor, Informe pelo menos nome do Cliente");
                return;
            }
            else
            {
                error.SetError(txt_cli, null);
            }

            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "INSERT INTO Cliente (Nome_Cli, Contacto_Cli, Email_Cli, Nuit_Cli, Rua_AV_Cli, Locl_Cli) VALUES('" + txt_cli.Text + "', '" + txt_ct.Text + "', '" + txt_em.Text + "', '" + txt_nuit.Text + "', '" + txt_ra.Text + "', '" + txt_lc.Text + "')";
            cs.cmd.ExecuteNonQuery();
            MessageBox.Show("Registo gravado com sucesso!!", "LiteGears", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpa_campos();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            cs.conexao();
            String Busca = Interaction.InputBox("Informe o Cliente!");
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "SELECT * from Cliente where Nome_Cli like '" + Busca + "'";
            cs.dr = cs.cmd.ExecuteReader();
            if (cs.dr.Read())
            {
                lbl_id.Text = cs.dr["ID_Cli"].ToString();
                txt_cli.Text = cs.dr["Nome_Cli"].ToString();
                txt_nuit.Text = cs.dr["Nuit_Cli"].ToString();
                txt_ct.Text = cs.dr["Contacto_Cli"].ToString();
                txt_em.Text = cs.dr["Email_Cli"].ToString();
                txt_ra.Text = cs.dr["Rua_AV_Cli"].ToString();
                txt_lc.Text = cs.dr["Locl_Cli"].ToString();

                gbo_cts.Enabled = true;
                gbo_mor.Enabled = true;
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
            cs.cmd.CommandText = "Update Cliente set Nome_Cli = '" + txt_cli.Text + "', Nuit_Cli = '" + txt_nuit.Text + "', Contacto_Cli = '" + txt_ct.Text + "', Email_Cli = '" + txt_em.Text + "', Rua_AV_Cli = '" + txt_ra.Text + "', Locl_Cli = '" + txt_lc.Text + "' where ID_Cli like '" + lbl_id.Text + "'";
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
                cs.cmd.CommandText = "Delete from Cliente where ID_Cli like '" + lbl_id.Text + "'";
                cs.cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Apagados com sucesso");
                limpa_campos();
            }
        }

        private void frm_cliet_Load(object sender, EventArgs e)
        {
            cs.conexao();
            cs.cmd.Connection = cs.db;
            cs.cmd.CommandText = "Select * from Cliente Order by (ID_Cli) ASC";
            cs.dr = cs.cmd.ExecuteReader();
            while (cs.dr.Read())
            {
                dgv_client.Rows.Add(cs.dr["Nome_Cli"].ToString(), cs.dr["Nuit_Cli"].ToString(), cs.dr["Contacto_Cli"].ToString(), cs.dr["Email_Cli"].ToString(), cs.dr["Rua_AV_Cli"].ToString(), cs.dr["Locl_Cli"].ToString());
            }
        }
        private void limpa_campos()
        {
            txt_cli.Clear();
            txt_nuit.Clear();
            txt_ct.Clear();
            txt_em.Clear();
            txt_lc.Clear();
            txt_ra.Clear();
        }

        private void txt_for1_TextChanged(object sender, EventArgs e)
        {
            switch (cs.pesquisa)
            {
                case 0:
                    cs.conexao();
                    cs.cmd.Connection = cs.db;
                    cs.cmd.CommandText = "Select * from Cliente where Nome_Cli like '" + txt_for1.Text + "%' order by (Nome_Cli) asc";
                    cs.dr = cs.cmd.ExecuteReader();

                    try
                    {
                        dgv_client.Rows.Clear();
                    }
                    catch
                    {
                        Exception p;
                    }

                    while (cs.dr.Read())
                    {
                        dgv_client.Rows.Add(cs.dr["Nome_Cli"].ToString(), cs.dr["Nuit_Cli"].ToString(), cs.dr["Contacto_Cli"].ToString(), cs.dr["Email_Cli"].ToString(), cs.dr["Rua_AV_Cli"].ToString(), cs.dr["Locl_Cli"].ToString());
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
