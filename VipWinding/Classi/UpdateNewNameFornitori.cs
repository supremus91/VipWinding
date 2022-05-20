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

    //La seguente classe serve ad aggiornare i dati nel database dei fornitori
    class UpdateNewNameFornitori
    {
        public static void Main(ref Guna.UI2.WinForms.Guna2GroupBox gbx, String code1, String DataBaseKey, string TableKey)
        {

            //Cancello tutti  i record esistenti del componente con ID code1
            string sql = "DELETE FROM " + DataBaseKey + ".dbo.Fornitori" + " WHERE CodiceVip = '" + code1 + "'";

            SqlConnection con = new SqlConnection(Classi.PublicVar.conn_strDB1 + DataBaseKey + Classi.PublicVar.conn_strDB2);
            SqlCommand cmdDEL = new SqlCommand(sql, con);

            con.Open();

            try
            {
                cmdDEL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            con.Close();

            
            foreach (Control item in gbx.Controls)
            {
              //Ricerco tra tutte le ComboBox dei vari pannelli
                if (item is ComboBox)
                {
                    ComboBox cbx;
                    cbx = (ComboBox)gbx.Controls[item.Name];
                    Guna.UI2.WinForms.Guna2TextBox tbx;
                    tbx = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_" + item.Name.Substring(4, item.Name.Length -4)];
                    
                    if (cbx.SelectedIndex != -1 && tbx.Text.Trim() != "")
                    {
                     //Aggiungo i codici nel database
                       
                      SqlCommand cmd = new SqlCommand("INSERT INTO " + DataBaseKey + ".dbo.Fornitori" + "(CodiceVip, CodiceFornitore, Fornitore) values(@CodiceVip, @CodiceFornitore, @Fornitore)", con);
                      cmd.Parameters.AddWithValue("@CodiceVip", code1);
                      cmd.Parameters.AddWithValue("@CodiceFornitore", tbx.Text );
                      cmd.Parameters.AddWithValue("@Fornitore", cbx.SelectedItem.ToString().Trim());

                      con.Open();

                      try
                      {
                       cmd.ExecuteNonQuery();
                      }
                      catch (Exception ex)
                      {

                      }
                      con.Close();
                       
                    }
               
                }

            }

            
            //Aggiorno i codici nel Database complessivo del componente
            Guna.UI2.WinForms.Guna2TextBox tbx1;
            tbx1 = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_CodiceVip"];
            Guna.UI2.WinForms.Guna2TextBox tbx2;
            tbx2 = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_CodiceFornitore"];
            Guna.UI2.WinForms.Guna2TextBox tbx3;
            tbx3 = (Guna.UI2.WinForms.Guna2TextBox)gbx.Controls["tbx_Fornitore"];


            string SQL_update = "UPDATE " + DataBaseKey + ".dbo." + TableKey + " SET ";
            string SQL_write = "";
            string SQL_where = " WHERE Codice1 = '" + code1 + "'";
            string SQL_new = " Codice2 = '" + tbx1.Text + "', " + " Codice3 = '" + tbx2.Text + "', "+ " Codice4 = '" + tbx3.Text + "'";

            SQL_update = SQL_update + SQL_write + SQL_new+ SQL_where;
           
            
            SqlCommand cmdN = new SqlCommand(SQL_update, con);

            con.Open();

            try
            {
                cmdN.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            con.Close();


            
        }


    }
}
