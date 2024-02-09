using Creacion_Empleados.CLases;
using Creacion_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Creacion_Empleados.Estrategia
{
    public class EmpleadosJson : IEstrategia
    {

        //ATRIBUTOS
        public static List<IEmpleados> Empleados_gerente = Servicio.Empleados_gerente;
        public static List<IEmpleados> Empleados_administrativo = Servicio.Empleados_administrativo;
        public static List<IEmpleados> Empleados_operativo = Servicio.Empleados_operativo;
        //METODOS
        public void GuardarListaGerente()
        {
            string miJsonG = JsonSerializer.Serialize(Empleados_gerente);
            File.WriteAllText("EmpleadosG.json", miJsonG);
        }
        public void GuardarListaAdministrador()
        {
            string miJsonA = JsonSerializer.Serialize(Empleados_administrativo);
            File.WriteAllText("EmpleadosA.json", miJsonA);
        }
        public void GuardarListaOperador()
        {
            string miJsonO = JsonSerializer.Serialize(Empleados_operativo);
            File.WriteAllText("EmpleadosO.json", miJsonO);
        }
        public void CargarListas()
        {
            Console.Clear();

            //CREAR LISTAS COMPATIBLES
            List<Empleado_Gerencial> Gerencial;
            List<Empleado_Administrativo> Administrativo;
            List<Empleado_Operativo> Operativo;
            //LEER DATOS DE EMPLEADOS.JSON
            string miJsonG = (File.ReadAllText("EmpleadosG.json"));
            string miJsonA = (File.ReadAllText("EmpleadosA.json"));
            string miJsonO = (File.ReadAllText("EmpleadosO.json"));
            Gerencial = JsonSerializer.Deserialize<List<Empleado_Gerencial>>(miJsonG);
            Administrativo = JsonSerializer.Deserialize<List<Empleado_Administrativo>>(miJsonA)!;
            Operativo = JsonSerializer.Deserialize<List<Empleado_Operativo>>(miJsonO)!;

            //------------------------------------------------------------------//

            Console.Clear();

            //IMPRIMIR GERENTES
            Console.WriteLine("***EMPLEADOS GUARDADOS EN JSON***");
            if (Gerencial.Count == 0)
            {
               
            }
            else
            {
                foreach (var Dato in Gerencial)
                {
                    Console.WriteLine(@"Cedula : " + $"{Dato.cedula} " + "\n" +
                    "Codigo : " + $"{Dato.codigo} " + "\n" +
                    "Nombre : " + $"{Dato.nombre} " + "\n" +
                    "Apellido : " + $"{Dato.apellido} " + "\n" +
                    "Email : " + $"{Dato.email} " + "\n" +
                    "Telefono : " + $"{Dato.telefono} " + "\n" +
                    "Departamento : " + $"{Dato.departamento} " + "\n" +
                    "Cargo : " + $"{Dato.cargo} " + "\n" +
                    "Precio por Horas : " + $"{Dato.precio_hora}" + "\n" +
                    "Horas Trabajadas : " + $" {Dato.horas_trabajo} " + "\n" +
                    "Salario Neto : " + $"{Dato.salarioN}"
                    );
                    Console.WriteLine("**********************************");
                }
            }

            //IMPRIMIR ADMINISTRADORES
            if (Administrativo.Count == 0)
            {
               
            }
            else
            {
                foreach (var Dato in Administrativo)
                {
                    Console.WriteLine(@"Cedula : " + $"{Dato.cedula} " + "\n" +
                    "Codigo : " + $"{Dato.codigo} " + "\n" +
                    "Nombre : " + $"{Dato.nombre} " + "\n" +
                    "Apellido : " + $"{Dato.apellido} " + "\n" +
                    "Email : " + $"{Dato.email} " + "\n" +
                    "Telefono : " + $"{Dato.telefono} " + "\n" +
                    "Departamento : " + $"{Dato.departamento} " + "\n" +
                    "Cargo : " + $"{Dato.cargo} " + "\n" +
                    "Precio por Horas : " + $"{Dato.precio_hora}" + "\n" +
                    "Horas Trabajadas : " + $" {Dato.horas_trabajo} " + "\n" +
                    "Salario Neto : " + $"{Dato.salarioN}"
                    );
                    Console.WriteLine("**********************************");
                }
            }

            //IMPRIMIR OPERADORES
            if (Operativo.Count == 0)
            {
               
            }
            else
            {
                foreach (var Dato in Operativo)
                {
                    Console.WriteLine(@"Cedula : " + $"{Dato.cedula} " + "\n" +
                    "Codigo : " + $"{Dato.codigo} " + "\n" +
                    "Nombre : " + $"{Dato.nombre} " + "\n" +
                    "Apellido : " + $"{Dato.apellido} " + "\n" +
                    "Email : " + $"{Dato.email} " + "\n" +
                    "Telefono : " + $"{Dato.telefono} " + "\n" +
                    "Departamento : " + $"{Dato.departamento} " + "\n" +
                    "Cargo : " + $"{Dato.cargo} " + "\n" +
                    "Precio por Horas : " + $"{Dato.precio_hora}" + "\n" +
                    "Horas Trabajadas : " + $" {Dato.horas_trabajo} " + "\n" +
                    "Salario Neto : " + $"{Dato.salarioN}"
                    );
                    Console.WriteLine("**********************************");
                }
            }
            if (Gerencial.Count == 0 && Administrativo.Count == 0 && Operativo.Count == 0)
            {
                Console.WriteLine("No hay ningun dato guardado.");
            }
            Console.Write("Pulsa cualquier tecla para volver:"); Console.ReadKey();
            Console.Clear();
        }

    }
}
