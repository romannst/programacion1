namespace ejercicios_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una opcion segun el ejercicio que desee ejecutar.");
            Console.WriteLine("1. -> Ejercicio 1");
            Console.WriteLine("2. -> Ejercicio 2");
            Console.WriteLine("3. -> Ejercicio 3");
            Console.WriteLine("4. -> Ejercicio 4");
            Console.WriteLine("5. -> Ejercicio 5");
            Console.WriteLine("Cualquier otra tecla para salir.");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    ejercicio1();
                    break;
                case "2":
                    ejercicio2();
                    break;
                case "3":
                    ejercicio3();
                    break;
                case "4":
                    ejercicio4();
                    break;
                case "5":
                    ejercicio5();
                    break;
                default:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }
        }
        private static void ejercicio1()
        {
            double[] gastos_diarios = new double[10];
            double suma_gastos = 0;
            Console.WriteLine("Ingrese los gastos diarios de la semana.");
            for (int i = 0; i < gastos_diarios.Length; i++)
            {
                Console.Write($"Gastos del dia {i + 1}: ");
                gastos_diarios[i] = double.Parse(Console.ReadLine());
                suma_gastos += gastos_diarios[i];
            }
            double promedio_diario = suma_gastos / gastos_diarios.Length;
            Console.WriteLine($"El gasto promedio diario de la semana es de ${promedio_diario:F2} pesos.");
        }
        private static void ejercicio2()
        {
            double[] valor_ventas_diarias = new double[7];
            double suma_ventas = 0;
            Console.WriteLine("Ingrese las ventas diarias durante la semana.");
            for (int i = 0; i < valor_ventas_diarias.Length; i++)
            {
                Console.Write($"Valor total de ventas del dia {i + 1}: ");
                valor_ventas_diarias[i] = double.Parse(Console.ReadLine());
                suma_ventas += valor_ventas_diarias[i];
            }
            double promedio_diario = suma_ventas / valor_ventas_diarias.Length;
            int dias_mayor_promedio = 0;
            for (int i = 0; i < valor_ventas_diarias.Length; i++)
            {
                if (valor_ventas_diarias[i] > promedio_diario)
                {
                    dias_mayor_promedio++;
                }
            }
            Console.WriteLine($"El valor de ventas promedio diario de la semana es de ${promedio_diario:F2} pesos.");
            Console.WriteLine($"La cantidad de dias que superaron el promedio es de {dias_mayor_promedio} dias.");
        }
        private static void ejercicio3()
        {

        }
        private static void ejercicio4()
        {

        }
        private static void ejercicio5()
        {

        }
    }
}
