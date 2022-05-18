using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace VipWinding.Classi
{
    //CLASSE UTILIZZATA PER LEGGERE e SALVARE I DATI PRELEVATI DAL SERVER IN UNA LISTA
    //1) La classe richiede in ingresso cod1, cod2, cod3, cod4 e il nome della tabella da cui attingere
    class ReadColumnsDatabase
    {


        public static void Main(String cod1, String cod2, String cod3, String cod4, String DataBase, String TableName)
        {
            
            SqlConnection con = new SqlConnection(PublicVar.conn_strDB1 + DataBase + PublicVar.conn_strDB2);
            //Ottengo la lista dei nomi delle colonne del database ArchivioW
            string[] restrictions = new string[4] { null, null, TableName, null };
            con.Open();
            var columnList = con.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();
            con.Close(); 

            //Definisco la stringa di connessione al database
            string sql = @"SELECT ";
            
            PublicVar.Codice1 = cod1;
            PublicVar.Codice2 = cod2;
            PublicVar.Codice3 = cod3;
            PublicVar.Codice4 = cod4;
                
     
            //Ciclo for per prelevare i nomi delle colonne del Database
            MainForm.TabDB.Clear();
            for (int i = 1; i <= columnList.Count - 1; i++)
            {
                MainForm.TabDB.Add(columnList[i], "");

                //Composizione stringa di comuniczione col Database
                if (i < columnList.Count - 1)
                {
                    sql = sql + columnList[i] + ",";
                }
                else
                {
                    sql = sql + columnList[i] + " FROM " + TableName + " WHERE Codice1 = '" + PublicVar.Codice1 
                        + "' AND " + "Codice2 = '" + PublicVar.Codice2 
                        + "' AND " + "Codice3 = '" + PublicVar.Codice3 
                        + "' AND " + "Codice4 = '" + PublicVar.Codice4 + "'";
                }
                PublicVar.DB_count = columnList.Count - 1;

            }



            //Ottengo i dati dal database mediante il comando sql dalla Hastable
            using (var command = new SqlCommand(sql, con))
            {
                con.Open();
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    //Salvo i dati prelevati dal databse all'interno della lista
                    for (int i = 1; i <= columnList.Count - 1; i++)
                    {
                        try
                        {
                            MainForm.TabDB[columnList[i]] = reader[columnList[i]].ToString();
                        }
                        catch (Exception ex)
                        {
                            MainForm.TabDB[columnList[i]] = "";
                        }

                    }

                }

            }

            con.Close();

        }
     }
 }