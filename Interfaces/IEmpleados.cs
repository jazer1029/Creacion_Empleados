using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.Interfaces
{
    //Interfaz
    public interface IEmpleados
    {

        string cedula { get; set; }
        string codigo { get; set; }
        string nombre { get; set; }
        string apellido { get; set; }
        string email { get; set; }
        string telefono { get; set; }
        string departamento { get; set; }
        string cargo { get; set; }
        int precio_hora { get; set; }
        int horas_trabajo { get; set; }
        double salarioN { get; set; }

        double Cobrar(int horas_trabajo, double precio_hora);
        
        double Bono();

    }
}
