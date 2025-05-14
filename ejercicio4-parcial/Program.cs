namespace ejercicio4_parcial
{
    internal class Program
    {
        const int MAX_PROYECTOS = 5;
        const int MAX_TIEMPOS = 3;
        static string[] proyectos = new string[MAX_PROYECTOS];
        static int[,] tiempos = new int[MAX_PROYECTOS, MAX_TIEMPOS];
        static int cant_proy = 0;
        static int opcion = 0;
        //mostrar los nombres de los tiempos al ingresarlos
        static void Main(string[] args)
        {
            int valor_salir = 6;
            while (opcion != valor_salir)
            {
                Console.WriteLine("Menú:");
                //opciones del menú
                Console.WriteLine("1. Ingresar un proyecto");
                Console.WriteLine("2. Mostrar un proyecto y sus tiempos");
                Console.WriteLine("3. Calcular promedio de un proyecto");
                Console.WriteLine("4. Editar tiempos de un proyecto");
                Console.WriteLine("5. Mostrar tiempo mas rapido");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese una opcion del menu: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("----Ingreso de proyecto----");
                        ingresarProyecto();
                        break;
                    case 2:
                        Console.WriteLine("----Mostrar proyecto----");
                        mostrarProyecto();
                        break;
                    case 3:
                        Console.WriteLine("----Calcular promedio----");
                        promedioProyecto();
                        break;
                    case 4:
                        Console.WriteLine("----Editar proyecto----");
                        editarProyecto();
                        break;
                    case 5:
                        Console.WriteLine("----Mostrar tiempo mas rapido----");
                        tiempoMasRapido();
                        break;
                    case 6:
                        Console.WriteLine("----Salir----");
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        break;
                }
            }
        }

        private static void tiempoMasRapido()
        {
            if(cant_proy == 0)
            {
                Console.WriteLine("No se han ingresado proyectos, la lista esta vacia.");
            }
            else
            {
                int menor_tiempo = tiempos[0, 0];
                string nombre_proyecto = proyectos[0];
                for (int i = 0; i < cant_proy; i++)
                {
                    for (int tiempo = 0; tiempo < MAX_TIEMPOS; tiempo++)
                    {
                        if (tiempos[i, tiempo] < menor_tiempo)
                        {
                            menor_tiempo = tiempos[i, tiempo];
                            nombre_proyecto = proyectos[i];
                            Console.WriteLine("Tiempo mas rapido actualizado.");
                        }
                    }
                }
                Console.WriteLine($"El proyecto con el tiempo mas rapido es: {nombre_proyecto} con un tiempo de {menor_tiempo} dia/s.");
            }
        }

        private static void editarProyecto()
        {
            if(cant_proy == 0)
            {
                Console.WriteLine("No se han ingresado proyectos, la lista esta vacia.");
            }
            else
            {
                Console.Write("Ingrese el nombre del proyecto a editar: ");
                string nombre_proyecto = Console.ReadLine().ToUpper();
                int i = 0;
                while (i < cant_proy && proyectos[i] != nombre_proyecto)
                {
                    i++;
                }
                if (i == cant_proy)
                {
                    Console.WriteLine("El proyecto no existe.");
                }
                else
                {
                    for (int tiempo = 0; tiempo < MAX_TIEMPOS; tiempo++)
                    {
                        Console.WriteLine("----Tiempos actuales----");
                        string nombre_tiempo = "";
                        switch (tiempo)
                        {
                            case 0:
                                nombre_tiempo = "planificado";
                                break;
                            case 1:
                                nombre_tiempo = "real";
                                break;
                            case 2:
                                nombre_tiempo = "corregido";
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine($"Tiempo {nombre_tiempo}: {tiempos[i, tiempo]} dia/s");
                        Console.Write($"Ingrese el nuevo tiempo: ");
                        tiempos[i, tiempo] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("----Tiempos actualizados----");
                }
            }
        }

        private static void promedioProyecto()
        {
            if(cant_proy == 0)
            {
                Console.WriteLine("No se han ingresado proyectos, la lista esta vacia.");
            }
            else
            {
                Console.Write("Ingrese el nombre del proyecto a calcular el promedio: ");
                string nombre_proyecto = Console.ReadLine().ToUpper();
                int i = 0;
                while (i < cant_proy && proyectos[i] != nombre_proyecto)
                {
                    i++;
                }
                if (i == cant_proy)
                {
                    Console.WriteLine("El proyecto no existe.");
                }
                else
                {
                    int suma = 0;
                    for (int tiempo = 0; tiempo < MAX_TIEMPOS; tiempo++)
                    {
                        suma += tiempos[i, tiempo];
                    }
                    int promedio = suma / MAX_TIEMPOS;
                    Console.WriteLine($"El promedio de los tiempos del proyecto {nombre_proyecto} es: {promedio} dia/s.");
                }
            }
        }

        private static void mostrarProyecto()
        {
            if (cant_proy == 0)
            {
                Console.WriteLine("No se han ingresado proyectos, la lista esta vacia.");
            }
            else
            {
                Console.Write("Ingrese el nombre del proyecto a mostrar: ");
                string nombre_proyecto = Console.ReadLine().ToUpper();
                int i = 0;
                while (i < cant_proy && proyectos[i] != nombre_proyecto)
                {
                    i++;
                }
                if (i == cant_proy)
                {
                    Console.WriteLine("El proyecto no existe.");
                } else
                {
                    Console.WriteLine($"Proyecto: {proyectos[i]}");
                    for (int tiempo = 0; tiempo < MAX_TIEMPOS; tiempo++)
                    {
                        string nombre_tiempo = "";
                        switch (tiempo)
                        {
                            case 0:
                                nombre_tiempo = "planificado";
                                break;
                            case 1:
                                nombre_tiempo = "real";
                                break;
                            case 2:
                                nombre_tiempo = "corregido";
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine($"Tiempo {nombre_tiempo}: {tiempos[i,tiempo]} dia/s");
                    }
                }
            }
        }

        private static void ingresarProyecto()
        {
            if(cant_proy < MAX_PROYECTOS)
            {
                Console.Write("Ingrese el nombre del proyecto: ");
                string nombre_proyecto;
                do
                {
                    nombre_proyecto = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(nombre_proyecto))
                    {
                        Console.WriteLine("El nombre del proyecto no puede estar vacio.");
                        Console.Write("Ingrese nuevamente el nombre del proyecto: ");
                    }
                } while (string.IsNullOrWhiteSpace(nombre_proyecto));
                proyectos[cant_proy] = nombre_proyecto.ToUpper();
                cant_proy++;
                for (int tiempo = 0; tiempo < MAX_TIEMPOS; tiempo++)
                {
                    string nombre_tiempo = "";
                    switch (tiempo)
                    {
                        case 0:
                            nombre_tiempo = "planificado";
                            break;
                        case 1:
                            nombre_tiempo = "real";
                            break;
                        case 2:
                            nombre_tiempo = "corregido";
                            break;
                        default:
                            break;
                    }
                    Console.Write($"Ingrese el tiempo {nombre_tiempo} del proyecto {nombre_proyecto}: ");
                    int tiempo_ingresado;
                    bool es_valido = false;
                    do
                    {
                        if (int.TryParse(Console.ReadLine(), out tiempo_ingresado))
                        {
                            es_valido = true;
                        }
                        else
                        {
                            Console.WriteLine("El nombre del proyecto no puede estar vacio.");
                            Console.Write("Ingrese nuevamente el nombre del proyecto: ");
                        }
                    } while (!es_valido);
                    tiempos[cant_proy - 1, tiempo] = tiempo_ingresado;
                }
            } else
            {
                Console.WriteLine("No se pueden ingresar mas proyectos.");
            }
        }
    }
}
