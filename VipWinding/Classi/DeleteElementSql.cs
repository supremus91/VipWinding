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

        public static void Main(String cod1, String cod2, String cod3, String cod4, String DataBase, String TableName)
        {

            //Atendo la risposta dal form Warning
            WarningDel f = new WarningDel();
            f.ShowDialog();

            //Salvo una nuova riga database dell'avvolgimento
            if (f.W_ans == true)
            {
                string sql = "DELETE FROM " + TableName + " WHERE Codice1 = '" + cod1 + "' AND " + "Codice2 = '" + cod2 + "' AND " + "Codice3 = '" + cod3 + "' AND " + "Codice4 = '" + cod4 + "'";

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

            }
                

        }


      }
}
