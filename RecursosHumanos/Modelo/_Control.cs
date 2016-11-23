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
    class _Control
    {
        conexion2 cn = new conexion2();
        SqlCommand cmd;

        SqlDataAdapter da;
        public DataTable dt;

        public string agregar_control(int Id_Agenda, int Id_Personal, int Id_Puesto)
        {
            
            cn.cn.Open();
            string insert = "Se añadio correctamente";
            try
            {
                cmd = new SqlCommand("INSERT INTO Control (IdAgenda, Id_Personal, Id_Puesto) VALUES('" + Id_Agenda + "','" + Id_Personal + "','" + Id_Puesto + "')", cn.cn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                insert = e.ToString();
            }
            cn.cn.Close();
            return insert;
        }

        public void mostrar_control(DataGridView dgv)
        {
            cn.cn.Open();
            try
            {
                da = new SqlDataAdapter("SELECT * from Control", cn.cn);
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

        public void mostrar_por_evento(DataGridView dgv)
        {
            cn.cn.Open();
            try
            {
                da = new SqlDataAdapter("SELECT Control.Id_Personal, nombre, puesto  from Personal inner join Control on Control.Id_Personal = Personal.Id_Personal inner join Cargo on Control.Id_Puesto = Cargo.Id_Puesto where IdAgenda = '" + Evento.id_evento+ "' ", cn.cn);
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
