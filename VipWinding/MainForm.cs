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

    
        private void Btn_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            try
            {
               if (PublicVar.FormComponent != null)
                { PublicVar.FormComponent.Close(); }

                Type type = Type.GetType("VipWinding." + btn.Name);
                PublicVar.FormComponent = (Form)Activator.CreateInstance(type);
                PublicVar.FormComponent.Show();

            }
            catch (Exception ex)
            {
                //In caso di errore chiudo la connessione col database
                PublicVar.con.Close();
            }

        }

    }
    
}
