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

    //La seguente classe compila le Combobox di guna2groupbox a partire dalla riga selezionata nella guna2DataGridView1
    //Tale riga identificata da 
    class ComboboxFillSql
    {
       public static void Main(ref Guna.UI2.WinForms.Guna2GroupBox gbx, string DataBaseKey, string TableKey)
        {
           foreach (Control item in gbx.Controls)
            {
                try
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

                            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + DataBaseKey + ".dbo." + cbx_name, sqlConnection);
                            sqlConnection.Open();
                            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                            while (sqlReader.Read())
                            {
                                cbx.Items.Add(sqlReader[cbx_name].ToString());
                            }

                            sqlReader.Close();
                            cbx.SelectedItem = MainForm.TabDB[cbx_name];
                            cbx.Text = MainForm.TabDB[cbx_name].ToString().Trim();

                        }

                        //Ricerco tra tutte le ComboBox dei vari pannelli
                        if (item is RichTextBox)
                        {
                            RichTextBox rbx;
                            rbx = (RichTextBox)gbx.Controls[item.Name];
                            string rbx_name = rbx.Name;
                            rbx.Text = MainForm.TabDB[rbx_name].ToString().Trim();
                        }
                    }

                }
                catch (Exception ex)
                { }

                

                }
    
            }

        }
        
    }

