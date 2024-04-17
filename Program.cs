
using System;
using System;

namespace MyApplication
{

    class Program
    {
        //Para cumplir el principio de Responsabilidad unica cree diferentes clases.

        static void Main(string[] args)
        {

            Menu();

        }

        //Creo el metodo Menu el cual sera lo que saldra en consola
        public static void Menu()
        {
            //Llamo de la clase Console a la funcion Clear para limpiar la consola
            Console.Clear();
            int Opciones = 100;
            Fachada fachada = new Fachada();    


            while (Opciones != 0)
            {
                //Menu
                Console.WriteLine("-----Bienvenidos-----");
                Console.WriteLine();
                Console.WriteLine("1.Crear empleados" + "\nElija el tipo de empleado que desea crear" +
                    "\n[1].Empleado Gerencial" + "\n[2].Empleado Administrativo" + "\n[3].Empleado Operativo" + "\n[4].Guardar datos del Empleado" + "\n[5].Leer datos del Empleado" + "\n[0].Salir");
      
                Opciones = Convert.ToInt32(Console.ReadLine());

                //Hago un switch para poder interactuar con el menu de arriba y darle funcionalidad dependiendo de la opcion elegida
                switch (Opciones)
                {
                    case 1:

                        fachada.CrearGerencial();
                        break;

                    case 2:
                        fachada.CrearAdministrativo();
                        break;

                    case 3:
                        fachada.CrearOperativo();
                        break;

                    case 4:
                        fachada.Guardar();
                        break;

                    case 5:
                        fachada.CargarLista();
                        break;

                    case 0:
                        
                        break;

                    default:
                        Console.WriteLine("Introduce una opcion valida");
                        break;
                }

                //Llamo a menu nuevamente
                Menu();

            }

        }

    }
}

