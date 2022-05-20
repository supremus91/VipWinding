using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VipWinding.Classi;

namespace VipWinding
{
    public partial class NewName : Form
    {

        public static string DataBaseGen = "VipWinding";
        public static string TableKeyGen = "Fornitori";
        public static string DataBaseKeyN = "";
        public static string Codice1N = "";
        public static string TableKeyN = "";

        public NewName(string Codice1, string TipoComponente, string DataBaseKey, string TableKey, string Codice2, string Codice3, string Codice4)
        {
            InitializeComponent();
            DataBaseKeyN = DataBaseKey;
            Codice1N = Codice1;
            TableKeyN = TableKey;
            this.Text = TipoComponente + " ID " + PublicVar.Codice1;
            ComboboxFillSqlNewName.Main(ref ParGen, DataBaseGen, TableKeyGen);
            LoadDataNewName.Main(ref ParGen, DataBaseKey, Codice1, Codice2, Codice3, Codice4);
            this.Select();
        }


        //-------------------------------------------Gestione visibilità fornitore 2---------------------------------------------
        private void Hide_showF2()
        {
            if ((cbx_F1.SelectedIndex != -1 && tbx_F1.Text != "") || (cbx_F2.SelectedIndex != -1  || tbx_F2.Text != "" || cbx_F3.SelectedIndex != -1  || tbx_F3.Text != "" || cbx_F4.SelectedIndex != -1 || tbx_F4.Text != ""))
            {
                cbx_F2.Visible = true;
                tbx_F2.Visible = true;
                lb2.Visible = true;
                lb6.Visible = true;
            }
            else
            {
                cbx_F2.Visible = false;
                tbx_F2.Visible = false;
                lb2.Visible = false;
                lb6.Visible = false;
            }
        }

        private void cbx_F1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hide_showF2();
        }

        private void tbx_F1_TextChanged(object sender, EventArgs e)
        {
            Hide_showF2();
        }
        //--------------------------------------------------------------------------------------------------------------------------


        //-------------------------------------------Gestione visibilità fornitore 3---------------------------------------------
        private void Hide_showF3()
        {
            if ((cbx_F2.SelectedIndex != -1  && tbx_F2.Text != "") || (cbx_F3.SelectedIndex != -1  || tbx_F3.Text != "" || cbx_F4.SelectedIndex != -1  || tbx_F4.Text != ""))
            {
                cbx_F3.Visible = true;
                tbx_F3.Visible = true;
                lb3.Visible = true;
                lb7.Visible = true;
            }
            else
            {
                cbx_F3.Visible = false;
                tbx_F3.Visible = false;
                lb3.Visible = false;
                lb7.Visible = false;
            }
        }

     
        private void cbx_F2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hide_showF3();
        }

        private void tbx_F2_TextChanged(object sender, EventArgs e)
        {
            Hide_showF3();
        }

    
        //--------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------Gestione visibilità fornitore 4---------------------------------------------
        private void Hide_showF4()
        {
            if ((cbx_F3.SelectedIndex != -1  && tbx_F3.Text != "") || (cbx_F4.SelectedIndex != -1 || tbx_F4.Text != ""))
            {
                cbx_F4.Visible = true;
                tbx_F4.Visible = true;
                lb4.Visible = true;
                lb8.Visible = true;
            }
            else
            {
                cbx_F4.Visible = false;
                tbx_F4.Visible = false;
                lb4.Visible = false;
                lb8.Visible = false;
            }
        }

        

        private void cbx_F3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hide_showF4();
        }

        private void tbx_F3_TextChanged(object sender, EventArgs e)
        {
            Hide_showF4();
        }

        //--------------------------------------------------------------------------------------------------------------------------


        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateNewNameFornitori.Main(ref ParGen, Codice1N, DataBaseKeyN, TableKeyN);
            this.Close();
        }

    }
}
