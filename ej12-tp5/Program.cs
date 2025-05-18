namespace ej12_tp5
{
    internal class Program
    {
        //PUNTO 12
        //Preguntar tamaño del arreglo
        //Menu:
        //  1-agregar elemento
        //  2-borrar elemento
        //  3-mostrar elementos del arreglo
        //  4-salir
        static int[] arreglo_nums;
        static int maxPos;
        static int ultPos = -1;
        static int opcion = 0;
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int tam_arreglo = int.Parse(Console.ReadLine());
            while (tam_arreglo <= 0)
            {
                Console.Write("El tamaño del arreglo debe ser mayor a 0. Intente nuevamente: ");
                tam_arreglo = int.Parse(Console.ReadLine());
            }
            arreglo_nums = new int[tam_arreglo];
            maxPos = tam_arreglo - 1;
            ultPos = -1;
            int opcion_salir = 4;
            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Borrar elemento");
                Console.WriteLine("3. Mostrar elementos del arreglo");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese la opción deseada: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        agregarElemento();
                        break;
                    case 2:
                        borrarElemento();
                        break;
                    case 3:
                        mostarElementos();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            } while (opcion != opcion_salir);
        }

        private static void mostarElementos()
        {
            if (ultPos == -1)
            {
                Console.WriteLine("El arreglo está vacío.");
            }
            else
            {
                Console.WriteLine("Elementos del arreglo:");
                Console.Write("| ");
                for (int i = 0; i <= ultPos; i++)
                {
                    Console.Write(arreglo_nums[i] + " | ");
                }
                Console.WriteLine();
            }
        }
        private static void borrarElemento()
        {
            //si el arreglo esta vacio (ultPos == -1) no se puede borrar nada
            if (ultPos == -1)
            {
                Console.WriteLine("No hay elementos para borrar.");
            }
            //sino si el arreglo tiene elementos
            else
            {
                Console.WriteLine("Elementos del arreglo:");
                for (int i = 0; i <= ultPos; i++)
                {
                    Console.Write(arreglo_nums[i] + " | ");
                }
                Console.Write("Ingrese el número a borrar: ");
                int numeroABorrar = int.Parse(Console.ReadLine());
                int i_actual = 0;
                bool encontre = false;
                //busco el elemento a borrar desde el primer indice hasta el ultimo y guardo su posicion
                do
                {
                    if (arreglo_nums[i_actual] == numeroABorrar)
                    {
                        encontre = true;
                    }
                    else
                    {
                        i_actual++;
                    }
                //mientras el indice actual sea menor o igual al ultimo del arreglo y no se haya encontrado el elemento a borrar
                } while (i_actual <= ultPos && !encontre);
                //si encontre el elemento a borrar
                if (encontre)
                {
                //recorro desde el indice donde se encontraba el elemento a borrar hasta el ultimo agregado (decreciendo)
                    for (int i = i_actual; i < ultPos; i++)
                    {
                    //voy desplazando los elementos del arreglo una posicion a la izquierda
                        arreglo_nums[i] = arreglo_nums[i + 1];
                    }
                    ultPos--;
                    Console.WriteLine("Elemento borrado.");
                }
                //si no encontre el elemento a borrar
                else
                {
                    Console.WriteLine("El número no se encuentra en el arreglo.");
                }
            }
        }
        private static void agregarElemento()
        {
            if (ultPos == maxPos)
            {
                Console.WriteLine("No se pueden agregar más elementos al arreglo.");
            } else
            {
                Console.Write("Ingrese el número a agregar: ");
                int numeroNuevo = int.Parse(Console.ReadLine());
                if (ultPos == -1)
                {
                    arreglo_nums[0] = numeroNuevo;
                    ultPos = 0;
                } else
                {
                    int i_actual = 0;
                    bool encontre = false;
                    do
                    {
                    //compara cada elemento desde el indice 0 hasta el ultimo con el numero nuevo (compara si el numero del arreglo es mayor al nuevo)
                        if (arreglo_nums[i_actual] > numeroNuevo)
                        {
                            encontre = true;
                        }
                        //si el numero del arreglo es menor al nuevo, sigue comparando con el proximo
                        else
                        {
                            i_actual++;
                        }
                    //mientra el indice actual sea menor o igual al ultimo del arreglo y no se haya encontrado un numero mayor al nuevo
                    } while (i_actual <= ultPos && !encontre);
                    //si encontre un numero mayor al nuevo
                    if (encontre)
                    {
                    //recorro desde el ultimo agregado hasta el indice donde se encontraba el elemento mayor al nuevo (decreciendo)
                        for (int i = ultPos; i >= i_actual; i--)
                        {
                        //desplaza los elementos del arreglo una posicion a la derecha
                            arreglo_nums[i + 1] = arreglo_nums[i];
                        }
                        //agrego el nuevo elemento en la posicion donde se encontraba el mayor
                        arreglo_nums[i_actual] = numeroNuevo;
                    }
                    //si no encontre un numero mayor al nuevo, lo agrego al final del arreglo
                    else
                    {
                    //agrego el nuevo elemento al final del arreglo
                        arreglo_nums[ultPos + 1] = numeroNuevo;
                    }
                    ultPos++;
                }
            }
        }
    }

}
