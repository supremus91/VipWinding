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

namespace VipWinding
{


    public partial class Rotor : Form
    {
        public static string FormName = "Rotor";
        public static string DataBaseKey = "Vip" + FormName + "DB";
        public static string TableKey = "Vip" + FormName;
        public static string TipoComponente = "Rotore";

        public Rotor()
        {
            InitializeComponent();
            ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);

            //Nel caso non ci siano elementi nel database il codice va in errore
            try
            {
                DB_Read_columns();
                ComboboxFillSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey);
            }
            catch (Exception ex)
            { }
            PartName.Text = "";
      
        }

        public void Salva_DB_Click(object sender, EventArgs e)
        {


            if (PublicVar.NewFan == false) // Caso di aggiornamento
            {

                try
                {
                    //Caso in cui la datagrid sia vuota
                    if (Rotor_GridView.Rows.Count == 0)
                    {
                        SaveElementSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey,false);
                        ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);
                    }
                    else
                    {
                        UpdateElement.Main(ref guna2GroupBox1, Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[1].Value.ToString().Trim(), DataBaseKey, TableKey);
                    }

                }
                catch (Exception ex)
                { }

            }
            else // Caso di nuovo componente
            {
                SaveElementSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey,true);
                ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);
            }

            PublicVar.NewFan = false;

        }

        //*********************************Compilo le combobox contenute in guna2groupbox*******************************
        private void Rotor_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DB_Read_columns();
            ComboboxFillSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey);
        }


        private void Rotor_GridView_KeyDown(object sender, KeyEventArgs e)
        {
            DB_Read_columns();
            ComboboxFillSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey);
        }


        private void Rotor_GridView_KeyUp(object sender, KeyEventArgs e)
        {
            DB_Read_columns();
            ComboboxFillSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey);

        }
        //*****************************************************************************************************************


        public void DB_Read_columns()
        {
            try
            {
                if (Rotor_GridView.Rows.Count == 0)
                {
                    ReadColumnsDatabase.Main("0", DataBaseKey, TableKey);
                }
                else
                {
                    ReadColumnsDatabase.Main(Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[1].Value.ToString(), DataBaseKey, TableKey);
                }

            }
            catch (Exception ex)
            { }

        }


        private void btn_Nuovo_Click(object sender, EventArgs e)
        {
            PublicVar.NewFan = true;
            //Atendo la risposta dal form Warning
            WarningNew f = new WarningNew();
            f.ShowDialog();


            if (f.W_ans == false)
            {
                NewElement.Main(ref guna2GroupBox1, ref Rotor_GridView);
                SaveElementSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey,true);
                ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);
            }
            else
            {
                SaveElementSql.Main(ref guna2GroupBox1, DataBaseKey, TableKey,true);
                ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);
            }


        }


        private void btn_Elimina_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteElementSql.Main(Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[1].Value.ToString(), DataBaseKey, TableKey);
            }
            catch (Exception ex)
            { }

            ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);


            //Quando elimino una riga poi seleziono in automatico la prima
            try
            { Rotor_GridView.Rows[0].Selected = true; }
            catch (Exception ex)
            { }

        }
        
        private void MouseHover(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            PictureboxChangeCbx.Main(ref cbx, ref guna2PictureBox1, FormName);
            Label lb;
            lb = (Label)guna2GroupBox1.Controls["lb_" + cbx.Name];
            LabelChangeCbx.Main(ref cbx, ref guna2PictureBox1, ref PartName, lb.Text);
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            PictureboxChangeCbx.Main(ref cbx, ref guna2PictureBox1, FormName);
            Label lb;
            lb = (Label)guna2GroupBox1.Controls["lb_" + cbx.Name];
            LabelChangeCbx.Main(ref cbx, ref guna2PictureBox1, ref PartName, lb.Text);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            PictureboxLeaveCbx.Main(ref guna2PictureBox1, FormName);
            PartName.Text = "";
        }


        private void Tolleranza_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Tolleranza.SelectedItem.ToString().Trim() == "Non-standard")
                {
                    TbxTolerance.Visible = true;
                }
                else
                {
                    TbxTolerance.Text = "";
                    TbxTolerance.Visible = false;
                }

            }
            catch (Exception ex)
            {
                Tolleranza.SelectedItem = "Standard";
                TbxTolerance.Visible = false;
            }


        }


        private void Rotor_GridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Apro l'interfaccia di inserimento nome 
                NewName f1 = new NewName(Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[1].Value.ToString(), TipoComponente, DataBaseKey, TableKey,
                    Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[2].Value.ToString(),
                    Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[3].Value.ToString(),
                Rotor_GridView.Rows[Rotor_GridView.CurrentRow.Index].Cells[4].Value.ToString());

                f1.ShowDialog();
                ShowData.Main(ref Rotor_GridView, DataBaseKey, TableKey);
            }
            catch (Exception ex)
            { }

        }

    }
}
