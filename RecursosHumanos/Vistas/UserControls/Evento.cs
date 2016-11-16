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
            Form _Form = new Form();
            Asignar_Personal _Asignar_Personal = new Asignar_Personal();
            _Form.SetBounds(0, 0, _Asignar_Personal.Size.Width + 25, 450);
            _Form.Text = "Asignar Personal";
            _Form.Controls.Add(_Asignar_Personal);
            _Form.ShowDialog();
            

        }

      
    }
}
