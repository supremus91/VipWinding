using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using VipWinding.Classi;



namespace VipWinding.Classi
{
    class ShowData
    {
        //La seguente classe inserisce i valori del database nel guna2DataGridView1
        public static void Main(ref Guna.UI2.WinForms.Guna2DataGridView Gtab, string DataBaseKey, string TableKey)
        {
            //rimuovo l'ultima riga della gridview
            PublicVar.con = new SqlConnection(PublicVar.conn_strDB1 + DataBaseKey + PublicVar.conn_strDB2);
            Gtab.AllowUserToAddRows = false;
            PublicVar.dt.Clear();
            PublicVar.adpt = new SqlDataAdapter("select [DataCreazione], [Codice1], [Codice2], [Codice3], [Codice4] from " + TableKey, PublicVar.con);
            PublicVar.adpt.Fill(PublicVar.dt);
            Gtab.DataSource = PublicVar.dt;

        }


    }
}
