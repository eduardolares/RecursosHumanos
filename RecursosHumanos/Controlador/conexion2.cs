using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RecursosHumanos.Controlador
{
    class conexion2
    {

       public SqlConnection cn = new System.Data.SqlClient.SqlConnection("Data Source=192.168.1.3;User ID=yanez; Password=yanez; Initial Catalog=RH");
        SqlCommand cmd;

        SqlDataAdapter da;
        DataTable dt;

                

    }
}
