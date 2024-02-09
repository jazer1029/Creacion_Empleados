using Creacion_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.CLases
{
    public class Empleado_Operativo : IEmpleados
    {

        public string cedula { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public int precio_hora { get; set; }
        public int horas_trabajo { get; set; }
        public double salarioN { get; set; }

        //public Empleado_Operativo(string cedula, string codigo, string nombre, string apellido, string email, string telefono, string departamento, string cargo, int precio_hora, string horas_trabajo, double salarioN)
        //{
        //    this.cedula = cedula;
        //    this.codigo = codigo;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.email = email;
        //    this.telefono = telefono;
        //    this.departamento = departamento;
        //    this.cargo = cargo;
        //    this.precio_hora = precio_hora;
        //    this.horas_trabajo = horas_trabajo;
        //    this.salarioN = salarioN;
        //}


        double IEmpleados.Cobrar(int horas_trabajo, double precio_hora)
        {

            salarioN = horas_trabajo * precio_hora;
            return salarioN;

        }


        double IEmpleados.Bono()
        {
            double Bono = salarioN * 1.10;
            Console.Write("EL bono ha sido aplicado correctamente, su cobro es de: ");
            return Bono;
        }

    }
}
