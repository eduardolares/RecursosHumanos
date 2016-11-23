using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanos.Modelo;

namespace RecursosHumanos.Vistas.UserControls
{
    public partial class Asignar_Personal : UserControl
    {

        _AgregarPersonal agregar_personal = new _AgregarPersonal();
        _Control control = new _Control();

        public static int id_personal;
        

        public Asignar_Personal()
        {
            InitializeComponent();
            agregar_personal.MostrarPersonal(_DGV_PersonalAsignar);
            agregar_personal.llenar_combo(_ComboBoxPuesto);
            control.mostrar_por_evento(_DGV_PersonalEvento);

        }

        private void _ButtonAgregarEvento_Click(object sender, EventArgs e)
        {
            
            if (_DGV_PersonalAsignar.SelectedRows.Count == 1)
            {
                foreach (DataGridViewCell c in _DGV_PersonalAsignar.SelectedRows[0].Cells)
                {
                    if (c.OwningColumn == _DGV_PersonalAsignar.Columns["id_personal"])
                    {
                        DataRow row;
                        row = agregar_personal.dt_personal.Rows[c.RowIndex];
                        id_personal = (int)row["id_personal"];

                    }

                }

            }

            MessageBox.Show(control.agregar_control(Evento.id_evento, id_personal, Convert.ToInt32(_ComboBoxPuesto.Text)));
            control.mostrar_por_evento(_DGV_PersonalEvento);
        }

    }
}
