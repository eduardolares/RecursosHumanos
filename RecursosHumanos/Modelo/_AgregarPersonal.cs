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
    class _AgregarPersonal
    {
        

        conexion2 cn = new conexion2();
        SqlCommand cmd;

        SqlDataAdapter da;
        public DataTable dt_personal;
        public DataTable dt_puesto;


        public string agregar_Personal(string Nombre, int Edad, string Telefono, string Sexo, string Correo, string Direccion, string tipo_personal)
        {
            


            cn.cn.Open();
            string insert = "Se Inserto Correctamente";
            try
            {
                cmd = new SqlCommand("INSERT INTO Personal VALUES('" + Nombre + "','" + Edad + "'," + Telefono + ",'" + Sexo + "','" + Correo + "','" + Direccion + "', '" + tipo_personal +"')", cn.cn);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                insert =  e.ToString();
            }
            cn.cn.Close();
            return insert;
        }

        public void MostrarPersonal(DataGridView dgv)
        {
            cn.cn.Open();
            try
            {
                da = new SqlDataAdapter("SELECT * from Personal", cn.cn);
                dt_personal = new DataTable();
                da.Fill(dt_personal);
                dgv.DataSource = dt_personal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }
            cn.cn.Close();
        }

        public string modificar_Personal(string Nombre, int Edad, string Telefono, string Sexo, string Correo, string Direccion, string tipo_personal)
        {
            Personal personal = new Personal();
            cn.cn.Open();
            string insert = "Se modifico Correctamente";
            try
            {
                cmd = new SqlCommand("UPDATE Personal set nombre = '" + Nombre + "', edad = '" + Edad + "', telefono = " + Telefono + ", sexo = '" + Sexo + "', correo = '" + Correo + "', direccion = '" + Direccion + "', tipo_Personal = '" + tipo_personal + "'  where id_personal = '" + Personal.id +"'  ", cn.cn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                insert = e.ToString();
            }
            cn.cn.Close();
            return insert;
        }

        public void llenar_combo(ComboBox combo)
        {
            cn.cn.Open();
            try
            {
                da = new SqlDataAdapter("SELECT id_puesto, puesto from Cargo", cn.cn);
                dt_puesto = new DataTable();
                da.Fill(dt_puesto);
                combo.DataSource = dt_puesto;
                combo.ValueMember = "id_puesto";
               //combo.DisplayMember = "puesto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }
            cn.cn.Close();
        }
    }
}
