namespace ejercicio1_parcial
{
    internal class Program
    {
        const int MAX_PRODUCTOS = 5;
        const int MAX_SUCURSALES = 3;
        static string[] productos = new string[MAX_PRODUCTOS];
        static double[,] precios = new double[MAX_PRODUCTOS, MAX_SUCURSALES];
        static int cant_productos = 0;
        static int opcion = 0;
        static void Main(string[] args)
        {
            int valorSalir = 6;
            while (opcion != valorSalir)
            {
                //Llamada al menú
                Console.WriteLine("------------------ Menú para inventario de productos ------------------");
                Console.WriteLine("------------------ 1. Agregar producto y precio");
                Console.WriteLine("------------------ 2. Mostrar información de productos");
                Console.WriteLine("------------------ 3. Promedio precio de un producto");
                Console.WriteLine("------------------ 4. Editar datos de un producto");
                Console.WriteLine("------------------ 5. Precio mas caro de producto");
                Console.WriteLine("------------------ 6. Salir del programa");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.Write("Ingrese una opción --> ");
                opcion = int.Parse(Console.ReadLine());

                //Lógica para opciones del menú
                switch (opcion)
                {
                    case 1:
                        // Lógica para agregar producto
                        agregarProducto();
                        break;
                    case 2:
                        // Lógica para mostrar información
                        mostrarInformacion();
                        break;
                    case 3:
                        // Lógica para buscar más stock o mejor precio
                        promedioProducto();
                        break;
                    case 4:
                        // Lógica para editar datos
                        editarDatos();
                        break;
                    case 5:
                        // Lógica para precio más caro de un producto
                        precioMasCaro();
                        break;
                    case 6:
                        // Lógica para salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        // Opción no válida
                        Console.WriteLine("Opción no válida. Por favor, elija una opción del menú.");
                        break;
                }
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
        private static void precioMasCaro()
        {
            double precioMaximo = -1;
            string nombre_producto = "";
            int num_sucursal = -1;
            for (int producto = 0; producto < MAX_PRODUCTOS; producto++)
            {
                for (int sucursal = 0; sucursal < MAX_SUCURSALES; sucursal++)
                {
                    if (precios[producto, sucursal] > precioMaximo)
                    {
                        precioMaximo = precios[producto, sucursal];
                        nombre_producto = productos[producto];
                        num_sucursal = sucursal;
                    }
                }
            }
            Console.WriteLine($"El precio más caro de los productos es: ${precioMaximo:F2} de {nombre_producto} en la sucursal número {num_sucursal + 1}.");
        }

        private static void editarDatos()
        {
            Console.Write("Ingrese el índice del producto a editar: ");
            int indice_producto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la sucursal que quiere modificar: ");
            int num_sucursal = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nuevo precio: ");
            double nuevo_precio = double.Parse(Console.ReadLine());
            if (indice_producto >= 0 && indice_producto < cant_productos && num_sucursal >= 0 && num_sucursal < MAX_SUCURSALES)
            {
                precios[indice_producto, num_sucursal] = nuevo_precio;
                Console.WriteLine("Precio actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Índice de producto o sucursal no válido.");
            }
        }

        private static void promedioProducto()
        {
            Console.Write("Ingrese el indice del producto para calcular el promedio: ");
            int indice_producto = int.Parse(Console.ReadLine());
            if (indice_producto >= 0 && indice_producto < cant_productos)
            {
                double suma = 0;
                for (int i = 0; i < MAX_SUCURSALES; i++)
                {
                    suma += precios[indice_producto, i];
                }
                double promedio = suma / MAX_SUCURSALES;
                Console.WriteLine($"El precio promedio del producto {productos[indice_producto]} es: ${promedio:F2}");
            }
            else
            {
                Console.WriteLine("Índice de producto no válido.");
            }
        }

        private static void mostrarInformacion()
        {
            for (int i = 0; i < cant_productos; i++)
            {
                Console.Write($"Producto: {productos[i]} --> ");
                for (int j = 0; j < MAX_SUCURSALES; j++)
                {
                    Console.Write($"Sucursal {j + 1}: ${precios[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void agregarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre_producto = Console.ReadLine();
            if (cant_productos < MAX_PRODUCTOS)
            {
                productos[cant_productos] = nombre_producto;
                cant_productos++;
                for (int sucursal = 0; sucursal < MAX_SUCURSALES; sucursal++)
                {
                    Console.Write($"Ingrese el precio del producto en la sucursal {sucursal + 1}: ");
                    double precio = double.Parse(Console.ReadLine());
                    if (precio < 0)
                    {
                        Console.WriteLine("El precio no puede ser negativo. Intente nuevamente.");
                        sucursal--;
                    }
                    else
                    {
                        precios[cant_productos - 1, sucursal] = precio;
                    }
                }
                Console.WriteLine("Producto agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más productos.");
            }
        }
    }
}
