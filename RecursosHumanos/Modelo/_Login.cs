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
    class _Login
    {
        conexion2 cn = new conexion2();
        SqlCommand cmd;
        SqlDataAdapter da;
        public DataTable dt_login;

        public void login ()
        {
            cn.cn.Open();
            try
            {
                da = new SqlDataAdapter("SELECT Usuario, Password from Login", cn.cn);
                dt_login = new DataTable();
                da.Fill(dt_login);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla" + ex.ToString());
            }
            cn.cn.Close();
        }


    }
}
