using System;

namespace trabajos_practicos
{
    internal class Program
    {
        static int ObtenerDiasDelMes(int mes, int año)
        {
            if (mes == 2) return (año % 400 == 0) || (año % 100 != 0 && año % 4 == 0) ? 29 : 28;
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11) return 30;
            return 31;
        }
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
            //Console.WriteLine("Ingrese su fecha de nacimiento: dd mm aa");
            //int dia_nac = int.Parse(Console.ReadLine());
            //int mes_nac = int.Parse(Console.ReadLine());
            //int año_nac = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la fecha actual: dd mm aa");
            //int dia_act = int.Parse(Console.ReadLine());
            //int mes_act = int.Parse(Console.ReadLine());
            //int año_act = int.Parse(Console.ReadLine());

            //if (año_nac > año_act) 
            //{
            //    Console.WriteLine("El año de nacimiento no puede ser mayor al actual. Fecha Inválida.");
            //}
            //if(mes_nac < 0 || mes_nac > 12 || mes_act < 0 || mes_act > 12)
            //{
            //    Console.WriteLine("El mes no puede ser menor a 0 o mayor a 12. Fecha inválida.");
            //}
            //if(dia_nac >= 1 || dia_nac <= 31 || dia_act >= 1 || dia_act <= 31)
            //{
            //    int[] dias_mes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //    if (mes_nac == 2 && año_nac % 4 == 0 && (año_nac % 100 != 0 || año_nac % 400 == 0))
            //    {
            //        dias_mes[1] = 29; // Año bisiesto
            //    }
            //} else
            //{
            //    Console.WriteLine("El día no puede ser menor a 1 o mayor a 31. Fecha inválida.");
            //}

            //int edad_años = año_act - año_nac;
            //if(mes_act < mes_nac || (mes_act == mes_nac && dia_act < dia_nac))
            //{
            //    edad_años--;
            //}
            //int edad_meses;
            //if (mes_act >= mes_nac)
            //{
            //    edad_meses = mes_act - mes_nac;
            //} else
            //{
            //    edad_meses = 12 - (mes_nac - mes_act);
            //}
            //if(dia_act < dia_nac)
            //{
            //    edad_meses--;
            //}
            //int edad_dias;
            //if(dia_act >= dia_nac)
            //{
            //    edad_dias = dia_act - dia_nac;
            //} else
            //{
            //    int ultimo_dia_mes_anterior = ObtenerDiasDelMes(mes_act - 1, año_act);
            //    edad_dias = (ultimo_dia_mes_anterior - dia_nac) + dia_act;
            //}

            //if (dia_act == dia_nac && mes_act == mes_nac)
            //{
            //    Console.WriteLine($"¡Feliz Cumpleaños! Hoy cumple {edad_años} años.");
            //} else
            //{
            //    Console.WriteLine($"Su edad es: {edad_años} años.");
            //}

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
            //double n_mayor;
            //double n_menor;
            //Console.WriteLine("Ingrese tres números distintos");
            //double n1 = 0;
            //double n2 = 0;
            //double n3 = 0;
            //bool esValido;
            //bool distintos;
            //do
            //{
            //    string input1 = Console.ReadLine();
            //    string input2 = Console.ReadLine();
            //    string input3 = Console.ReadLine();
            //    esValido = double.TryParse(input1, out n1) && double.TryParse(input2, out n2) && double.TryParse(input3, out n3);
            //    distintos = n1 != n2 && n1 != n3 && n2 != n3;
            //    if (!esValido || !distintos)
            //    {
            //        Console.WriteLine("Los números ingresados no son válidos. Intente nuevamente.");
            //    }
            //} while (!esValido || !distintos);

            //if (n1 > n2 && n1 > n3)
            //{
            //    n_mayor = n1;
            //    if (n2 > n3)
            //    {
            //        n_menor = n3;
            //    }
            //    else
            //    {
            //        n_menor = n2;
            //    }
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    n_mayor = n2;
            //    if(n1 > n3)
            //    {
            //        n_menor = n3;
            //    }
            //    else
            //    {
            //        n_menor = n1;
            //    }
            //}
            //else
            //{
            //    n_mayor = n3;
            //    if (n1 > n2)
            //    {
            //        n_menor = n2;
            //    }
            //    else
            //    {
            //        n_menor = n1;
            //    }
            //}
            //Console.WriteLine($"El número mayor es: {n_mayor} y el menor es {n_menor}");

            //PUNTO 8
            //Console.WriteLine("Ingrese la medida de los tres lados del triángulo");
            /*
            triangulo equilatero 3 lados iguales
            triangulo isosceles 2 lados iguales 1 distinto
            triangulo escaleno 3 lados distintos
            */
            //double lado_1 = double.Parse(Console.ReadLine()); //"6" -> 6
            //double lado_2 = double.Parse(Console.ReadLine()); 
            //double lado_3 = double.Parse(Console.ReadLine());
            /*
            variable_1
            variable1
            variableA
            lado_A
            lado_B
            lado_C
             */
            //if ( lado_1 == lado_2 && lado_2 == lado_3)
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
            //int cant_alumnos;
            //Console.Write("Ingrese la cantidad de alumnos: ");
            //cant_alumnos = int.Parse(Console.ReadLine());
            //object[,] alumnos_notas = new object[cant_alumnos, 4];
            //double promedio_mayor = 0;
            //double promedio_menor = 0;
            //for (int i = 0; i < cant_alumnos; i++)
            //{
            //    string nombre;
            //    do
            //    {
            //        Console.Write("Ingrese el nombre del alumno: ");
            //        nombre = Console.ReadLine();
            //        if (string.IsNullOrWhiteSpace(nombre))
            //        {
            //            Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
            //        }
            //    } while (string.IsNullOrWhiteSpace(nombre));
            //    alumnos_notas[i, 0] = nombre;
            //    double nota;
            //    Console.WriteLine("Ingrese sus notas:");
            //    for (int j = 1; j < 4; j++)
            //    {
            //        do
            //        {
            //            nota = double.Parse(Console.ReadLine());
            //            if (nota < 0 || nota > 10 || nota.ToString() == "")
            //            {
            //                Console.WriteLine("La nota debe ser un número entre 0 y 10. Intente nuevamente.");
            //            }
            //        } while (nota < 0 || nota > 10 || nota.ToString() == "");
            //        alumnos_notas[i, j] = nota;
            //    }
            //    double promedio_alumno = CalcularPromedio(alumnos_notas, i);
            //    if (i == 0 || promedio_alumno > promedio_mayor)
            //    {
            //        promedio_mayor = promedio_alumno;
            //    }
            //    if (i == 0 || promedio_alumno < promedio_menor)
            //    {
            //        promedio_menor = promedio_alumno;
            //    }
            //}
            //Console.WriteLine($"El mejor promedio es: {promedio_mayor:F2}");
            //Console.WriteLine($"El peor promedio es: {promedio_menor:F2}");

            //TP Nº4

            //PUNTO 1
            //Console.WriteLine("Ingrese un numero entero positivo");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= n; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            //PUNTO 2
            //Console.WriteLine("Ingrese un numero entero positivo");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= n; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}


            //PUNTO 3
            //Console.Write("Cuantos valores quiere ingresar: ");
            //int cant_valores = int.Parse(Console.ReadLine());
            //int suma_valores = 0;
            //int valor;
            //Console.WriteLine("Ingrese los valores");
            //for (int contador = 1; contador <= cant_valores; contador++)
            //{
            //    valor = int.Parse(Console.ReadLine());
            //    suma_valores += valor;
            //}
            //int promedio = (suma_valores / cant_valores);
            //Console.WriteLine($"La suma de los valores ingresados es {suma_valores} y su promedio es {promedio}");

            //PUNTO 4
            //Console.Write("Ingrese un numero entero positivo: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write($"Los divisores de {n} son: ");
            //for(int divisor = 1; divisor <= n; divisor++)
            //{
            //    if(divisor == n)
            //    {
            //        Console.Write($"{divisor}.");
            //    } else if(n % divisor == 0)
            //    {
            //        Console.Write($"{divisor}, ");
            //    }
            //}

            //PUNTO 5
            //Console.WriteLine("Ingrese tres numeros enteros positivos");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int X = int.Parse(Console.ReadLine());
            //Console.Write($"Todos los multiplos de {X} entre {A} y {B} inclusive son: ");
            //for(int n = A; n <= B; n++)
            //{
            //    if(n % X == 0)
            //    {
            //        Console.Write($"{n} ");
            //    }
            //}

            //PUNTO 6
            //Console.WriteLine("Ingrese las medidas de 2 lados del rectangulo");
            //Console.Write("Ancho deseado: ");
            //int ancho_rect = int.Parse(Console.ReadLine());
            //Console.Write("Largo deseado: ");
            //int largo_rect = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dibujo del rectangulo:");
            //for(int i = 0; i < ancho_rect; i++)
            //{
            //    for(int j = 0; j < largo_rect; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //PUNTO 7
            //Console.WriteLine("Ingrese las medidas de 2 lados del rectangulo");
            //int ancho_rect;
            //int largo_rect;
            //do
            //{
            //    Console.Write("Ancho deseado: ");
            //    ancho_rect = int.Parse(Console.ReadLine());
            //    Console.Write("Largo deseado: ");
            //    largo_rect = int.Parse(Console.ReadLine());
            //    if(ancho_rect <= 0 || largo_rect <= 0)
            //    {
            //        Console.WriteLine("Ambas medidas deben ser mayores a 0. Intente nuevamente.");
            //    }
            //} while (ancho_rect <= 0 || largo_rect <= 0);

            //Console.WriteLine("Dibujo del rectangulo:");
            //for (int fila = 1; fila <= largo_rect; fila++)
            //{
            //    for (int columna = 1; columna <= ancho_rect; columna++)
            //    {
            //        if(fila == 1 || fila == largo_rect || columna == 1 || columna == ancho_rect)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //PUNTO 8
            //Console.WriteLine("Ingrese números enteros positivos:");
            //int suma = 0;
            //int cant_n = 0;
            //double promedio = 0;
            //int n = int.Parse(Console.ReadLine());
            //while(n > 0)
            //{
            //    suma += n;
            //    cant_n++;
            //    n = int.Parse(Console.ReadLine());
            //}
            //if(cant_n == 0)
            //{
            //    Console.WriteLine("No se ingresaron números positivos.");
            //} else
            //{
            //    promedio = (double) suma / cant_n;
            //}
            //Console.WriteLine($"El promedio es {promedio} con un total de {cant_n} ingresos.");

            //PUNTO 9
            //Console.WriteLine("Ingrese números enteros positivos:");
            //int n = int.Parse(Console.ReadLine());
            //int n_ingresado = n;
            //bool ordenada = true;
            //while(n != 0)
            //{
            //    if(n < n_ingresado)
            //    {
            //        ordenada = false;
            //    } else
            //    {
            //        n_ingresado = n;
            //    }
            //    n = int.Parse(Console.ReadLine());
            //}
            //if(ordenada)
            //{
            //    Console.WriteLine("Los números están ordenados de menor a mayor.");
            //}
            //else
            //{
            //    Console.WriteLine("Los números no están ordenados de menor a mayor.");
            //}

            //PUNTO 10
            //Console.Write("Ingrese un caracter: ");
            //char caracter = char.Parse(Console.ReadLine());
            //int cant_repetir;
            //do
            //{
            //    Console.Write("Ingrese un número natural: ");
            //    cant_repetir = int.Parse(Console.ReadLine());
            //    if (cant_repetir <= 0)
            //    {
            //        Console.WriteLine("El número ingresado no es natural. Intente nuevamente.");
            //    }
            //} while (cant_repetir <= 0);
            //for(int vuelta = 1; vuelta <= cant_repetir; vuelta++)
            //{
            //    Console.Write($"{caracter}");
            //}

            //PUNTO 11
            //Console.Write("Ingrese un texto para contar la cantidad de vocales que contiene: ");
            //string texto = Console.ReadLine().ToLower();
            //int cant_vocales = 0;
            //for (int i = 0; i < texto.Length-1; i++)
            //{
            //    char letra = texto[i];
            //    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            //    {
            //        cant_vocales++;
            //    }
            //}
            //Console.WriteLine($"El texto ingresado tiene {cant_vocales} vocales.");

            //Console.Write("Ingresar la altura del rombo (número impar): ");
            //int altura = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //// Asegurar que la altura sea impar
            //if (altura % 2 == 0)
            //{
            //    altura++;
            //    Console.WriteLine("Ajustando altura a " + altura + " (debe ser impar).");
            //}

            //int mitad = altura / 2 + 1;

            //// Parte superior
            //for (int fila = 1; fila <= mitad; fila++)
            //{
            //    // Espacios
            //    for (int espacio = 1; espacio <= mitad - fila; espacio++)
            //        Console.Write(" ");

            //    // Asteriscos
            //    for (int asterisco = 1; asterisco <= 2 * fila - 1; asterisco++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}

            //// Parte inferior
            //for (int fila = mitad - 1; fila >= 1; fila--)
            //{
            //    // Espacios
            //    for (int espacio = 1; espacio <= mitad - fila; espacio++)
            //        Console.Write(" ");

            //    // Asteriscos
            //    for (int asterisco = 1; asterisco <= 2 * fila - 1; asterisco++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}

            //TP Nº5

            //PUNTO 1
            //int[] arreglo_numeros = new int[10];
            //Random numero_aleatorio = new Random();
            //for (int i = 0; i < arreglo_numeros.Length; i++)
            //{
            //    arreglo_numeros[i] = numero_aleatorio.Next(1, 20);
            //}

            //int numero_a_buscar = -1;
            //string input;
            //bool incorrecto = true;
            //Console.Write("Ingrese un número a buscar en el arreglo: ");
            //while (incorrecto)
            //{
            //    input = Console.ReadLine();

            //    // Usar TryParse para validar si es un número
            //    if (int.TryParse(input, out numero_a_buscar))
            //    {
            //        Console.WriteLine($"¡Gracias! Has ingresado el número: {numero_a_buscar}");
            //        incorrecto = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada no válida. Por favor, ingrese un número:");
            //    }
            //}

            //while(numero_a_buscar >= 0)
            //{
            //    bool encontrado = false;
            //    int posicion = 0;
            //    while (posicion < arreglo_numeros.Length && !encontrado)
            //    {
            //        if (arreglo_numeros[posicion] == numero_a_buscar)
            //        {
            //            encontrado = true;
            //        }
            //        else
            //        {
            //            posicion++;
            //        }
            //    }
            //    if (encontrado)
            //    {
            //        Console.WriteLine($"El número {numero_a_buscar} se encuentra en la posición {posicion} del arreglo.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El número {numero_a_buscar} no se encuentra en el arreglo.");
            //    }
            //    Console.Write("Ingrese otro número a buscar en el arreglo o -1 para terminar el programa:  ");
            //    numero_a_buscar = int.Parse(Console.ReadLine());
            //}

            //PUNTO 2
            //int[] arreglo_numeros = new int[10];
            //Random numero_aleatorio = new Random();
            //for (int i = 0; i < arreglo_numeros.Length; i++)
            //{
            //    arreglo_numeros[i] = numero_aleatorio.Next(1, 100);
            //}
            //int cant_mayores = 0;
            //for(int i = 0; i < arreglo_numeros.Length; i++)
            //{
            //    if (arreglo_numeros[i] > 50)
            //    {
            //        cant_mayores++;
            //    }
            //}
            //Console.WriteLine($"El arreglo tiene {cant_mayores} números mayores a 50.");

            //PUNTO 3
            //int[] arreglo_numeros = new int[20];
            //Random numero_aleatorio = new Random();
            //int suma = 0;
            //for (int i = 0; i < arreglo_numeros.Length; i++)
            //{
            //    arreglo_numeros[i] = numero_aleatorio.Next(1, 100);
            //    suma += arreglo_numeros[i];
            //}
            //double promedio = (double)suma / arreglo_numeros.Length;
            //Console.WriteLine($"El promedio de los números en el arreglo es {promedio}");
            //int cant_mayores = 0;
            //for(int i = 0; i < arreglo_numeros.Length; i++)
            //{
            //    if (arreglo_numeros[i] > promedio)
            //    {
            //        cant_mayores++;
            //    }
            //}
            //Console.WriteLine($"En el arreglo hay {cant_mayores} número/s mayor/es al promedio.");

            //PUNTO 4 (Procedimiento)
            //punto4();

            //PUNTO 5
            //int[] arreglo1_aleatorio = new int[5];
            //int[] arreglo2_aleatorio = new int[5];
            //Random numero_aleatorio = new Random();

            //for(int i = 0; i < 5; i++)
            //{
            //    arreglo1_aleatorio[i] = numero_aleatorio.Next(3, 57);
            //    arreglo2_aleatorio[i] = numero_aleatorio.Next(3, 57);
            //}

            //Console.Write("El arreglo 1 es el siguiente: [");
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i != 4)
            //    {
            //        Console.Write($"{arreglo1_aleatorio[i]}, ");
            //    }
            //    else
            //    {
            //        Console.Write($"{arreglo1_aleatorio[i]}");
            //    }
            //}
            //Console.Write("]");
            //Console.Write("El arreglo 2 es el siguiente: [");
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i != 4)
            //    {
            //        Console.Write($"{arreglo2_aleatorio[i]}, ");
            //    }
            //    else
            //    {
            //        Console.Write($"{arreglo2_aleatorio[i]}");
            //    }
            //}
            //Console.Write("]");

            //int[] suma_arreglos = new int[5];
            //Console.Write("El arreglo suma es el siguiente: [");
            //for (int i = 0; i < 5; i++)
            //{
            //    suma_arreglos[i] = arreglo1_aleatorio[i] + arreglo2_aleatorio[i];
            //    if(i != 4)
            //    {
            //        Console.Write($"{suma_arreglos[i]}, ");
            //    } else
            //    {
            //        Console.Write($"{suma_arreglos[i]}");
            //    }
            //}
            //Console.Write("]");

            //PUNTO 6
            //Console.Write("Cuantas notas desea cargar? --> ");
            //int cant_notas = int.Parse(Console.ReadLine());
            //decimal[] notas_alumnos = new decimal[cant_notas];
            //Console.WriteLine("A continuacion debe ingresar las notas de los alumnos.");
            //for (int i = 0; i < notas_alumnos.Length; i++)
            //{
            //    Console.Write("Ingrese una nota: ");
            //    notas_alumnos[i] = decimal.Parse(Console.ReadLine());
            //}
            //decimal nota_actual;
            //decimal nota_masbaja = 11;
            //decimal nota_masalta = 0;
            //int posicion_masalta = 0;
            //int posicion_masbaja = 0;
            //for (int i = 0; i < notas_alumnos.Length; i++)
            //{
            //    nota_actual = notas_alumnos[i];
            //    if (nota_actual >= nota_masalta)
            //    {
            //        nota_masalta = nota_actual;
            //        posicion_masalta = i;
            //    }
            //    if (nota_actual < nota_masbaja)
            //    {
            //        nota_masbaja = nota_actual;
            //        posicion_masbaja = i;
            //    }
            //    // 5 notas: 9,5 8 2 6 8
            //}
            //Console.WriteLine($"La nota mas alta del arreglo es {nota_masalta} en el indice nro. {posicion_masalta}");
            //Console.WriteLine($"La nota mas baja del arreglo es {nota_masbaja} en el indice nro. {posicion_masbaja}");

            //PUNTO 7
            //Console.Write("Ingrese un numero: ");
            //int num = int.Parse(Console.ReadLine());
            //int[] digitos_num = new int[num.ToString().Length];
            //int i = digitos_num.Length - 1;
            //int aux = num;
            //int digito;
            //while (aux != 0)
            //{
            //    digito = aux % 10;
            //    aux = aux / 10;
            //    digitos_num[i] = digito;
            //    i--;
            //}
            //int mayor = 0;
            //int menor = 10;
            //int pos_mayor = 0;
            //int pos_menor = 0;
            //int dig_actual;
            //for (int j = 0; j < digitos_num.Length; j++)
            //{
            //    dig_actual = digitos_num[j];
            //    if (dig_actual > mayor)
            //    {
            //        mayor = dig_actual;
            //        pos_mayor = j;
            //    }
            //    if (dig_actual < menor)
            //    {
            //        menor = dig_actual;
            //        pos_menor = j;
            //    }
            //}
            //Console.WriteLine($"El digito mas bajo del arreglo esta en la posicion {pos_menor} y el mas alto en la posicion {pos_mayor}");

            //PUNTO 8
            //int[] arreglo_enteros = new int[10];
            //Console.WriteLine("Ingrese 10 números enteros:");
            //for (int i = 0; i < arreglo_enteros.Length; i++)
            //{
            //    arreglo_enteros[i] = int.Parse(Console.ReadLine());
            //}
            //bool eliminado = false;
            //while (!eliminado)
            //{
            //    Console.Write("Los números ingresados son: ");
            //    for (int i = 0; i < arreglo_enteros.Length; i++)
            //    {
            //        Console.Write($"{arreglo_enteros[i]} ");
            //    }
            //    Console.WriteLine();
            //    Console.Write("Ingrese un valor a eliminar del arreglo: ");
            //    int valor_a_eliminar = int.Parse(Console.ReadLine());
            //    int[] posiciones_eliminar = new int[arreglo_enteros.Length];
            //    int cant_apariciones = 0;
            //    for (int i = 0; i < arreglo_enteros.Length; i++)
            //    {
            //        if (arreglo_enteros[i] == valor_a_eliminar)
            //        {
            //            posiciones_eliminar[cant_apariciones] = i;
            //            cant_apariciones++;
            //        }
            //    }
            //    if (cant_apariciones > 0)
            //    {
            //        int[] nuevoArreglo = new int[arreglo_enteros.Length - cant_apariciones];
            //        int indiceNuevo = 0;
            //        for (int i = 0; i < arreglo_enteros.Length; i++)
            //        {
            //            //verifico si la posicion actual es una de las posiciones a eliminar
            //            bool es_pos_eliminar = false;
            //            int j = 0;
            //            while (j < cant_apariciones && !es_pos_eliminar)
            //            {
            //                if (i == posiciones_eliminar[j])
            //                {
            //                    es_pos_eliminar = true;
            //                }
            //                j++;
            //            }
            //            //si no es una posicion a eliminar, lo guardo en el nuevo arreglo
            //            if (!es_pos_eliminar)
            //            {
            //                nuevoArreglo[indiceNuevo] = arreglo_enteros[i];
            //                indiceNuevo++;
            //            }
            //        }
            //        //actualizo el arreglo original
            //        arreglo_enteros = nuevoArreglo;
            //        eliminado = true;
            //        Console.WriteLine($"Se eliminaron {cant_apariciones} apariciones del número {valor_a_eliminar} en el arreglo.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El valor {valor_a_eliminar} no se encuentra en el arreglo.");
            //    }
            //}
            //if (arreglo_enteros.Length == 0)
            //{
            //    Console.WriteLine("El arreglo final está vacío.");
            //} else
            //{
            //    Console.Write("El arreglo final es el siguiente: ");
            //    for (int i = 0; i < arreglo_enteros.Length; i++)
            //    {
            //        Console.Write($"{arreglo_enteros[i]} ");
            //    }
            //}

            //PUNTO 9
            /*
            recorrer el arreglo de numeros posibles e ir comparando, si el elem de nposibles 
            es igual al narreglo aumenta la cantidad de veces que aparece
            */
            //int[] arreglo_nums = new int[10];
            //int[] posibles_nums = { 1, 2, 3, 4, 5 };
            //int num_ingresado;
            ////guardar los números ingresados por el usuario en el arreglo
            //for (int i = 0; i < arreglo_nums.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write("Ingrese un número entre 1 y 5: ");
            //        num_ingresado = int.Parse(Console.ReadLine());
            //        if(num_ingresado < 1 || num_ingresado > 5)
            //        {
            //            Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
            //        }
            //    } while (num_ingresado < 1 || num_ingresado > 5);
            //    arreglo_nums[i] = num_ingresado;
            //}
            ////recorrer el arreglo de números posibles y contar cuántas veces aparece en el arreglo
            //for (int i = 0; i < posibles_nums.Length; i++)
            //{
            //    int contador = 0;
            //    for (int j = 0; j < arreglo_nums.Length; j++)
            //    {
            //        if (posibles_nums[i] == arreglo_nums[j])
            //        {
            //            contador++;
            //        }
            //    }
            //    Console.WriteLine($"El número {posibles_nums[i]} aparece {contador} veces en el arreglo.");
            //}

            //PUNTO 10
            //int[] arreglo_numeros = new int[10];
            //for(int i = 0; i < arreglo_numeros.Length; i++)
            //{
            //    Console.Write("Ingrese un número: ");
            //    arreglo_numeros[i] = int.Parse(Console.ReadLine());
            //}
            //int[] copia_arreglo = arreglo_numeros;
            //int j = 0;
            //int cant_veces = 0;
            //while (j < copia_arreglo.Length && cant_veces <= 1)
            //{
            //    int k = 0;
            //    cant_veces = 0;
            //    while (k < arreglo_numeros.Length && cant_veces <= 1)
            //    {
            //        if (copia_arreglo[j] == arreglo_numeros[k])
            //        {
            //            cant_veces++;
            //        }
            //        k++;
            //    }
            //    j++;
            //}
            //if (cant_veces > 1)
            //{
            //    Console.WriteLine("El arreglo tiene números duplicados.");
            //}
            //else if(cant_veces == 1)
            //{
            //    Console.WriteLine("El arreglo no tiene números duplicados.");
            //}

            //PUNTO 11
            //string[] lista_invitados = new string[10];
            //bool salir = false;
            //int cant_invitados = 0;
            //Console.WriteLine("Ingrese los nombres de los invitados. Para finalizar la carga, ingrese 'salir'.");
            //while (!salir)
            //{
            //    if (cant_invitados >= lista_invitados.Length)
            //    {
            //        string[] arreglo_aux = new string[lista_invitados.Length + 10];
            //        for(int i = 0; i < lista_invitados.Length; i++)
            //        {
            //            arreglo_aux[i] = lista_invitados[i];
            //        }
            //        lista_invitados = arreglo_aux;
            //    }
            //    Console.Write($"Nombre del invitado nro. {cant_invitados+1}: ");
            //    string nombre_invitado = Console.ReadLine();
            //    if(string.IsNullOrWhiteSpace(nombre_invitado))
            //    {
            //        Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
            //    }
            //    else if (nombre_invitado.ToLower() == "salir")
            //    {
            //        salir = true;
            //    } else
            //    {
            //        lista_invitados[cant_invitados] = nombre_invitado;
            //        cant_invitados++;
            //    }
            //}
            ////eliminar los nombres vacíos
            //if(cant_invitados < lista_invitados.Length)
            //{
            //    string[] arreglo_aux2 = new string[cant_invitados];
            //    for (int i = 0; i < cant_invitados; i++)
            //    {
            //        arreglo_aux2[i] = lista_invitados[i];
            //    }
            //    lista_invitados = arreglo_aux2;
            //}
            ////cantidad de invitados
            //Console.WriteLine($"Participaran del evento {cant_invitados} invitados.");
            ////imprimir la lista de invitados
            //Console.WriteLine("Aqui tiene la lista de invitados:");
            //for (int j = 0; j < cant_invitados; j++)
            //{
            //    Console.WriteLine($"Invitado {j + 1}: {lista_invitados[j]}");
            //}

            //PUNTO 12


        }

        //PUNTO 4
        public static void punto4()
        {
            int[] arreglo_numeros = new int[8];
            Random numero_aleatorio = new Random();
            Console.Write("El arreglo original: ");
            for (int i = 0; i < arreglo_numeros.Length; i++)
            {
                arreglo_numeros[i] = numero_aleatorio.Next(1, 100);
                Console.Write($"{arreglo_numeros[i]} ");
            }
            Console.WriteLine();
            int[] arreglo_inverso = new int[arreglo_numeros.Length];
            Console.Write("El arreglo original invertido: ");
            int indice = 0;
            int j = arreglo_numeros.Length - 1;
            while (j >= 0 && indice < arreglo_inverso.Length)
            {
                arreglo_inverso[indice] = arreglo_numeros[j];
                Console.Write($"{arreglo_inverso[indice]} ");
                indice++;
                j--;
            }
            Console.WriteLine();
        }

        //metodo para calcular el promedio de un alumno
        private static double CalcularPromedio(object[,] alumnos_notas, int indice_alumno)
        {
            double suma_notas = 0;
            for (int j = 1; j < 4; j++)
            {
                suma_notas += (double)alumnos_notas[indice_alumno, j];
            }
            return (double)suma_notas / 3;
        }

        //int altura = 0;
        //string input;
        //bool cond;
        //do
        //{
        //    Console.Write("Ingresar la altura del triangulo: ");
        //    input = Console.ReadLine();
        //    cond = int.TryParse(input, out altura);
        //    if(altura < 1 || altura > 9 || !cond)
        //    {
        //        Console.WriteLine("Ingrese la altura del triángulo nuevamente.");
        //    }
        //} while(altura < 1 || altura > 9 || !cond);
        //Console.WriteLine(" ");

        //// piramide n renglones (n<=9)
        ////   1
        ////  121
        //// 12321
        //// 1..n..1
        //for (int renglon = 1; renglon <= altura; renglon++)
        //{

        //    for (int espacio = 1; espacio <= altura - renglon; espacio++)
        //    {//se encarga de escribir los espacios del renglon
        //        Console.Write(" ");
        //    }

        //    //escribo secuencia creciente: desde 1 ¿hasta donde? hasta numero de renglon
        //    for (int indice = 1; indice <= renglon; indice++)
        //    {
        //        Console.Write(indice);//(*)
        //    }

        //    //escribo la secuencia decreciente ¿desde donde? desde (renglon-1) hasta 1
        //    for (int indice = renglon - 1; indice >= 1; indice--)
        //    {
        //        Console.Write(indice);//(*)
        //    }
        //    Console.WriteLine();
        //}

        //Ejercicio Número aleatorio
        //int num_usuario;
        //Console.Write("Ingrese un número del 1 al 5: ");
        //do
        //{
        //    num_usuario = int.Parse(Console.ReadLine());
        //    if(num_usuario < 1 || num_usuario > 5)
        //    {
        //        Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
        //    }
        //} while (num_usuario < 1 || num_usuario > 5);
        //Random num_programa = new Random();
        //int num_aleatorio = num_programa.Next(1, 5);
        //while (num_usuario != num_aleatorio)
        //{
        //    Console.WriteLine("No acertaste el número. Intenta nuevamente");
        //    do
        //    {
        //        num_usuario = int.Parse(Console.ReadLine());
        //        if (num_usuario < 1 || num_usuario > 5)
        //        {
        //            Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
        //        }
        //    } while (num_usuario < 1 || num_usuario > 5);
        //    num_aleatorio = num_programa.Next(1, 5);
        //}
        //Console.WriteLine("¡Felicidades! Acertaste el número.");

        //Ejercicio Piedra, papel o tijera
        //int opcion_usuario;
        //Console.Write("Elija una opción (1=Piedra, 2=Papel, 3=Tijera) ");
        //do
        //{
        //    opcion_usuario = int.Parse(Console.ReadLine());
        //    if (opcion_usuario < 1 || opcion_usuario > 3)
        //    {
        //        Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
        //    }
        //} while (opcion_usuario < 1 || opcion_usuario > 3);
        //Random opcion_programa = new Random();
        //int opcion_aleatoria = opcion_programa.Next(1, 3);
        ////ganador 2papel&&1piedra->2 3tijera&&2papel->3 1piedra&&3tijera->1 
        //while (opcion_usuario == opcion_aleatoria)
        //{
        //    Console.WriteLine("No hay ganador. Intenta nuevamente");
        //    do
        //    {
        //        opcion_usuario = int.Parse(Console.ReadLine());
        //        if (opcion_usuario < 1 || opcion_usuario > 3)
        //        {
        //            Console.WriteLine("El número ingresado no es válido. Intente nuevamente.");
        //        }
        //    } while (opcion_usuario < 1 || opcion_usuario > 3);
        //    opcion_aleatoria = opcion_programa.Next(1, 3);
        //}
        //if(opcion_usuario == 1 && opcion_aleatoria == 2 || opcion_usuario == 2 && opcion_aleatoria == 3 || opcion_usuario == 3 && opcion_aleatoria == 1)
        //{
        //    Console.WriteLine($"Perdiste. La opción del programa fue {opcion_aleatoria}");
        //}
        //else
        //{
        //    Console.WriteLine($"Ganaste. La opción del programa fue {opcion_aleatoria}");
        //}

    }
}

