using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados
{
    //Clase empleado
    //Aqui se cumple el OpenClose porque no necesito cambiar algo de el codigo que tengo para añadir una funcionalidad.

    public class Empleado
    {
        public string cedula;
        public string codigo;
        public string nombre;
        public string apellido;
        public string email;
        public string telefono;
        public string departamento;
        public string cargo;
        public int precio_hora;
        public int horas_trabajo;
        public double salarioN;

        public Empleado(string cedula, string codigo, string nombre, string apellido, string email, string telefono, string departamento, string cargo, int precio_hora, int horas_trabajo, double salarioN)
        {
            this.cedula = cedula;
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.departamento = departamento;
            this.cargo = cargo;
            this.precio_hora = precio_hora;
            this.horas_trabajo = horas_trabajo;
            this.salarioN = salarioN;
        }

        public Empleado()
        {



        }

        public Empleado(string cedula, string codigo, string nombre, string apellido, string email, string telefono, string departamento, string cargo, int horas_trabajo, double salarioN)
        {
            this.cedula = cedula;
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.departamento = departamento;
            this.cargo = cargo;
            this.horas_trabajo = horas_trabajo;
            this.salarioN = salarioN;
        }



        //Mostrar el empleado creado

        //public override string ToString()
        //{
        //    string secciones = "";

        //    foreach (Seccion seccion in this.Secciones)
        //    {
        //        secciones += seccion.ToString() + "\n";

        //    }

        //    return "Nombre: " + this.nombre + "\n" +
        //       "Apellido: " + this.apellido + "\n" +
        //       "Matricula: " + this.matricula + "\n" +
        //       "Carrera: " + this.carrera + "\n" +
        //       "Seccion: " + secciones;
        //}

    }
}
