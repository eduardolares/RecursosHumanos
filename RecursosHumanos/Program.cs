using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanos.Vistas;

namespace RecursosHumanos
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
            var result = (new Login()).ShowDialog();
            if (result == DialogResult.Yes)
            {
                Application.Run(new Principal());
            }
        }

       
    }
}
