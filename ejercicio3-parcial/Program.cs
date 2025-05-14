namespace ejercicio3_parcial
{
    internal class Program
    {
        /*
        Menu:
        1-Agregar
        2-Mostrar
        3-Promedio
        4-Editar
        5-MasCalurosa
        6-Salir
        */

        const int MAX_CIUDADES = 5;
        const int MAX_TEMP = 3;
        static string[] ciudades = new string[MAX_CIUDADES];
        static int[,] temp_ciudades = new int[MAX_CIUDADES, MAX_TEMP];
        static int cant_ciudades = 0;
        static int opcion = 0;

        static void Main(string[] args)
        {
            int valor_salir = 7;
            while (opcion != valor_salir)
            {
                Console.WriteLine("Menú:");
                //opciones del menú
                Console.WriteLine("1. Agregar ciudad y sus temperaturas");
                Console.WriteLine("2. Mostrar ciudad y sus temperaturas");
                Console.WriteLine("3. Calcular promedio de una ciudad");
                Console.WriteLine("4. Editar temperatura de una ciudad");
                Console.WriteLine("5. Mostrar la ciudad mas calurosa");
                Console.WriteLine("6. Calcular promedio de las ciudades");
                Console.WriteLine("7. Salir");

                Console.Write("Ingrese una opcion del menu: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cant_ciudades == MAX_CIUDADES)
                        {
                            Console.WriteLine("No se pueden agregar mas ciudades, la lista esta llena.");
                        }
                        else
                        {
                            agregarCiudad();
                        }
                        break;
                    case 2:
                        if (cant_ciudades == 0)
                        {
                            Console.WriteLine("No se han ingresado ciudades, la lisa esta vacia.");
                        }
                        else
                        {
                            mostrarCiudades();
                        }
                        break;
                    case 3:
                        if (cant_ciudades == 0)
                        {
                            Console.WriteLine("No se han ingresado ciudades, la lisa esta vacia.");
                        }
                        else
                        {
                            promedioCiudad();
                        }
                        break;
                    case 4:
                        if (cant_ciudades == 0)
                        {
                            Console.WriteLine("No se puede editar nada, ingrese alguna ciudad.");
                        }
                        else
                        {
                            editarCiudad();
                        }
                        break;
                    case 5:
                        if (cant_ciudades == 0)
                        {
                            Console.WriteLine("No se han ingresado ciudades, la lisa esta vacia.");
                        }
                        else
                        {
                            masCalurosa();
                        }
                        break;
                    case 6:
                        if (cant_ciudades == 0)
                        {
                            Console.WriteLine("No se han ingresado ciudades, la lisa esta vacia.");
                        }
                        else
                        {
                            promedioCiudades();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        break;
                }
            }

        }

        private static void masCalurosa()
        {
            int temp_mayor = -100;
            string ciudad_mayor = "";
            for (int ciudad = 0; ciudad < cant_ciudades; ciudad++)
            {
                for (int temperatura = 0; temperatura < MAX_TEMP; temperatura++)
                {
                    int temp_actual = temp_ciudades[ciudad, temperatura];
                    if (temp_actual > temp_mayor)
                    {
                        temp_mayor = temp_actual;
                        ciudad_mayor = ciudades[ciudad];
                    }
                }
            }
            Console.WriteLine($"La ciudad mas calurosa es {ciudad_mayor} que llego a los {temp_mayor}°C.");
        }

        private static void editarCiudad()
        {
            for (int ciudad = 0; ciudad < cant_ciudades; ciudad++)
            {
                Console.WriteLine($"Ciudad nro. {ciudad + 1}: {ciudades[ciudad]}");
            }
            Console.Write("Ingrese el nombre de la ciudad a editar: ");
            string nombre_ciudad = Console.ReadLine().ToUpper();
            bool existe = false;
            int i_ciudad = 0;
            while (i_ciudad < cant_ciudades && !existe)
            {
                if (ciudades[i_ciudad] == nombre_ciudad)
                {
                    existe = true;
                }
                else
                {
                    i_ciudad++;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El nombre de la ciudad ingresada no existe.");
            }
            else
            {
                for (int temperatura = 0; temperatura < MAX_TEMP; temperatura++)
                {
                    Console.WriteLine($"Temperatura nro. {temperatura + 1}: {temp_ciudades[i_ciudad, temperatura]}°C");
                    Console.Write($"Ingrese el nuevo valor de la temperatura: ");
                    int nueva_temp = int.Parse(Console.ReadLine());
                    temp_ciudades[i_ciudad, temperatura] = nueva_temp;
                }
                Console.WriteLine("La temperaturas fueron modificadas correctamente.");
            }
        }

        private static void promedioCiudad()
        {
            for (int ciudad = 0; ciudad < cant_ciudades; ciudad++)
            {
                Console.WriteLine($"Ciudad nro. {ciudad + 1}: {ciudades[ciudad]}");
            }
            Console.Write("Ingrese el nombre de la ciudad para calcular su promedio: ");
            string nombre_ciudad = Console.ReadLine().ToUpper();
            bool existe = false;
            int i_ciudad = 0;
            while (i_ciudad < cant_ciudades && !existe)
            {
                if (ciudades[i_ciudad] == nombre_ciudad)
                {
                    existe = true;
                }
                else
                {
                    i_ciudad++;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El nombre de la ciudad ingresada no existe.");
            }
            else
            {
                int suma = 0;
                for (int temperatura = 0; temperatura < MAX_TEMP; temperatura++)
                {
                    suma += temp_ciudades[i_ciudad, temperatura];
                }
                int promedio = suma / MAX_TEMP;
                Console.WriteLine($"La temperatura promedio de la ciudad de {ciudades[i_ciudad]} es {promedio}°C.");
            }
        }

        private static void promedioCiudades()
        {
            for (int ciudad = 0; ciudad < cant_ciudades; ciudad++)
            {
                int suma = 0;
                for (int temperatura = 0; temperatura < MAX_TEMP; temperatura++)
                {
                    suma += temp_ciudades[ciudad, temperatura];
                }
                int promedio = suma / MAX_TEMP;
                Console.WriteLine($"La temperatura promedio de la ciudad de {ciudades[ciudad]} es {promedio}°C.");
            }
        }

        private static void mostrarCiudades()
        {
            for (int ciudad = 0; ciudad < cant_ciudades; ciudad++)
            {
                Console.WriteLine($"Ciudad: {ciudades[ciudad]}");
                for (int temp = 0; temp < MAX_TEMP; temp++)
                {
                    Console.WriteLine($"Temperatura nro. {temp + 1}: {temp_ciudades[ciudad, temp]}");
                }
                Console.WriteLine();
            }
        }

        private static void agregarCiudad()
        {
            Console.Write("Ingrese el nombre de la ciudad: ");
            string nombre_ciudad;
            do
            {
                nombre_ciudad = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre_ciudad))
                {
                    Console.Write("El nombre ingresado es invalido. Ingrese nuevamente: ");
                }
            } while (string.IsNullOrWhiteSpace(nombre_ciudad));
            ciudades[cant_ciudades] = nombre_ciudad.ToUpper();
            cant_ciudades++;
            for (int temperatura = 0; temperatura < MAX_TEMP; temperatura++)
            {
                Console.Write($"Ingrese la temperatura {temperatura + 1} para la ciudad: ");
                temp_ciudades[cant_ciudades - 1, temperatura] = int.Parse(Console.ReadLine());
            }
        }
    }
}