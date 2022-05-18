using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VipWinding.Classi
{
    class PictureboxChangeCbx
    {



        public static void Main(ref System.Windows.Forms.ComboBox cbx, ref Guna.UI2.WinForms.Guna2PictureBox pbx, string KeyCbxName)
         {

            pbx.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(KeyCbxName + "_" + cbx.Name);

         }
        
    }
}
