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

    //La seguente classe permette di salvare un nuovo elemento nel database
    class SaveElementSql
    {
      public static void Main(ref Guna.UI2.WinForms.Guna2GroupBox gbx, string DataBaseKey, string TableKey, bool NewFan)
        {

            ////Atendo la risposta dal form Warning
            WarningSave f = new WarningSave();
            if (NewFan == false)
            { f.ShowDialog(); }
            

            ////Aggiorno tutte le tabelle con nuovi valori di Default
            if (f.W_ch == true && f.W_ans == true)
            {

                foreach (Control item in gbx.Controls)
                {


                    //Ricerco tra tutte le ComboBox dei vari pannelli
                    if (item is ComboBox)
                    {

                        ComboBox cbx;
                        cbx = (ComboBox)gbx.Controls[item.Name];

                        bool find = false;

                        //Ricerco tra tutti gli elementi della ComboBox
                        for (int i = 0; i < cbx.Items.Count; i++)
                        {

                            string cbx_item = cbx.GetItemText(cbx.Items[i]).Trim();
                            if (cbx.Text.Trim() == cbx_item)
                            {
                                find = true;
                            }

                        }

                        //nel ciclo di ricerca della ComboBox non ho trovato un valore uguale a quello proposto --> lo aggiungo al database
                        if (find == false && cbx.Text.Trim() != "")
                        {
                            SqlConnection con = new SqlConnection(Classi.PublicVar.conn_strDB1 + DataBaseKey + Classi.PublicVar.conn_strDB2);
                            SqlCommand cmd = new SqlCommand("INSERT INTO " + DataBaseKey + ".dbo." + item.Name + "(" + item.Name + ") values(@" + item.Name + ")", con);
                            cmd.Parameters.AddWithValue("@" + item.Name, cbx.Text.Trim());

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

            }

            
            //Salvo una nuova riga database dell'avvolgimento
            if (f.W_ans == true || NewFan == true)

            {
                SqlConnection con = new SqlConnection(Classi.PublicVar.conn_strDB1 + DataBaseKey + Classi.PublicVar.conn_strDB2);
                string SQL_write = "INSERT INTO " + DataBaseKey + ".dbo."+ TableKey +"(DataCreazione, ";
                String SQL_value = " VALUES ('" + Classi.PublicVar.dateTime.ToString("dd/MM/yyyy") + "', ";
                int item_count = 0;
               
                foreach (Control item in gbx.Controls)
                {
                 //Ricerco tra tutte le ComboBox dei vari pannelli
                    if (item is ComboBox)
                    {
                        ComboBox cbx;
                        cbx = (ComboBox)gbx.Controls[item.Name];
                        string cbx_name = cbx.Name;
                        string cbx_sel = cbx.Text;

                        if (item_count < Classi.PublicVar.DB_count - 5)
                        {
                            SQL_write = SQL_write + item.Name + ",";
                            SQL_value = SQL_value + "'" + cbx_sel + "', ";
                        }
                        else
                        {
                            SQL_write = SQL_write + item.Name + ")";
                            SQL_value = SQL_value + "'" + cbx_sel + "')";
                        }

                        item_count++;
                    }



                    //Se l'elemento è una richtextbox
                    if (item is RichTextBox)
                    {
                        RichTextBox rbx;
                        rbx = (RichTextBox)gbx.Controls[item.Name];
                        string rbx_name = rbx.Name;
                        string rbx_sel = rbx.Text;

                        if (item_count < Classi.PublicVar.DB_count - 5)
                        {
                            SQL_write = SQL_write + item.Name + ",";
                            SQL_value = SQL_value + "'" + rbx_sel + "', ";
                        }
                        else
                        {
                            SQL_write = SQL_write + item.Name + ")";
                            SQL_value = SQL_value + "'" + rbx_sel + "')";
                        }

                        item_count++;
                    }
                    
                }
                SQL_write = SQL_write + SQL_value;

                SqlCommand cmd = new SqlCommand(SQL_write, con);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                con.Close();

                if (NewFan == true)
                { PublicVar.NewFan = false; }
                
            }


        }

    }
}
