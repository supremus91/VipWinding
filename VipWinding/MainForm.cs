using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using VipWinding.Classi;

namespace VipWinding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        public static string valuesDB;
        //TabDB contiene i nomi delle colonne delle variabili del database
        public static Hashtable TabDB = new Hashtable();

    
        private void BtnStatore_Click(object sender, EventArgs e)
        {
            try
            {
                Stator formW = new Stator();
                formW.Show();
            }
            catch (Exception ex)
            {
                //In caso di errore chiudo la connessione col database
                PublicVar.con.Close();
            }
        }
    }
    
}
