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
        public DataTable dt;

        public string agregar_Personal(string Nombre, int Edad, string Telefono, string Sexo, string Correo, string Direccion)
        {
            


            cn.cn.Open();
            string insert = "Se Inserto Correctamente";
            try
            {
                cmd = new SqlCommand("INSERT INTO Personal VALUES('" + Nombre + "','" + Edad + "'," + Telefono + ",'" + Sexo + "','" + Correo + "','" + Direccion + "')", cn.cn);
                
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

        //public string id_personal()
        //{
        //    cn.cn.Open();
            
        //    return ;
        //}

        public string modificar_Personal(string Nombre, int Edad, string Telefono, string Sexo, string Correo, string Direccion)
        {
            Personal personal = new Personal();
            cn.cn.Open();
            string insert = "Se modifico Correctamente";
            try
            {
                cmd = new SqlCommand("UPDATE Personal set nombre = '" + Nombre + "', edad = '" + Edad + "', telefono = " + Telefono + ", sexo = '" + Sexo + "', correo = '" + Correo + "', direccion = '" + Direccion + "'  where id_personal = '" + Personal.id +"'  ", cn.cn);

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
