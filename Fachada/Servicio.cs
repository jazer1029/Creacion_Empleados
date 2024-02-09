//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Text.Json;
using Creacion_Empleados.Fabrica;
using Creacion_Empleados.Interfaces;
using System.Text.Json;

//namespace Creacion_Empleados.Fachada.Fachada
//{
public class Servicio
    {

        public static List<IEmpleados> Empleados_gerente = new List<IEmpleados>();
        public static List<IEmpleados> Empleados_administrativo = new List<IEmpleados>();
        public static List<IEmpleados> Empleados_operativo = new List<IEmpleados>();

        //Instancio metodo Random
        static Random rnd = new Random();

        //Metodo de creacion del empleado gerencial
        public static void CrearEmpleado_Gerente()
        {

            IEmpleados Gerente = Fabrica_Empleado.Crear_Empleados("Empleado gerencial");

            Console.WriteLine("\nDigite la cedula del empleado");
            string? cedula = Console.ReadLine();

            Console.WriteLine("\nDigite el nombre del empleado");
            string? nombre = Console.ReadLine();

            Console.WriteLine("\nDigite el apellido del empleado");
            string? apellido = Console.ReadLine();

            Console.WriteLine("\nDigite el email del empleado");
            string? email = Console.ReadLine();

            Console.WriteLine("\nDigite el telefono del empleado");
            string? telefono = Console.ReadLine();

            Console.WriteLine("\nDigite el departamento del empleado");
            string? departamento = Console.ReadLine();

            Console.WriteLine("\nDigite el cargo del empleado");
            string? cargo = Console.ReadLine();

            Console.WriteLine("\nDigite el precio por hora");
            int precio_hora = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite las horas trabajadas del empleado");
            int horas_trabajo = Convert.ToInt32(Console.ReadLine());

            string Codigo = departamento.Substring(0, 1) + departamento.Substring(1, 1) + departamento.Substring(2, 1) + rnd.Next(1000, 9999);

            Gerente.cedula = cedula;
            Gerente.codigo = Codigo;
            Gerente.nombre = nombre;
            Gerente.apellido = apellido;
            Gerente.email = email;
            Gerente.telefono = telefono;
            Gerente.departamento = departamento;
            Gerente.cargo = cargo;
            Gerente.horas_trabajo = horas_trabajo;
            Gerente.precio_hora = precio_hora;
            Empleados_gerente.Add(Gerente);

            double salarioN = Gerente.Cobrar(horas_trabajo, precio_hora);

            Console.WriteLine("Proceso Exitoso! ");
            Console.Write("Pulse cualquier tecla para Continuar:"); Console.ReadKey();

        }

        //Metodo de creacion del empleado administrativo
        public static void CrearEmpleado_Administrativo()
        {

            IEmpleados Administrativo = Fabrica_Empleado.Crear_Empleados("Empleado administrativo");

            Console.WriteLine("\nDigite la cedula del empleado");
            string? cedula = Console.ReadLine();

            Console.WriteLine("\nDigite el nombre del empleado");
            string? nombre = Console.ReadLine();

            Console.WriteLine("\nDigite el apellido del empleado");
            string? apellido = Console.ReadLine();

            Console.WriteLine("\nDigite el email del empleado");
            string? email = Console.ReadLine();

            Console.WriteLine("\nDigite el telefono del empleado");
            string? telefono = Console.ReadLine();

            Console.WriteLine("\nDigite el departamento del empleado");
            string? departamento = Console.ReadLine();

            Console.WriteLine("\nDigite el cargo del empleado");
            string? cargo = Console.ReadLine();

            Console.WriteLine("\nDigite el precio por hora");
            int precio_hora = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite las horas trabajadas del empleado");
            int horas_trabajo = Convert.ToInt32(Console.ReadLine());

            string Codigo = departamento.Substring(0, 1) + departamento.Substring(1, 1) + departamento.Substring(2, 1) + rnd.Next(1000, 9999);

            Administrativo.cedula = cedula;
            Administrativo.codigo = Codigo;
            Administrativo.nombre = nombre;
            Administrativo.apellido = apellido;
            Administrativo.email = email;
            Administrativo.telefono = telefono;
            Administrativo.departamento = departamento;
            Administrativo.cargo = cargo;
            Administrativo.horas_trabajo = horas_trabajo;
            Administrativo.precio_hora = precio_hora;
            Empleados_administrativo.Add(Administrativo);

            double salarioN = Administrativo.Cobrar(horas_trabajo, precio_hora);

            Console.WriteLine("Proceso Exitoso! ");
            Console.Write("Pulse cualquier tecla para Continuar:"); Console.ReadKey();


        }

        //Metodo de creacion del empleado operativo
        public static void CrearEmpleado_Operativo()
        {
            IEmpleados Operativo = Fabrica_Empleado.Crear_Empleados("Empleado operativo");

            Console.WriteLine("\nDigite la cedula del empleado");
            string? cedula = Console.ReadLine();

            Console.WriteLine("\nDigite el nombre del empleado");
            string? nombre = Console.ReadLine();

            Console.WriteLine("\nDigite el apellido del empleado");
            string? apellido = Console.ReadLine();

            Console.WriteLine("\nDigite el email del empleado");
            string? email = Console.ReadLine();

            Console.WriteLine("\nDigite el telefono del empleado");
            string? telefono = Console.ReadLine();

            Console.WriteLine("\nDigite el departamento del empleado");
            string? departamento = Console.ReadLine();

            Console.WriteLine("\nDigite el cargo del empleado");
            string? cargo = Console.ReadLine();

            Console.WriteLine("\nDigite el precio por hora");
            int precio_hora = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite las horas trabajadas del empleado");
            int horas_trabajo = Convert.ToInt32(Console.ReadLine());

            string Codigo = departamento.Substring(0, 1) + departamento.Substring(1, 1) + departamento.Substring(2, 1) + rnd.Next(1000, 9999);

            Operativo.cedula = cedula;
            Operativo.codigo = Codigo;
            Operativo.nombre = nombre;
            Operativo.apellido = apellido;
            Operativo.email = email;
            Operativo.telefono = telefono;
            Operativo.departamento = departamento;
            Operativo.cargo = cargo;
            Operativo.horas_trabajo = horas_trabajo;
            Operativo.precio_hora = precio_hora;
            Empleados_operativo.Add(Operativo);

            ////SE GUARDAN LOS CAMBIOS DE LA LISTA EN EL JSON
            //string miJsonO = JsonSerializer.Serialize(Empleados_operativo);
            //File.WriteAllText("EmpleadosO.json", miJsonO);

            double salarioN = Operativo.Cobrar(horas_trabajo, precio_hora);

            Console.WriteLine("Proceso Exitoso! ");
            Console.Write("Pulse cualquier tecla para Continuar:"); Console.ReadKey();

        }

        //Metodo de imprimir los datos del empleado
        public static void Imprimir_Empleado()
        {
            if (Empleados_gerente != null)
            {

                Console.WriteLine("   Cedula   |  Codigo  |   Nombre   |   Apellido   |    Email    |   Telefono   | Departamento |  Cargo  | Hora trabajadas | Salario Neto |");

                for (int i = 0; i < Empleados_gerente.Count; i++)
                {

                    Console.WriteLine(Empleados_gerente[i].cedula + "       |  " + Empleados_gerente[i].codigo + "  |  " + Empleados_gerente[i].nombre + "  |  " + Empleados_gerente[i].apellido + "  |  " + Empleados_gerente[i].email + "  |    " + Empleados_gerente[i].telefono + "  |  " + Empleados_gerente[i].departamento + "  |  " + Empleados_gerente[i].cargo + "  |  " + Empleados_gerente[i].horas_trabajo + "  |  " + Empleados_gerente[i].precio_hora + "    |    " + Empleados_gerente[i].salarioN + "\n");

                }

                Console.Write("Pulse cualquier tecla para Continuar:"); Console.ReadKey();

            }

            else if (Empleados_gerente == null)
            {
                for (int i = 0; i < Empleados_administrativo.Count; i++)
                {

                    Console.WriteLine(Empleados_administrativo[i].cedula + "       |  " + Empleados_administrativo[i].codigo + "  |  " + Empleados_administrativo[i].nombre + "  |  " + Empleados_administrativo[i].apellido + "  |  " + Empleados_administrativo[i].email + "  |  " + Empleados_administrativo[i].telefono + "  |  " + Empleados_administrativo[i].departamento + "  |  " + Empleados_administrativo[i].cargo + "  |  " + Empleados_administrativo[i].horas_trabajo + "  |  " + Empleados_administrativo[i].precio_hora + "    |    " + Empleados_administrativo[i].salarioN + "\n");

                }

                Console.Write("Pulse cualquier tecla para Continuar:"); Console.ReadKey();

            }

            else
            {
                for (int i = 0; i < Empleados_operativo.Count; i++)
                {

                    Console.WriteLine(Empleados_operativo[i].cedula + "       |  " + Empleados_operativo[i].codigo + "  |  " + Empleados_operativo[i].nombre + "  |  " + Empleados_operativo[i].apellido + "  |  " + Empleados_operativo[i].email + "  |    " + Empleados_operativo[i].telefono + "  |  " + Empleados_operativo[i].departamento + "  |  " + Empleados_operativo[i].cargo + "  |  " + Empleados_operativo[i].horas_trabajo + "  |  " + Empleados_operativo[i].precio_hora + "    |    " + Empleados_operativo[i].salarioN + "\n");

                }

                Console.Write("Pulse cualquier tecla para Continuar:"); Console.ReadKey();

            }

            Console.WriteLine();

        }


        public static void GuardarGerente()
        {
            string miJsonG = JsonSerializer.Serialize(Empleados_gerente);
            File.WriteAllText("EmpleadosG.json", miJsonG);
        }

        public static void GuardarAdministrativo()
        {
            string miJsonA = JsonSerializer.Serialize(Empleados_administrativo);
            File.WriteAllText("EmpleadosA.json", miJsonA);
        }

        public static void GuardarOperativo()
        {
            string miJsonO = JsonSerializer.Serialize(Empleados_operativo);
            File.WriteAllText("EmpleadosO.json", miJsonO);
        }

    }

//}

