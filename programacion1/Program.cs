namespace programacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ingrese su nombre: ");
            //string nombre = Console.ReadLine();
            //Console.Write("Ingrese su apellido: ");
            //string apellido = Console.ReadLine();
            //Console.Write($"Su nombre completo es {nombre} {apellido}, bienvenido!");

            //Console.WriteLine("Ingrese dos números distintos");
            //double n1 = double.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine());

            //if(n1 > n2)
            //{
            //    Console.WriteLine($"El número {n1} es el mayor de los dos.");
            //} else if (n1 < n2)
            //{
            //    Console.WriteLine($"El número {n2} es el mayor de los dos.");
            //}
            //else
            //{
            //    Console.WriteLine($"Los números son iguales!");
            //}

            //Console.Write("Los múltiplos de 3 son: ");
            //for(int n = 1; n <= 30; n++)
            //{
            //    if(n % 3 == 0)
            //    {
            //        Console.Write($"{n} ");
            //    }
            //}

            //int contador = 0;
            //for (int n = 1; n <= 10; n++)
            //{
            //    if (n % 2 == 0)
            //    {
            //        contador++;
            //    }
            //}
            //Console.WriteLine($"Entre el 1 y el 10 hay {contador} pares.");

            //Console.WriteLine("Ingrese un número");
            //string num = Console.ReadLine();
            //bool esDigito = false;
            //int i = 0;
            //while(i<num.Length && !esDigito)
            //{
            //    if (num[i] >= '1' && num[i] <= '9')
            //    {
            //        esDigito = true;
            //    }
            //    i++;
            //}
            //if(esDigito)
            //{
            //    Console.WriteLine("El dato ingresado es un número");
            //} else
            //{
            //    Console.WriteLine("El dato ingresado es un string");
            //}
            /* --------------------------------------------------------------------------------------------- */

            // TP Nº3

            //PUNTO 1

            //1a
            //Console.Write("Ingrese un número para verificar si es par o impar: ");
            //int a = int.Parse(Console.ReadLine());
            //if(a % 2 ==  0)
            //{
            //    Console.WriteLine($"El número {a} es par.");
            //}
            //else
            //{
            //    Console.WriteLine($"El número {a} es impar.");
            //}

            //1b
            //Console.WriteLine("Ingrese dos números para calcular su suma");
            //double n1 = double.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine());
            //double suma = n1 + n2;
            //Console.WriteLine($"La suma entre {n1} y {n2} es {suma}.");

            //1c
            //Console.Write("Ingrese un valor para calcular su 30%: ");
            //double x = double.Parse(Console.ReadLine());
            //double porcentaje = (x * 30) / 100;
            //Console.WriteLine($"El 30% de {x} es {porcentaje}");

            //1d
            //Console.WriteLine("Ingrese dos números para verificar cual es el mayor");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //if(num1 > num2)
            //{
            //    Console.WriteLine($"El número {num1} es mayor que {num2}");
            //} else if(num1 < num2)
            //{
            //    Console.WriteLine($"El número {num1} es menor que {num2}");
            //} else
            //{
            //    Console.WriteLine($"Los números son iguales");
            //}

            //1e
            //Console.WriteLine("Ingrese una distancia expresada en metros");
            //double dm = double.Parse(Console.ReadLine());
            //double dm_pulgadas = dm * 39.37;
            //double dm_pies = dm_pulgadas / 12;
            //Console.WriteLine($"La distancia ingresada equivale a {dm_pies:f2} pies");

            //1f
            //int bill_50 = 0;
            //int bill_25 = 0;
            //int bill_10 = 0;
            //int bill_5 = 0;
            //int bill_1 = 0;
            //Console.WriteLine("Ingrese el precio del objeto y con cuánto va a pagar");
            //int c = int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());
            //int vuelto = p - c;
            //if(vuelto == 0)
            //{
            //    Console.WriteLine("No hay vuelto, pagó justo");
            //} else
            //{
            //    bill_50 = vuelto / 50;
            //    vuelto = vuelto % 50;
            //    bill_25 = vuelto / 25;
            //    vuelto = vuelto % 25;
            //    bill_10 = vuelto / 10;
            //    vuelto = vuelto % 10;
            //    bill_5 = vuelto / 5;
            //    vuelto = vuelto % 5;
            //    bill_1 = vuelto;
            //}
            //Console.WriteLine($"Para el vuelto debe dar {bill_50} billetes de 50, {bill_25} billetes de 25, {bill_10} billetes de 10, {bill_5} billetes de 5 y {bill_1} billetes de 1");

            //1g
            //double resultado = 0;
            //Console.WriteLine("Ingrese tres números");
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //if((a-b) > c)
            //{
            //    resultado = a * b;
            //} else
            //{
            //    resultado = a / b;
            //}
            //Console.WriteLine(resultado);

            //1h
            //Console.Write("Ingrese su clase de socio de obra social: ");
            //char clase_socio = char.Parse(Console.ReadLine());
            //if (clase_socio == 'A' || clase_socio == 'B' || clase_socio == 'C')
            //{
            //    double descuento = 0;
            //    Console.Write("Ingrese el costo del tratamiento: ");
            //    double costo_tratamiento = double.Parse(Console.ReadLine());
            //    switch (clase_socio)
            //    {
            //        case 'A':
            //            descuento = (costo_tratamiento * 50) / 100;
            //            costo_tratamiento = costo_tratamiento - descuento;
            //            break;
            //        case 'B':
            //            descuento = (costo_tratamiento * 35) / 100;
            //            costo_tratamiento = costo_tratamiento - descuento;
            //            break;
            //        default:
            //            break;
            //    }
            //    Console.WriteLine($"El socio de clase {clase_socio} debe abonar {costo_tratamiento} pesos en efectivo.");
            //} else
            //{
            //    Console.WriteLine("La clase de socio ingresada no existe en la obra social.");
            //}

            //1i
            //Console.Write("Ingrese un entero que represente un año: ");
            //int año = int.Parse(Console.ReadLine());
            //if((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            //{
            //    Console.WriteLine("El año ingresado corresponde a uno bisiesto");
            //} else
            //{
            //    Console.WriteLine("El año ingresado no corresponde a uno bisiesto.");
            //}

            //PUNTO 2
            //Console.WriteLine("Ingrese las tres notas correspondientes al alumno:");
            //double nota_p1 = double.Parse(Console.ReadLine());
            //double nota_p2 = double.Parse(Console.ReadLine());
            //double nota_proyecto = double.Parse(Console.ReadLine());

            //double suma_notas = nota_p1 + nota_p2 + nota_proyecto;
            //double promedio = suma_notas / 3;

            //if (promedio < 4)
            //{
            //    Console.WriteLine("El alumno no cursa.");
            //} else if(promedio >= 4 && promedio < 6) {
            //    Console.WriteLine("El alumno cursa y rinde examen final.");
            //} else if (promedio >= 6 && promedio <= 10)
            //{
            //    Console.WriteLine("El alumno cursa y promociona.");
            //}

            //PUNTO 3
            /*
            dia
            mese
            año
            edad_actual 
            */

            //PUNTO 4


            //PUNTO 5
            //            Console.WriteLine("Los siguientes datos son necesarios para confeccionar la factura.");
            //            Console.Write("Ingrese la forma de pago (E:efectivo; T:tarjeta; O:otro): ");
            //            char forma_pago = char.Parse(Console.ReadLine());
            //            Console.Write("Ingrese el monto de la compra: ");
            //            double monto_compra = double.Parse(Console.ReadLine());
            //            double descuento = 0;
            //            double total_pago = monto_compra;

            //            if(forma_pago == 'E' || forma_pago == 'e')
            //            {
            //                descuento = (monto_compra * 20) / 100;
            //                total_pago -= descuento;
            //            } else if((forma_pago == 'T' || forma_pago == 't') && monto_compra > 25000)
            //            {
            //                descuento = (monto_compra * 10) / 100;
            //                total_pago -= descuento;
            //            }
            //            Console.WriteLine(@$"
            //Forma de pago: (E: efectivo; T: tarjeta; O: otro): {forma_pago}
            //Monto de la compra:                                {monto_compra}
            //Descuento:                                         {descuento}
            //Total a pagar:                                     {total_pago}
            //            ");

            //PUNTO 6
            //Console.Write("Ingrese la medida del lado de un cuadrado: ");
            //double lado_cuadrado = double.Parse(Console.ReadLine());
            //Console.Write("Ingrese una opción: 1.perímetro del cuadrado 2.área del cuadrado ; ");
            //int opcion = int.Parse(Console.ReadLine());
            //if( opcion == 1)
            //{
            //    Console.WriteLine($"El perímetro del cuadrado es {lado_cuadrado * 4}.");
            //} else if (opcion == 2)
            //{
            //    Console.WriteLine($"El área del cuadrado es {lado_cuadrado * lado_cuadrado}.");
            //}

            //PUNTO 7
            //double n_mayor = 0;
            //double n_menor = 0;
            //Console.WriteLine("Ingrese tres números distintos");
            //double n1 = double.Parse(Console.ReadLine()); 
            //double n2 = double.Parse(Console.ReadLine()); 
            //double n3 = double.Parse(Console.ReadLine());
            //if(n1 > n2)
            //{
            //    n_mayor = n1;
            //    n_menor = n2;
            //} else if(n2 > n3)
            //{
            //    n_menor = n1;
            //    n_mayor = n2;
            //} else if(n3 > n1)
            //{
            //    n_mayor = n3;
            //} else
            //{

            //}

            //PUNTO 8
            //Console.WriteLine("Ingrese la medida de los tres lados del triángulo");
            /*
            triangulo equilatero 3 lados iguales
            triangulo isosceles 2 lados iguales 1 distinto
            triangulo escaleno 3 lados distintos
            */
            //double lado_1 = double.Parse(Console.ReadLine());
            //double lado_2 = double.Parse(Console.ReadLine());
            //double lado_3 = double.Parse(Console.ReadLine());
            //if( lado_1 == lado_2 && lado_2 == lado_3)
            //{
            //    Console.WriteLine("El triángulo es Equilátero.");
            //} else if(lado_1 == lado_2 || lado_2 == lado_3 || lado_1 == lado_3)
            //{
            //    Console.WriteLine("El triángulo es Isósceles.");
            //}
            //else
            //{
            //    Console.WriteLine("El triángulo es Escaleno.");
            //}




            //-----------------------------EJERCICIOS PRACTICA--------------------------------------------------

            //registrar la nota de N alumnos y mostrar el alumno con el mejor promedio y el peor  
            /*  
            alumnos: es un arreglo de alumnos y dentro de los alumnos hay un arreglo de notas (3 notas por alumno)  
            nota: ingresada por el usuario  
            cant_alumnos: ingresada por el usuario  
            suma_notas: suma de las notas de cada alumno  
            promedio: promedio de las notas de cada alumno  
            mejor_promedio: el mejor promedio  
            peor_promedio: el peor promedio  
            */
            int cant_alumnos;
            Console.Write("Ingrese la cantidad de alumnos: ");
            cant_alumnos = int.Parse(Console.ReadLine());
            object[,] alumnos_notas = new object[cant_alumnos, 4];
            double promedio_mayor = 0;
            double promedio_menor = 0;
            for (int i = 0; i < cant_alumnos; i++)  
            {
                string nombre;
                do
                {
                    Console.Write("Ingrese el nombre del alumno: ");
                    nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
                    }
                } while(string.IsNullOrWhiteSpace(nombre));
                alumnos_notas[i, 0] = nombre;
                double nota;
                Console.WriteLine("Ingrese sus notas:");
                for (int j = 1; j < 4; j++)
                {
                    do
                    {
                        nota = double.Parse(Console.ReadLine());
                        if (nota < 0 || nota > 10 || nota.ToString() == "")
                        {
                            Console.WriteLine("La nota debe ser un número entre 0 y 10. Intente nuevamente.");
                        }
                    } while (nota < 0 || nota > 10 || nota.ToString() == "");
                    alumnos_notas[i,j] = nota;
                }
                double promedio_alumno = CalcularPromedio(alumnos_notas, i); 
                if (i == 0 || promedio_alumno > promedio_mayor)
                {
                    promedio_mayor = promedio_alumno;
                }
                if (i == 0 || promedio_alumno < promedio_menor)
                {
                    promedio_menor = promedio_alumno;
                }
            }
            Console.WriteLine($"El mejor promedio es: {promedio_mayor:F2}");
            Console.WriteLine($"El peor promedio es: {promedio_menor:F2}");
        }

        //metodo para calcular el promedio de un alumno
        private static double CalcularPromedio(object[,] alumnos_notas, int indice_alumno)
        {
            double suma_notas = 0;
            for (int j = 1; j < 4; j++)
            {
                suma_notas += (double) alumnos_notas[indice_alumno, j]; // Fix: Access the specific row and column  
            }
            return (double) suma_notas / 3;
        }

    }
}

