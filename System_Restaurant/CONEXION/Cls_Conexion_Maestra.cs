using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Restaurant.CONEXION
{
    class Cls_Conexion_Maestra
    {
        //El metodo retorna la cadena de conexión que se tiene desde un XML encriptada
        public static string conexion = Convert.ToString(LIBRERIAS.Cls_Desencriptacion.checkServer());

    }
}
