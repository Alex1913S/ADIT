using SOFTWARE_INVENTARIO.FORMULARIOS_ADMINISTRADOR;
using SOFTWARE_INVENTARIO.FORMULARIOS_SEGUNDARIOS;
using SOFTWARE_INVENTARIO.FORMULARIOS_TERCIARIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWARE_INVENTARIO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LOGIN ());
        }
    }
}
