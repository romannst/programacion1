namespace ejercicio2_parcial
{
    internal class Program
    {
        //Menú:
        //1. agregar alumno y sus notas //listo
        //2. mostrar alumnos y sus notas //listo
        //3. editar notas de un alumno //listo
        //4. calcular promedio de un alumno //listo
        //5. mostrar mejor promedio //listo
        //6. salir //listo
        //Extras:
        //validar notas en el rango 0-10 //listo
        //validar nombre vacío //listo

        //agregar funcionalidad para eliminar un alumno

        const int MAX_ALUMNOS = 5;
        const int MAX_NOTAS = 3;
        static string[] nombres_alumnos = new string[MAX_ALUMNOS];
        static double[,] notas_alumnos = new double[MAX_ALUMNOS, MAX_NOTAS];
        static int cant_alumnos = 0;
        static int opcion = 0;

        static void Main(string[] args)
        {
            int valorSalir = 6;
            while (opcion != valorSalir)
            {
                Console.WriteLine("Menú:");
                //opciones del menú
                Console.WriteLine("1. Agregar alumno y sus notas");
                Console.WriteLine("2. Mostrar alumnos y sus notas");
                Console.WriteLine("3. Editar notas de un alumno");
                Console.WriteLine("4. Calcular promedio de un alumno");
                Console.WriteLine("5. Mostrar mejor promedio");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());

                //método seleccionar la opción del menú
                seleccionOpciones(opcion);
            }
        }

        private static void seleccionOpciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ejecutando la función 1...");
                    agregarAlumno();
                    break;
                case 2:
                    Console.WriteLine("Ejecutando la función 2...");
                    mostrarAlumnos();
                    break;
                case 3:
                    Console.WriteLine("Ejecutando la función 3...");
                    editarNotas();
                    break;
                case 4:
                    Console.WriteLine("Ejecutando la función 4...");
                    calcularPromedio();
                    break;
                case 5:
                    Console.WriteLine("Ejecutando la función 5...");
                    mostrarMejorPromedio();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción del menú.");
                    break;
            }
            Console.WriteLine();
        }

        private static void agregarAlumno()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre_alumno;
            do
            {
                nombre_alumno = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre_alumno))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                    Console.Write("Ingrese el nombre del alumno: ");
                }
            } while (string.IsNullOrWhiteSpace(nombre_alumno));
            if (cant_alumnos < MAX_ALUMNOS)
            {
                nombres_alumnos[cant_alumnos] = nombre_alumno;
                cant_alumnos++;
                for (int notas = 0; notas < MAX_NOTAS; notas++)
                {
                    Console.Write("Ingrese la nota del alumno: ");
                    double nota_alumno = double.Parse(Console.ReadLine());
                    if (nota_alumno >= 0 && nota_alumno <= 10)
                    {
                        notas_alumnos[cant_alumnos - 1, notas] = nota_alumno;
                    }
                    else
                    {
                        Console.WriteLine("Nota no válida. Debe estar entre 0 y 10.");
                        notas--;
                    }
                }
            }
            else
            {
                Console.WriteLine("No se pueden agregar más alumnos. Se ha alcanzado el límite máximo de alumnos.");
            }
        }

        private static void mostrarAlumnos()
        {
            Console.WriteLine("-------Lista de alumnos y sus notas-------");
            for (int alumno = 0; alumno < cant_alumnos; alumno++)
            {
                Console.WriteLine($"Alumno {alumno + 1} - {nombres_alumnos[alumno]}");
                for (int notas = 0; notas < MAX_NOTAS; notas++)
                {
                    Console.WriteLine($"Nota {notas + 1}: {notas_alumnos[alumno, notas]}");
                }
            }
            Console.WriteLine("-------------------------------------------");
        }

        private static void editarNotas()
        {
            Console.Write("Ingrese el número del alumno que desea editar: ");
            int alumnoEditar = int.Parse(Console.ReadLine());
            //considera que el numero del alumno debe ser -1 porque el array empieza en 0
            if (validarAlumno(alumnoEditar))
            {
                for (int notas = 0; notas < MAX_NOTAS; notas++)
                {
                    Console.Write("Ingrese la nueva nota del alumno: ");
                    double nota_alumno = double.Parse(Console.ReadLine());
                    if (nota_alumno >= 0 && nota_alumno <= 10)
                    {
                        notas_alumnos[alumnoEditar - 1, notas] = nota_alumno;
                    }
                    else
                    {
                        Console.WriteLine("Nota no válida. Debe estar entre 0 y 10.");
                        notas--;
                    }
                }

                Console.WriteLine("Información actualizada!");
                Console.WriteLine($"Alumno {alumnoEditar + 1}: {nombres_alumnos[alumnoEditar]}");
                Console.WriteLine("-------Notas-------");
                for (int notas = 0; notas < MAX_NOTAS; notas++)
                {
                    Console.WriteLine($"Nota {notas + 1}: {notas_alumnos[alumnoEditar, notas]}");
                }
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("El número de alumno ingresado no existe.");
            }
        }

        private static bool validarAlumno(int alumnoEditar)
        {
            for (int alumno = 0; alumno < cant_alumnos; alumno++)
            {
                if (alumnoEditar == alumno)
                {
                    return true;
                }
            }
            return false;
        }

        private static void calcularPromedio()
        {
            Console.Write("Ingrese el número del alumno que desea calcular el promedio: ");
            int alumnoPromedio = int.Parse(Console.ReadLine());
            //considera que el numero del alumno debe ser -1 porque el array empieza en 0
            if (alumnoPromedio >= 0 || alumnoPromedio <= cant_alumnos - 1)
            {
                double sumaNotas = 0;
                for (int notas = 0; notas < MAX_NOTAS; notas++)
                {
                    sumaNotas += notas_alumnos[alumnoPromedio - 1, notas];
                }
                double promedio = sumaNotas / MAX_NOTAS;
                Console.WriteLine($"El promedio del alumno {alumnoPromedio + 1} es: {promedio:F2}");
                if (promedio >= 8)
                {
                    Console.WriteLine("Felicidades, Sigue así!");
                }
                else if (promedio >= 4)
                {
                    Console.WriteLine("Vas bien, pero puedes mejorar!");
                }
                else
                {
                    Console.WriteLine("Necesitas mejorar, ánimos!");
                }
            }
            else
            {
                Console.WriteLine("Número de alumno no válido.");
            }
        }

        private static void mostrarMejorPromedio()
        {
            double mejorPromedio = 0;
            int mejorAlumno = 0;
            string nombreMejorAlumno = "";
            for (int alumno = 0; alumno < cant_alumnos; alumno++)
            {
                double sumaNotas = 0;
                for (int nota = 0; nota < MAX_NOTAS; nota++)
                {
                    sumaNotas += notas_alumnos[alumno, nota];
                }
                double promedio = sumaNotas / MAX_NOTAS;
                if (promedio > mejorPromedio)
                {
                    mejorPromedio = promedio;
                    //el mejor alumno es un numero más 1 porque el array empieza en 0
                    mejorAlumno = alumno + 1;
                    nombreMejorAlumno = nombres_alumnos[alumno];
                }
            }
            Console.WriteLine($"El mejor promedio es del alumno {mejorAlumno} {nombreMejorAlumno} con un promedio de {mejorPromedio:F2}.");
            Console.WriteLine("Felicidades!");
        }
    }
}
