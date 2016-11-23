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
    class _Asistencia
    {
        conexion2 cn = new conexion2();
        SqlCommand cmd;

        SqlDataAdapter da;
        public DataTable dt_agenda;
        public DataTable dt_control;



        public void llenar_combo(ComboBox combo)
        {

            cn.cn.Open();
            try
            {
                DataSet dsd = new DataSet();
                da = new SqlDataAdapter("SELECT IdAgenda from Agenda where FechaEvento = '" + Asistencia.fecha + "' "  , cn.cn);
                dt_agenda = new DataTable();
                da.Fill(dt_agenda);
                combo.DataSource = dt_agenda;
                combo.ValueMember = "IdAgenda";
                combo.DisplayMember = "IdAgenda";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }
            cn.cn.Close();
        }

        public void mostrar_por_evento(DataGridView dgv)
        {

            try
            {
                da = new SqlDataAdapter("SELECT Control.Id_Personal, nombre, puesto, asistencia  from Personal inner join Control on Control.Id_Personal = Personal.Id_Personal inner join Cargo on Control.Id_Puesto = Cargo.Id_Puesto where IdAgenda = '" + Asistencia.id_agenda + "' ", cn.cn);
                dt_control = new DataTable();
                da.Fill(dt_control);
                dgv.DataSource = dt_control;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }

        }

        public string registrar_Asistencia(string Asistencia, int id_agenda, int id_personal)
        {
            string insert = "Se registro correctamente";
            cn.cn.Open();

            try
            {
                cmd = new SqlCommand("update Control set Asistencia = '" + Asistencia + "' where IdAgenda ='" + id_agenda + "' AND Id_Personal = '" + id_personal + "' ", cn.cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                insert = e.ToString();
            }
            cn.cn.Close();
            return insert;
        }


    }
}
