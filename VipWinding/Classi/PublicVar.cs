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


    //La seguente classe contiene tutte le variabili globali
    public static class PublicVar
    {
        public static string Codice1;
        public static string Codice2;
        public static string Codice3;
        public static string Codice4;
        public static string conn_strDB1 = "Data Source=80.211.16.23;Initial Catalog=";
        public static string conn_strDB2 = ";Persist Security Info=True;User ID = VipAdmin; Password=Vip2010$;TrustServerCertificate=True";
        public static int DB_count = 0;
        public static DateTime dateTime = DateTime.UtcNow.Date;
        public static DataTable dt = new DataTable();
        public static SqlDataAdapter adpt;
        public static SqlConnection con;
        public static Form FormComponent;
        public static bool NewFan;
        
    }

    
}
