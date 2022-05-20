using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace VipWinding.Classi
{

    //La seguente classe permette di eliminare una riga da una tabella del SQL
    class DeleteElementSql
    {

        public static void Main(String Codice1, String DataBase, String TableName)
        {

            //Atendo la risposta dal form Warning
            WarningDel f = new WarningDel();
            f.ShowDialog();

            //Processo di cancellazione riga dal database
            if (f.W_ans == true)
            {

                //Cancello una nuova riga database dell'avvolgimento
                string sql = "DELETE FROM " + TableName + " WHERE Codice1 = '" + Codice1 + "'";

                SqlConnection con = new SqlConnection(PublicVar.conn_strDB1 + DataBase + PublicVar.conn_strDB2);
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                con.Close();

                

                //Cancello una nuova riga database dell'avvolgimento
               sql = "DELETE FROM " + DataBase + ".dbo.Fornitori WHERE CodiceVip = '" + Codice1 + "'";
               SqlCommand cmd1 = new SqlCommand(sql, con);

                con.Open();

                try
                {
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                con.Close();

            }
                

        }


      }
}
