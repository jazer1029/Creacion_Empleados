using Creacion_Empleados.CLases;
using Creacion_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.Fabrica
{
    //Factory |Esta clase se encarga de crear los empleados|
    public class Fabrica_Empleado
    {

        //Singlenton
        private static Empleado_Gerencial? Instancia;
        public static Empleado_Gerencial getEmpleadoGerencial()
        {
            if (Instancia == null)
            {
                Instancia = new Empleado_Gerencial();
            }
            return Instancia;
        }

        public static IEmpleados Crear_Empleados(string Empleado)
        {

            if (Empleado == "Empleado gerencial")
            {
                return Empleado_Gerencial.getEmpleadoGerencial();
            }

            else if (Empleado == "Empleado administrativo")
            {
                return new Empleado_Administrativo();
            }

            else if (Empleado == "Empleado operativo")
            {
                return new Empleado_Operativo();
            }

            return new Empleado_Vacio();

        }

    }
}
