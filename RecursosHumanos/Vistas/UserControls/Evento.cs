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
    public partial class Evento : UserControl
    {

        _Evento evento = new _Evento();
        public static int id_evento;

        public Evento()
        {
            InitializeComponent();
            evento.MostrarEvento(_DGV_Evento);
            _PanelControlEvento.BackColor = Color.FromArgb(0, 0, 0, 0);
        }



        private void _ButtonAgregarEvento_Click(object sender, EventArgs e)
        {

            if (_DGV_Evento.SelectedRows.Count == 1)
            {
                foreach (DataGridViewCell c in _DGV_Evento.SelectedRows[0].Cells)
                {
                    if (c.OwningColumn == _DGV_Evento.Columns["IdAgenda"])
                    {
                        DataRow row;
                        row = evento.dt.Rows[c.RowIndex];
                        id_evento = (int)row["IdAgenda"];


                    }

                }

            }

            Form _Form = new Form();
            Asignar_Personal _Asignar_Personal = new Asignar_Personal();
            _Form.SetBounds(0, 0, _Asignar_Personal.Size.Width + 25, 560);
            _Form.Text = "Asignar Personal";
            _Form.Controls.Add(_Asignar_Personal);
            _Form.ShowDialog();

        }

        private void _ButtonActualizarEvento_Click(object sender, EventArgs e)
        {
            evento.MostrarEvento(_DGV_Evento);
        }
    }
}
