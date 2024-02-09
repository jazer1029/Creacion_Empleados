using Creacion_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.Estrategia
{
    public class EmpleadosCsv : IEstrategia
    {

        //ATRIBUTOS
        public static List<IEmpleados> Empleados_gerente = Servicio.Empleados_gerente;
        public static List<IEmpleados> Empleados_administrativo = Servicio.Empleados_administrativo;
        public static List<IEmpleados> Empleados_operativo = Servicio.Empleados_operativo;
        //METODOS
        public void GuardarListaGerente()
        {
            String Ubicacion = @"C:\Users\ALIAH\Desktop\Programacion\C#\Creacion_Empleados\EmpleadosCSV\Gerente.csv";

            for (int i = 0; i < Empleados_gerente.Count; i++)
            {
                String Salida = "\n" + $"{Empleados_gerente[i].cedula} " + "," + $"{Empleados_gerente[i].codigo} " + "," + $"{Empleados_gerente[i].nombre} " + "," + $"{Empleados_gerente[i].apellido} " + "," + $"{Empleados_gerente[i].email} " + "," + $"{Empleados_gerente[i].telefono} " + "," + $"{Empleados_gerente[i].departamento} " + "," + $"{Empleados_gerente[i].cargo} " + "," + $"{Empleados_gerente[i].precio_hora}" + "," + $" {Empleados_gerente[i].horas_trabajo} " + "," + $"{Empleados_gerente[i].salarioN}";
                File.AppendAllText(Ubicacion, Salida);
            }
        }
        public void GuardarListaAdministrador()
        {
            String Ubicacion = @"C:\Users\ALIAH\Desktop\Programacion\C#\Creacion_Empleados\EmpleadosCSV\Administrador.csv";

            for (int i = 0; i < Empleados_administrativo.Count; i++)
            {
                String Salida = $"\n{Empleados_administrativo[i].cedula} " + "," + $"{Empleados_administrativo[i].codigo} " + "," + $"{Empleados_administrativo[i].nombre} " + "," + $"{Empleados_administrativo[i].apellido} " + "," + $"{Empleados_administrativo[i].email} " + "," + $"{Empleados_administrativo[i].telefono} " + "," + $"{Empleados_administrativo[i].departamento} " + "," + $"{Empleados_administrativo[i].cargo} " + "," + $"{Empleados_administrativo[i].precio_hora}" + "," + $" {Empleados_administrativo[i].horas_trabajo} " + "," + $"{Empleados_administrativo[i].salarioN}";
                File.AppendAllText(Ubicacion, Salida.ToString());
            }
        }
        public void GuardarListaOperador()
        {
            String Ubicacion = @"C:\Users\ALIAH\Desktop\Programacion\C#\Creacion_Empleados\EmpleadosCSV\Operador.csv";

            for (int i = 0; i < Empleados_operativo.Count; i++)
            {
                String Salida = $"\n{Empleados_operativo[i].cedula} " + "," + $"{Empleados_operativo[i].codigo} " + "," + $"{Empleados_operativo[i].nombre} " + "," + $"{Empleados_operativo[i].apellido} " + "," + $"{Empleados_operativo[i].email} " + "," + $"{Empleados_operativo[i].telefono} " + "," + $"{Empleados_operativo[i].departamento} " + "," + $"{Empleados_operativo[i].cargo} " + "," + $"{Empleados_operativo[i].precio_hora}" + "," + $" {Empleados_operativo[i].horas_trabajo} " + "," + $"{Empleados_operativo[i].salarioN}";
                File.AppendAllText(Ubicacion, Salida.ToString());
            }
        }
        public void CargarListas()
        {
            Console.Clear();

            //CARGANDO LISTA GERENTES
            String Ubicacion = @"C:\Users\ALIAH\Desktop\Programacion\C#\Creacion_Empleados\EmpleadosCSV\Gerente.csv";
            StreamReader Archivo = new StreamReader(Ubicacion);
            string Separador = ",";
            string Linea;
            Console.WriteLine("***EMPLEADOS GUARDADOS EN CSV***");
            while ((Linea = Archivo.ReadLine()!) != null)
            {
                string[] Fila = Linea.Split(Separador);
                string Cedula = Fila[0];
                string Codigo = Fila[1];
                string Nombre = Fila[2];
                string Apellido = Fila[3];
                string Email = Fila[4];
                string Telefono = Fila[5];
                string Departamento = Fila[6];
                string Cargo = Fila[7];
                double precio_hora = Convert.ToDouble(Fila[8]);
                int horas_trabajo = Convert.ToInt32(Fila[9]);
                double SalarioN = Convert.ToDouble(Fila[10]);

                //------------------------------------------------------------------//
                
                Console.WriteLine(@"Cedula : " + $"{Cedula} " + "\n" +
                        "Codigo : " + $"{Codigo} " + "\n" +
                        "Nombre : " + $"{Nombre} " + "\n" +
                        "Apellido : " + $"{Apellido} " + "\n" +
                        "Email : " + $"{Email} " + "\n" +
                        "Telefono : " + $"{Telefono} " + "\n" +
                        "Departamento : " + $"{Departamento} " + "\n" +
                        "Cargo :" + $"{Cargo} " + "\n" +
                        "Precio por Horas : " + $"{precio_hora}" + "\n" +
                        "Horas Trabajadas : " + $" {horas_trabajo} " + "\n" +
                        "Salario Neto : " + $"{SalarioN}" + "\n"
                );
                Console.WriteLine("**********************************");
            }
            //CARGANDO LISTA ADMINISTRADORES
            String Ubicacion2 = @"C:\Users\ALIAH\Desktop\Programacion\C#\Creacion_Empleados\EmpleadosCSV\Administrador.csv";
            StreamReader Archivo2 = new StreamReader(Ubicacion2);
            string Separador2 = ",";
            string Linea2;
            while ((Linea2 = Archivo2.ReadLine()!) != null)
            {
                string[] Fila = Linea2.Split(Separador2);
                string Cedula2 = Fila[0];
                string Codigo2 = Fila[1];
                string Nombre2 = Fila[2];
                string Apellido2 = Fila[3];
                string Email2 = Fila[4];
                string Telefono2 = Fila[5];
                string Departamento2 = Fila[6];
                string Cargo2 = Fila[7];
                double precio_hora2 = Convert.ToDouble(Fila[8]);
                int horas_trabajo2 = Convert.ToInt32(Fila[9]);
                double SalarioN2 = Convert.ToDouble(Fila[10]);

                //------------------------------------------------------------------//
                
                Console.WriteLine(@"Cedula : " + $"{Cedula2} " + "\n" +
                        "Codigo : " + $"{Codigo2} " + "\n" +
                        "Nombre : " + $"{Nombre2} " + "\n" +
                        "Apellido : " + $"{Apellido2} " + "\n" +
                        "Email : " + $"{Email2} " + "\n" +
                        "Telefono : " + $"{Telefono2} " + "\n" +
                        "Departamento : " + $"{Departamento2} " + "\n" +
                        "Cargo :" + $"{Cargo2} " + "\n" +
                        "Precio por Horas : " + $"{precio_hora2}" + "\n" +
                        "Horas Trabajadas : " + $" {horas_trabajo2} " + "\n" +
                        "Salario Neto : " + $"{SalarioN2}" + "\n"
                );
                Console.WriteLine("**********************************");
            }
            //CARGANDO LISTA ADMINISTRADORES
            String Ubicacion3 = @"C:\Users\ALIAH\Desktop\Programacion\C#\Creacion_Empleados\EmpleadosCSV\Operador.csv";
            StreamReader Archivo3 = new StreamReader(Ubicacion3);
            string Separador3 = ",";
            string Linea3;
            while ((Linea3 = Archivo3.ReadLine()!) != null)
            {
                string[] Fila = Linea3.Split(Separador3);
                string Cedula3 = Fila[0];
                string Codigo3 = Fila[1];
                string Nombre3 = Fila[2];
                string Apellido3 = Fila[3];
                string Email3 = Fila[4];
                string Telefono3 = Fila[5];
                string Departamento3 = Fila[6];
                string Cargo3 = Fila[7];
                double precio_hora3 = Convert.ToDouble(Fila[8]);
                int horas_trabajo3 = Convert.ToInt32(Fila[9]);
                double SalarioN3 = Convert.ToDouble(Fila[10]);

                //------------------------------------------------------------------//

                Console.WriteLine(@"Cedula : " + $"{Cedula3} " + "\n" +
                        "Codigo : " + $"{Codigo3} " + "\n" +
                        "Nombre : " + $"{Nombre3} " + "\n" +
                        "Apellido : " + $"{Apellido3} " + "\n" +
                        "Email : " + $"{Email3} " + "\n" +
                        "Telefono : " + $"{Telefono3} " + "\n" +
                        "Departamento : " + $"{Departamento3} " + "\n" +
                        "Cargo :" + $"{Cargo3} " + "\n" +
                        "Precio por Horas : " + $"{precio_hora3}" + "\n" +
                        "Horas Trabajadas : " + $" {horas_trabajo3} " + "\n" +
                        "Salario Neto : " + $"{SalarioN3}" + "\n"
                );
                Console.WriteLine("**********************************");
            }
            if (Archivo == null && Archivo2 == null && Archivo3 == null)
            {
                Console.WriteLine("No hay ningun dato guardado.");
            }
            Console.Write("Pulse cualquier tecla para volver:"); Console.ReadKey();
            Console.Clear();
        }

    }
}
