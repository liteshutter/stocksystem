using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace LiteGears
{
    class ClassCon
    {
        public System.Data.Odbc.OdbcConnection db = new System.Data.Odbc.OdbcConnection();
        public System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
        public System.Data.Odbc.OdbcDataReader dr = null;
        public int pesquisa;

        public void conexao()
        {
            try
            {
                db.Close();
                db.ConnectionString = "DSN=Sis_Stock";
                db.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Há erro com a conexao á Base de Dados");
            }
        }
    }
}
