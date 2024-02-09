using Creacion_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.Estrategia
{
    public class EmpleadoTXT : IEstrategia
    {

        //ATRIBUTOS
        public static List<IEmpleados> Empleados_gerente = Servicio.Empleados_gerente;
        public static List<IEmpleados> Empleados_administrativo = Servicio.Empleados_administrativo;
        public static List<IEmpleados> Empleados_operativo = Servicio.Empleados_operativo;

        //METODOS
        public void GuardarListaGerente()
        {
            TextWriter archivo = new StreamWriter("Gerente.txt");
            for (int i = 0; i < Empleados_gerente.Count; i++)
            {
                archivo.WriteLine(
                "Cedula : " + $"{Empleados_gerente[i].cedula} " + "\n" +
                "Codigo : " + $"{Empleados_gerente[i].codigo} " + "\n" +
                "Nombre : " + $"{Empleados_gerente[i].nombre} " + "\n" +
                "Apellido : " + $"{Empleados_gerente[i].apellido} " + "\n" +
                "Email : " + $"{Empleados_gerente[i].email} " + "\n" +
                "Telefono : " + $"{Empleados_gerente[i].telefono} " + "\n" +
                "Departamento : " + $"{Empleados_gerente[i].departamento} " + "\n" +
                "Cargo : " + $"{Empleados_gerente[i].cargo} " + "\n" +
                "Precio por Horas : " + $"{Empleados_gerente[i].precio_hora}" + "\n" +
                "Horas Trabajadas : " + $" {Empleados_gerente[i].horas_trabajo} " + "\n" +
                "Salario Neto : " + $"{Empleados_gerente[i].salarioN}"
                );

            }
            archivo.Close();
        }
        public void GuardarListaAdministrador()
        {
            TextWriter archivo = new StreamWriter("Administrador.txt");

            for (int i = 0; i < Empleados_administrativo.Count; i++)
            {
                archivo.WriteLine(
               "Cedula : " + $"{Empleados_administrativo[i].cedula} " + "\n" +
               "Codigo : " + $"{Empleados_administrativo[i].codigo} " + "\n" +
               "Nombre : " + $"{Empleados_administrativo[i].nombre} " + "\n" +
               "Apellido : " + $"{Empleados_administrativo[i].apellido} " + "\n" +
               "Email : " + $"{Empleados_administrativo[i].email} " + "\n" +
               "Telefono : " + $"{Empleados_administrativo[i].telefono} " + "\n" +
               "Departamento : " + $"{Empleados_administrativo[i].departamento} " + "\n" +
               "Cargo : " + $"{Empleados_administrativo[i].cargo} " + "\n" +
               "Precio por Horas : " + $"{Empleados_administrativo[i].precio_hora}" + "\n" +
               "Horas Trabajadas : " + $" {Empleados_administrativo[i].horas_trabajo} " + "\n" +
               "Salario Neto : " + $"{Empleados_administrativo[i].salarioN}"
                );

            }
            archivo.Close();
        }
        public void GuardarListaOperador()
        {
            TextWriter archivo = new StreamWriter("Operador.txt");

            for (int i = 0; i < Empleados_operativo.Count; i++)
            {
                archivo.WriteLine(
                "Cedula : " + $"{Empleados_operativo[i].cedula} " + "\n" +
                "Codigo : " + $"{Empleados_operativo[i].codigo} " + "\n" +
                "Nombre : " + $"{Empleados_operativo[i].nombre} " + "\n" +
                "Apellido : " + $"{Empleados_operativo[i].apellido} " + "\n" +
                "Email : " + $"{Empleados_operativo[i].email} " + "\n" +
                "Telefono : " + $"{Empleados_operativo[i].telefono} " + "\n" +
                "Departamento : " + $"{Empleados_operativo[i].departamento} " + "\n" +
                "Cargo :" + $"{Empleados_operativo[i].cargo} " + "\n" +
                "Precio por Horas : " + $"{Empleados_operativo[i].precio_hora}" + "\n" +
                "Horas Trabajadas : " + $" {Empleados_operativo[i].horas_trabajo} " + "\n" +
                "Salario Neto : " + $"{Empleados_operativo[i].salarioN}"
                );

            }
            archivo.Close();
        }
        public void CargarListas()
        {
            Console.Clear();
            Console.WriteLine("***EMPLEADOS GUARDADOS EN TXT***");

            //LEER GERENTE
            TextReader LeerGerente = new StreamReader("Gerente.txt");
            if (LeerGerente == null)
            {
                
            }
            else
            {
                Console.WriteLine(LeerGerente.ReadToEnd());
                Console.WriteLine("**********************************");
            }

            //LEER ADMINISTRADOR
            TextReader LeerAdministrador = new StreamReader("Administrador.txt");
            if (LeerAdministrador == null)
            {
                
            }
            else
            {
                Console.WriteLine(LeerAdministrador.ReadToEnd());
                Console.WriteLine("**********************************");
            }

            //LEER OPERADOR
            TextReader LeerOperador = new StreamReader("Operador.txt");
            if (LeerOperador == null)
            {
                
            }
            else
            {
                Console.WriteLine(LeerOperador.ReadToEnd());
                Console.WriteLine("**********************************");
            }
            if (LeerGerente == null && LeerAdministrador == null && LeerOperador == null)
            {
                Console.WriteLine("No hay ningun dato guardado.");
            }
            Console.Write("Pulsa cualquier tecla para volver:"); Console.ReadKey();
            Console.Clear();
        }

    }
}
