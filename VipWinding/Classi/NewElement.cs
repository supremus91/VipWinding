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

namespace VipWinding.Classi
{

    //La seguente classe gestisce la creazione di un nuovo avvolgimento
    class NewElement
    {
        public static void Main(ref Guna.UI2.WinForms.Guna2GroupBox gbx, ref Guna.UI2.WinForms.Guna2DataGridView dtg)
        {

            foreach (Control item in gbx.Controls)
            {

                //Ricerco tra tutte le ComboBox dei vari pannelli
                if (item is ComboBox)
                {

                    ComboBox cbx;
                    cbx = (ComboBox)gbx.Controls[item.Name];

                    cbx.SelectedIndex = -1;
                    cbx.Text = "";
                    dtg.ClearSelection();

                    if (cbx.Name == "Tolleranza")
                    { cbx.Text = "Standard"; }

                }
            
                //Ricerco tra tutte le ComboBox dei vari pannelli
                if (item is RichTextBox)
                {
                    RichTextBox tbx;
                    tbx = (RichTextBox)gbx.Controls[item.Name];
                    tbx.Text = "";
                    tbx.Visible = false;
                }

            }

        }





}

}
