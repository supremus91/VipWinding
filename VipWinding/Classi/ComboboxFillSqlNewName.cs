using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VipWinding.Classi;

namespace VipWinding.Classi
{

    //La seguente classe serve a riempire le combobox del form NewName. Accede al database dei fornitori.
    class ComboboxFillSqlNewName
    {
       public static void Main(ref Guna.UI2.WinForms.Guna2GroupBox gbx, string DataBaseKey, string TableKey)
        {
            foreach (Control item in gbx.Controls)
            {
                using (SqlConnection sqlConnection = new SqlConnection(PublicVar.conn_strDB1 + DataBaseKey + PublicVar.conn_strDB2))
                {
                    //Ricerco tra tutte le ComboBox dei vari pannelli
                    if (item is ComboBox)
                    {
                        ComboBox cbx;
                        cbx = (ComboBox)gbx.Controls[item.Name];
                        cbx.Items.Clear();

                        string cbx_name = cbx.Name;

                        SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + DataBaseKey + ".dbo.Fornitori", sqlConnection);
                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            cbx.Items.Add(sqlReader["Fornitore"].ToString());
                        }

                        sqlReader.Close();
                    }

                }

            }

        }

    }
}
