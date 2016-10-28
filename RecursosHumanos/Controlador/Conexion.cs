using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.Controlador
{
    class Conexion
    {

        string Cadena = "asd";

        private static Conexion instance;

        private Conexion() { }

        private Conexion(string cadena)
        {
            this.Cadena = cadena;
        }

        public static Conexion GetInstance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }

        public static Conexion GetInstance (string cadena)
        {
            if( instance == null){
                instance = new Conexion(cadena);
            }
            return instance;
        }


    }
}
