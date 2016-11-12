using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.Vistas.UserControls
{
    public partial class Evento : UserControl
    {
        public Evento()
        {
            InitializeComponent();
        }

        Principal cV = new Principal();

        private void _ButtonAgregarEvento_Click(object sender, EventArgs e)
        {
            cV.cambiarVista(new Asignar_Personal());
            
                
         }

      
    }
}
