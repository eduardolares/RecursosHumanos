using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecursosHumanos.Modelo;
using System.Windows.Forms;

namespace RecursosHumanos.Vistas.UserControls
{
    public partial class Personal : UserControl
    {
        enum Accion { Agregar, Modificar}
        Accion _Accion;
        _AgregarPersonal agregar_Personal = new _AgregarPersonal();
        
        string r;
        public static int id;

        public Personal()
        {
            InitializeComponent();
            agregar_Personal.MostrarPersonal(_DGV_Personal);
            Dock = DockStyle.Fill;

        }

        private void _ButtonAgregar_Click(object sender, EventArgs e)
        {
            _Accion = Accion.Agregar;
            _PanelFormulario.Visible = true;
            _ButtonAccion.Text = "Agregar";
            limpiarFormulario();


        }

        private void actualizar()
        {

        }

        private void _ButtonActualizar_Click(object sender, EventArgs e)
        {
            agregar_Personal.MostrarPersonal(_DGV_Personal);
        }

        private void _ButtonAccion_Click(object sender, EventArgs e)
        {
            switch (_Accion)
            {
                case Accion.Agregar:                    
                    MessageBox.Show(agregar_Personal.agregar_Personal(_TextBoxNombre.Text, Convert.ToInt32(_TextBoxEdad.Text), _TextBoxTelefono.Text, _ComboBoxSexo.Text, _TextBoxCorreo.Text, _TextBoxDireccion.Text));
                    agregar_Personal.MostrarPersonal(_DGV_Personal);
                    limpiarFormulario();
                    break;

                case Accion.Modificar:
                    MessageBox.Show(agregar_Personal.modificar_Personal(_TextBoxNombre.Text, Convert.ToInt32(_TextBoxEdad.Text), _TextBoxTelefono.Text, _ComboBoxSexo.Text, _TextBoxCorreo.Text, _TextBoxDireccion.Text));
                    agregar_Personal.MostrarPersonal(_DGV_Personal);
                    limpiarFormulario();                    
                    break;

            }
            
        }

        public void limpiarFormulario()
        {
            foreach (Control c in _PanelFormulario.Controls)
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

        private void _ButtonModificar_Click(object sender, EventArgs e)
        {
            _Accion = Accion.Modificar;
            _ButtonAccion.Text = "Modificar";
            cargar_Formulario();
            _PanelFormulario.Visible = true;
        }

        public void cargar_Formulario()
        {
            limpiarFormulario();
            if (_DGV_Personal.SelectedRows.Count == 1)
            {
                foreach (DataGridViewCell c in _DGV_Personal.SelectedRows[0].Cells)
                {
                    if (c.OwningColumn == _DGV_Personal.Columns["nombre"])
                    {
                        DataRow row;
                        row = agregar_Personal.dt.Rows[c.RowIndex];
                        id = (int)row["id_personal"];
                        _TextBoxNombre.Text = row["nombre"].ToString();
                        _TextBoxEdad.Text = row["edad"].ToString();
                        _TextBoxTelefono.Text = row["telefono"].ToString();
                        _ComboBoxSexo.Text = row["sexo"].ToString();
                        _TextBoxCorreo.Text = row["correo"].ToString();
                        _TextBoxDireccion.Text = row["direccion"].ToString();

                    }
                }

            }
        }

        private void _DGV_Personal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            
            if (_Accion == Accion.Modificar)
            {
                if (e.RowIndex != -1)
                {
                    cargar_Formulario();
                }
            }

        }
    }
}
