using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanos.Vistas.UserControls;

namespace RecursosHumanos.Vistas
{
    public partial class Principal : Form
    {

        public static UserControl VistaActual;
        

        public Principal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _PanelVista.Controls.Remove(VistaActual);
            VistaActual = new Inicio();
            _PanelVista.Controls.Add(VistaActual);
            this.Text = "Inicio";


        }


        public void cambiarVista(UserControl vista)
        {
            _PanelVista.Controls.Remove(VistaActual);
            VistaActual = vista;
            _PanelVista.Controls.Add(VistaActual);
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVista(new Personal());
            this.Text = "Personal";
            
            
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVista(new Evento());
            this.Text = "Eventos";
           
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVista(new Asistencia());
            this.Text = "Asistencia"; 
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVista(new Nomina());
            this.Text = "Nomina";
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVista(new Inicio());
            this.Text = "Inicio";
        }
    }
}
