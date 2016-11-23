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
    public partial class Asistencia : UserControl
    {

        public static string fecha;
        _Asistencia asistencia = new _Asistencia();
        public static int id_agenda;
        public static int id_personal;
        

        public Asistencia()
        {
            InitializeComponent();
            _ComboBoxEvento.Text = "0";
            _PanelControlAsistencia.BackColor = Color.FromArgb(0, 0, 0, 0);
            
        }

        private void _ButtonAsistencia_Click(object sender, EventArgs e)
        {
            if (_DGV_Asistencia.SelectedRows.Count == 1)
            {
                foreach (DataGridViewCell c in _DGV_Asistencia.SelectedRows[0].Cells)
                {
                    if (c.OwningColumn == _DGV_Asistencia.Columns["id_personal"])
                    {
                        DataRow row;
                        row = asistencia.dt_control.Rows[c.RowIndex];
                        id_personal = (int)row["id_personal"];

                    }

                }

            }

            MessageBox.Show(asistencia.registrar_Asistencia(_ComboBoxAsistencia.Text, id_agenda, id_personal));
            asistencia.mostrar_por_evento(_DGV_Asistencia);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _ComboBoxEvento.Text = "0";
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            fecha = date.ToString("dd/MM/yyyy");
            asistencia.llenar_combo(_ComboBoxEvento);



        }

        private void _ComboBoxEvento_TextChanged(object sender, EventArgs e)
        {
            id_agenda = Convert.ToInt32(_ComboBoxEvento.Text);
            asistencia.mostrar_por_evento(_DGV_Asistencia);
        }

    }
}
