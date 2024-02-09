
using Creacion_Empleados;
using Creacion_Empleados.Estrategia;

public class Fachada
{

    private Contexto? Contexto;
    public Servicio servicio = new Servicio();

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("----------CREACION EMPLEADOS----------");
        Console.WriteLine("[1] EMPLEADO GERENCIAL \n[2] EMPLEADO ADMINISTRATIVO \n[3] EMPLEADO OPERATIVO \n[4] GUARDAR EMPLEADOS LOCALMENTE \n[5] LEER EMPLEADOS \n[6] SALIR");
        Console.Write("Opcion:");
    }

    public void CrearGerencial()
    {
        Servicio.CrearEmpleado_Gerente();
    }

    public void CrearAdministrativo()
    {
        Servicio.CrearEmpleado_Administrativo();
    }

    public void CrearOperativo()
    {
        Servicio.CrearEmpleado_Operativo();
    }

    public void CargarLista()
    {
        Console.Clear();
        Console.WriteLine("----------MOSTRAR DATOS----------");
        Console.WriteLine("[1] EMPLEADOS TXT \n[2] EMPLEADOS JSON \n[3] EMPLEADOS CSV \n[4] VOLVER");
        Console.Write("Opcion:");
        int Opcion = int.Parse(Console.ReadLine()!);
        switch (Opcion)
        {
            case 1:
                Contexto = new Contexto(new EmpleadoTXT());
                Contexto.Leer();
                break;
            case 2:
                Contexto = new Contexto(new EmpleadosJson());
                Contexto.Leer();
                break;
            case 3:
                Contexto = new Contexto(new EmpleadosCsv());
                Contexto.Leer();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Opcion Incorrecta.");
                break;
        }

    }

    public void Guardar()
    {
        Console.Clear();

        //Menu
        Console.WriteLine("-----Bienvenidos-----");
        Console.WriteLine();
        Console.WriteLine("1.Guardar empleados" + "\nElija el tipo de empleado que desea guardar" +
            "\n[1].Empleado Gerencial" + "\n[2].Empleado Administrativo" + "\n[3].Empleado Operativo" + "\n[4].Guardar todo" + "\n[0].Salir");

        //SWITCH ANIDADO
        Console.Clear();
        Console.WriteLine("En cual formato desea guardar el Empleado?");
        Console.WriteLine("[1] TXT \n[2] JSON \n[3] CSV \n[0] VOLVER");
        Console.Write("Opcion:");
        int Opcion = int.Parse(Console.ReadLine()!);
        switch (Opcion)
        {
            case 1:
                Console.Clear();
                Contexto = new Contexto(new EmpleadoTXT());
                Console.WriteLine("Que empleado desea guardar?");
                Console.WriteLine("[1] EMPLEADO GERENCIAL \n[2] EMPLEADO ADMINISTRATIVO \n[3] EMPLEADO OPERATIVO \n[4] TODOS \n[0] VOLVER");
                Console.Write("Opcion:");
                int opcion1 = int.Parse(Console.ReadLine()!);

                switch (opcion1)
                {
                    case 1:
                        Console.Clear();
                        Contexto.EjecutarGerente();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 2:
                        Console.Clear();
                        Contexto.EjecutarAdministrador();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Contexto.EjecutarOperador();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Todas las listas tienen datos? Si/No");
                        string Respuesta = Console.ReadLine()!;
                        if (Respuesta == "Si" || Respuesta == "si")
                        {
                            Console.Clear();
                            Contexto.EjecutarGerente();
                            Contexto.EjecutarAdministrador();
                            Contexto.EjecutarOperador();
                            Console.WriteLine("Empleados guardados localmente.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else if (Respuesta == "No" || Respuesta == "no")
                        {
                            Console.Clear();
                            Console.Write("Vuelva a intentarlo con las 3 listas llenas.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                }
                break;
            case 2:
                Console.Clear();
                Contexto = new Contexto(new EmpleadosJson());
                Console.WriteLine("Que empleado desea guardar?");
                Console.WriteLine("[1] EMPLEADO GERENCIAL \n[2] EMPLEADO ADMINISTRATIVO \n[3] EMPLEADO OPERATIVO \n[4] TODOS \n[0] VOLVER");
                Console.Write("Opcion:");
                int opcion2 = int.Parse(Console.ReadLine()!);

                switch (opcion2)
                {
                    case 1:
                        Console.Clear();
                        Contexto.EjecutarGerente();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 2:
                        Console.Clear();
                        Contexto.EjecutarAdministrador();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Contexto.EjecutarOperador();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Todas las listas tienen datos? Si/No");
                        string Respuesta = Console.ReadLine()!;
                        if (Respuesta == "Si" || Respuesta == "si")
                        {
                            Console.Clear();
                            Contexto.EjecutarGerente();
                            Contexto.EjecutarAdministrador();
                            Contexto.EjecutarOperador();
                            Console.WriteLine("Empleados guardados localmente.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else if (Respuesta == "No" || Respuesta == "no")
                        {
                            Console.Clear();
                            Console.Write("Vuelva a intentarlo con las 3 listas llenas.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                }
                break;
            case 3:
                Console.Clear();
                Contexto = new Contexto(new EmpleadosCsv());
                Console.WriteLine("Que empleado desea guardar?");
                Console.WriteLine("[1] EMPLEADO GERENCIAL \n[2] EMPLEADO ADMINISTRATIVO \n[3] EMPLEADO OPERATIVO \n[4] TODOS \n[0] VOLVER");
                Console.Write("Opcion:");
                int opcion3 = int.Parse(Console.ReadLine()!);

                switch (opcion3)
                {
                    case 1:
                        Console.Clear();
                        Contexto.EjecutarGerente();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 2:
                        Console.Clear();
                        Contexto.EjecutarAdministrador();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Contexto.EjecutarOperador();
                        Console.WriteLine("Empleado guardado localmente.");
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Todas las listas tienen datos? Si/No");
                        string Respuesta = Console.ReadLine()!;
                        if (Respuesta == "Si" || Respuesta == "si")
                        {
                            Console.Clear();
                            Contexto.EjecutarGerente();
                            Contexto.EjecutarAdministrador();
                            Contexto.EjecutarOperador();
                            Console.WriteLine("Empleados guardados localmente.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else if (Respuesta == "No" || Respuesta == "no")
                        {
                            Console.Clear();
                            Console.Write("Vuelva a intentarlo con las 3 listas llenas.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                }
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Opcion Incorrecta.");
                break;
        }
    }
}

