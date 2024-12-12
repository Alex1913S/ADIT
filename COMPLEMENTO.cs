using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SOFTWARE_INVENTARIO
{
    class COMPLEMENTO
    {
        public static void PCEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Compara s i la tecla presionada es Enter u otra
            {
                e.Handled = true; SendKeys.Send("{TAB}"); //Permite la funcion de pasar con ENTER como su fuera TAB
            }
        }

        public static void Recibefoco(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox txt = sender as TextBox; txt.BackColor = Color.PaleTurquoise;
            }
            if (sender is ComboBox)
            {
                ComboBox txt = sender as ComboBox; txt.BackColor = Color.PaleTurquoise; // Color
            }
        }

        public static void Pierdefoco(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox txt = sender as TextBox; txt.BackColor = Color.Silver;
                txt.Text = txt.Text.Trim(); txt.Text.ToUpper();
            }
            if (sender is ComboBox)
            {
                ComboBox txt = sender as ComboBox; txt.BackColor = Color.Silver;
            }
        }
    }
}
