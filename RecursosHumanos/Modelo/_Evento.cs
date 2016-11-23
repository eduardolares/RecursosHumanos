using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using RecursosHumanos.Controlador;
using RecursosHumanos.Vistas.UserControls;
using System.Windows.Forms;

namespace RecursosHumanos.Modelo
{
    class _Evento
    {

        conexion2 cn = new conexion2();
        SqlCommand cmd;

        SqlDataAdapter da;
        public DataTable dt;

        public void MostrarEvento(DataGridView dgv)
        {
            cn.cn.Open();
            try
            {
                da = new SqlDataAdapter("SELECT * from Agenda", cn.cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;





            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }
            cn.cn.Close();
        }


    }
}
