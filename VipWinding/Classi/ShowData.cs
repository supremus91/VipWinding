using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using VipWinding.Classi;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;



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

            Gtab.EnableHeadersVisualStyles = true;
            Gtab.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 65, 127); ;
            Gtab.DefaultCellStyle.SelectionForeColor = Color.White;

            Gtab.Columns[0].HeaderCell.Value = "Data di creazione";
            Gtab.Columns[1].HeaderCell.Value = "ID";
            Gtab.Columns[2].HeaderCell.Value = "Codice Vip";
            Gtab.Columns[3].HeaderCell.Value = "Descrizione";
            Gtab.Columns[4].HeaderCell.Value = "Part Number";



            for (int i = 0; i <=4; i++)
            {
                Gtab.Columns[i].HeaderCell.Style.Font = new Font("Segoe", 9.75F, FontStyle.Regular);
                Gtab.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(213, 218, 223);
                Gtab.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
            }


        }


    }
}
