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

    //La seguente classe serve ad inserire i dati dei codici dal database Codici Fornitori + Database componente
    class LoadDataNewName
    {

        public static void Main(ref Guna.UI2.WinForms.Guna2GroupBox gbx, string DataBaseKey, string Codice1, string Codice2, string Codice3, string Codice4)
        {
            //Compilo le Textbox dei codici provenienti dal database principale
            Guna.UI2.WinForms.Guna2TextBox tbx_Code2;
            tbx_Code2 = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_CodiceVip"];
            tbx_Code2.Text = Codice2;
            Guna.UI2.WinForms.Guna2TextBox tbx_Code3;
            tbx_Code3 = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_CodiceFornitore"];
            tbx_Code3.Text = Codice3;
            Guna.UI2.WinForms.Guna2TextBox tbx_Code4;
            tbx_Code4 = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_Fornitore"];
            tbx_Code4.Text = Codice4;


            //Compilo i fornitori nelle combobox e textbox 
            SqlConnection con = new SqlConnection(Classi.PublicVar.conn_strDB1 + DataBaseKey + Classi.PublicVar.conn_strDB2);

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + DataBaseKey + ".dbo.Fornitori WHERE CodiceVip = '" + Codice1  + "'", con);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();


            int i = 1;
            ComboBox cbx;
            Guna.UI2.WinForms.Guna2TextBox tbx;


            while (sqlReader.Read())
            {
                cbx = (ComboBox)gbx.Controls["cbx_F" + i];
                cbx.Text = sqlReader["Fornitore"].ToString();

                tbx = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_F" + i];
                tbx.Text = sqlReader["CodiceFornitore"].ToString();

                i++;
            }

            sqlReader.Close();



        }

    }
}
