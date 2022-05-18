using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipWinding.Classi
{

    class CodeChange
    {

      public static void Main(ref Guna.UI2.WinForms.Guna2TextBox tbx, ref Guna.UI2.WinForms.Guna2GroupBox gbx)
        {
            if(tbx.Text == "")
            {
             tbx.Text = "Code" + tbx.Name.Substring(12,1);
            }
         }
    }
}
