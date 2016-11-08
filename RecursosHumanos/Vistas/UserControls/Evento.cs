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

  

        private void _ButtonAgregarEvento_Click(object sender, EventArgs e)
        {
            _PanelFormularioEvento.Visible = true;
            _ButtonAccionEvento.Text = "Agregar";
            limpiarFormulario();
        }

        public void limpiarFormulario()
        {
            foreach (Control c in _PanelFormularioEvento.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    ((TextBox)c).Enabled = true;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }
        }
    }
}
