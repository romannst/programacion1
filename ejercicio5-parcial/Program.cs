
namespace ejercicio5_parcial
{
    internal class Program
    {
        const int MAX_PRODSERV = 5;
        const int MAX_PUNTUACIONES = 3;
        static string[] producto_servicio = new string[MAX_PRODSERV];
        static double[,] puntuaciones = new double[MAX_PRODSERV, MAX_PUNTUACIONES];
        static int cant_prodserv = 0;
        static string opcion = "";
        static void Main(string[] args)
        {
            string opcion_salir = "8";
            while (opcion != opcion_salir)
            {
                Console.WriteLine("Menú:");
                //opciones del menú
                Console.WriteLine("1. Ingresar un producto/servicio");
                Console.WriteLine("2. Mostrar un producto/servicio y sus puntuaciones");
                Console.WriteLine("3. Mostrar los productos y sus puntuaciones");
                Console.WriteLine("4. Calcular promedio de un producto/servicio");
                Console.WriteLine("5. Editar puntuaciones de un producto/servicio");
                Console.WriteLine("6. Mostrar la puntuación más satisfactoria");
                Console.WriteLine("7. Eliminar un producto/servicio");
                Console.WriteLine("8. Salir");
                Console.WriteLine();
                Console.Write("Ingrese la opcion a ejecutar del Menú: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ingresar();
                        Console.WriteLine();
                        break;
                    case "2":
                        mostrarUno();
                        Console.WriteLine();
                        break;
                    case "3":
                        mostrarTodos();
                        Console.WriteLine();
                        break;
                    case "4":
                        promedioUno();
                        Console.WriteLine();
                        break;
                    case "5":
                        editarUno();
                        Console.WriteLine();
                        break;
                    case "6":
                        puntajeMasAlto();
                        Console.WriteLine();
                        break;
                    case "7":
                        eliminar();
                        Console.WriteLine();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        Console.WriteLine();
                        break;
                }
            }

        }

        //Métodos para cada opción del menú
        private static void eliminar()
        {
            if (cant_prodserv == 0)
            {
                Console.WriteLine("No hay productos/servicios para eliminar.");
            }
            else
            {
                Console.Write("Ingrese el nombre del producto/servicio a eliminar: ");
                string nombre = Console.ReadLine();
                bool encontrado = false;
                int i_nombre = 0;
                while (i_nombre < cant_prodserv && !encontrado)
                {
                    if (producto_servicio[i_nombre] == nombre)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        i_nombre++;
                    }
                }
                if (encontrado)
                {
                    for (int i = i_nombre; i < cant_prodserv - 1; i++)
                    {
                        producto_servicio[i] = producto_servicio[i + 1];
                        for (int j = 0; j < MAX_PUNTUACIONES; j++)
                        {
                            puntuaciones[i, j] = puntuaciones[i + 1, j];
                        }
                    }
                    cant_prodserv--;
                    Console.WriteLine("Producto/Servicio eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Producto/Servicio no encontrado.");
                }
            }
        }
        private static void puntajeMasAlto()
        {
            if (cant_prodserv == 0)
            {
                Console.WriteLine("No hay productos/servicios ingresados.");
            }
            else
            {
                double puntaje_maximo = -1;
                string nombre_maximo = "";
                for (int nombre = 0; nombre < cant_prodserv; nombre++)
                {
                    for (int puntaje = 0; puntaje < MAX_PUNTUACIONES; puntaje++)
                    {
                        if (puntuaciones[nombre, puntaje] > puntaje_maximo)
                        {
                            puntaje_maximo = puntuaciones[nombre, puntaje];
                            nombre_maximo = producto_servicio[nombre];
                        }
                    }
                }
                if (puntaje_maximo == -1)
                {
                    Console.WriteLine("No se encontraron puntuaciones.");
                }
                else
                {
                    Console.WriteLine($"El producto/servicio con la puntuación más alta es: {nombre_maximo} con una puntuación de {puntaje_maximo}.");
                }
            }
        }
        private static void editarUno()
        {
            if (cant_prodserv == 0)
            {
                Console.WriteLine("No hay productos/servicios para editar.");
            }
            else
            {
                Console.Write("Ingrese el nombre del producto/servicio a mostrar: ");
                string nombre = Console.ReadLine();
                bool encontrado = false;
                int i_nombre = 0;
                while (i_nombre < cant_prodserv && !encontrado)
                {
                    if (producto_servicio[i_nombre] == nombre)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        i_nombre++;
                    }
                }
                if (encontrado)
                {
                    Console.WriteLine($"Producto/Servicio: {producto_servicio[i_nombre]}");
                    Console.WriteLine("Puntuaciones:");
                    for (int i = 0; i < MAX_PUNTUACIONES; i++)
                    {
                        Console.WriteLine($"Puntuación {i + 1}: {puntuaciones[i_nombre, i]}");
                    }
                    Console.WriteLine("Ingrese las nuevas puntuaciones (atención,calidad,precio) del producto/servicio:");
                    for (int puntuacion = 0; puntuacion < MAX_PUNTUACIONES; puntuacion++)
                    {
                        Console.Write($"Ingrese la nueva puntuación {puntuacion + 1}: ");
                        puntuaciones[i_nombre, puntuacion] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Puntuaciones actualizadas correctamente.");
                }
                else
                {
                    Console.WriteLine("Producto/Servicio no encontrado.");
                }
            }
        }
        private static void promedioUno()
        {
            if (cant_prodserv == 0)
            {
                Console.WriteLine("No hay productos/servicios para hacer promedio.");
            }
            else
            {
                Console.Write("Ingrese el nombre del producto/servicio a mostrar: ");
                string nombre = Console.ReadLine();
                bool encontrado = false;
                int i_nombre = 0;
                while (i_nombre < cant_prodserv && !encontrado)
                {
                    if (producto_servicio[i_nombre] == nombre)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        i_nombre++;
                    }
                }
                if (encontrado)
                {
                    double suma = 0;
                    for (int i = 0; i < MAX_PUNTUACIONES; i++)
                    {
                        suma += puntuaciones[i_nombre, i];
                    }
                    double promedio = suma / MAX_PUNTUACIONES;
                    Console.WriteLine($"El promedio de las puntuaciones del producto/servicio {producto_servicio[i_nombre]} es: {promedio:F2}");
                }
                else
                {
                    Console.WriteLine("Producto/Servicio no encontrado.");
                }
            }
        }
        private static void mostrarTodos()
        {
            if(cant_prodserv == 0)
            {
                Console.WriteLine("No hay productos/servicios para mostrar.");
            } else
            {
                Console.WriteLine("Productos/Servicios y sus puntuaciones:");
                for (int prodserv = 0; prodserv < cant_prodserv; prodserv++)
                {
                    Console.WriteLine($"Producto/Servicio: {producto_servicio[prodserv]}");
                    Console.WriteLine("Puntuaciones:");
                    for (int puntuacion = 0; puntuacion < MAX_PUNTUACIONES; puntuacion++)
                    {
                        Console.WriteLine($"Puntuación {puntuacion + 1}: {puntuaciones[prodserv, puntuacion]}");
                    }
                }
            }

        }
        private static void mostrarUno()
        {
            if (cant_prodserv == 0)
            {
                Console.WriteLine("No hay productos/servicios para mostrar.");
            } else
            {
                Console.Write("Ingrese el nombre del producto/servicio a mostrar: ");
                string nombre = Console.ReadLine();
                bool encontrado = false;
                int i_nombre = 0;
                while (i_nombre < cant_prodserv && !encontrado)
                {
                    if(producto_servicio[i_nombre] == nombre)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        i_nombre++;
                    }
                }
                if (encontrado)
                {
                    Console.WriteLine($"Producto/Servicio: {producto_servicio[i_nombre]}");
                    Console.WriteLine("Puntuaciones:");
                    for (int i = 0; i < MAX_PUNTUACIONES; i++)
                    {
                        Console.WriteLine($"Puntuación {i + 1}: {puntuaciones[i_nombre, i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Producto/Servicio no encontrado.");
                }
            }
        }
        private static void ingresar()
        {
            if (cant_prodserv < MAX_PRODSERV)
            {
                Console.Write("Ingrese el nombre del producto/servicio: ");
                string nombre;
                do
                {
                    nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
                    }
                } while(string.IsNullOrWhiteSpace(nombre));
                producto_servicio[cant_prodserv] = nombre;
                cant_prodserv++;
                Console.WriteLine("Ingrese las puntuaciones (atención,calidad,precio) del producto/servicio:");
                for (int puntuacion = 0; puntuacion < MAX_PUNTUACIONES; puntuacion++)
                {
                    Console.Write($"Ingrese la puntuación {puntuacion + 1}: ");
                    double puntuacion_ingresada;
                    do
                    {
                        puntuacion_ingresada = double.Parse(Console.ReadLine());
                        if(puntuacion_ingresada < 0 || puntuacion_ingresada > 10)
                        {
                            Console.WriteLine("La puntuación debe estar entre 0 y 10. Intente nuevamente.");
                            Console.Write("--> ");
                        }
                    } while (puntuacion_ingresada < 0 ||puntuacion_ingresada > 10);
                    puntuaciones[cant_prodserv-1, puntuacion] = puntuacion_ingresada;
                }
                Console.WriteLine("Producto/Servicio ingresado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pueden ingresar más productos/servicios.");
            }
        }
    }
}
