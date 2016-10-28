using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecursosHumanos.Modelo;
using RecursosHumanos.Vistas.UserControls;
using System.Windows.Forms;

namespace RecursosHumanos.Vistas.UserControls
{
    public partial class AgregarPersonal : UserControl
    {

        public AgregarPersonal()
        {
            InitializeComponent();
        }

        private void _ButtonAceptar_Click(object sender, EventArgs e)
        {
            _AgregarPersonal agregar_Personal = new _AgregarPersonal();
            Personal personal = new Personal();
            MessageBox.Show(agregar_Personal.agregar_Personal(_TextBoxNombre.Text, Convert.ToInt32(_TextBoxEdad.Text), _TextBoxTelefono.Text, _TextBoxSexo.Text, _TextBoxCorreo.Text, _TextBoxDireccion.Text));


            _TextBoxNombre.Text = "";
            _TextBoxEdad.Text = "";
            _TextBoxTelefono.Text = "";
            _TextBoxSexo.Text = "";
            _TextBoxCorreo.Text = "";
            _TextBoxDireccion.Text = "";
            
        }

        private void _ButtonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
