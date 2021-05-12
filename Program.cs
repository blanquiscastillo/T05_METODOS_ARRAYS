using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_METODOS_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("T05 - Metodos y Arreglos");
            Console.WriteLine("\n EJERCICIO 1");
            Ejercicio1();
            
            Console.WriteLine("\n EJERCICIO 2");
            Ejercicio2();
            
            Console.WriteLine("\n EJERCICIO 3");
            Ejercicio3();

            Console.WriteLine("\n EJERCICIO 4");
            Ejercicio4();
            
            Console.WriteLine("\n EJERCICIO 5");
            Ejercicio5();
            
            Console.WriteLine("\n EJERCICIO 6");
            Ejercicio6();
            
            Console.WriteLine("\n EJERCICIO 7");
            Ejercicio7();
            

            Console.WriteLine("\n EJERCICIOS 13 AL 16");
            Ejercicio13_16();
            */
            Console.WriteLine("\n EJERCICIO 19 al 21");
            Ejercicio19_21();

            Console.WriteLine("\n");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        static double CalculaAreaCirculo(int radio)
        {            
            double area =  (Math.Pow(radio, 2)) * Math.PI;
            return area;
        }

        static double CalculaAreaTriangulo(int base_t,int altura)
        {
            double area = (base_t * altura) / 2;
            return area;
        }

        static double CalculaAreaCuadrado(int lado1, int lado2)
        {
            double area = lado1 * lado2;
            return area;
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Escoga opcion de figura a calcular area (1. Circulo 2. Triangulo 3. Cuadrado");
            int figura =Convert.ToInt32(Console.ReadLine());
            double resultado;
            switch (figura)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio del circulo:");
                    int radio = Convert.ToInt32(Console.ReadLine());
                    resultado = CalculaAreaCirculo(radio);
                    Console.WriteLine("El area del circulo es {0}",resultado);
                    break;

                case 2:
                    Console.WriteLine("Ingrese la base:");
                    int base_t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura:");
                    int altura = Convert.ToInt32(Console.ReadLine());
                    resultado = CalculaAreaTriangulo(base_t, altura);
                    Console.WriteLine("El area del triangulo es {0}", resultado);
                    break;
                case 3:
                    Console.WriteLine("Ingrese primer lado:");
                    int lado1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese segundo lado:");
                    int lado2 = Convert.ToInt32(Console.ReadLine());
                    resultado = CalculaAreaCuadrado(lado1, lado2);
                    Console.WriteLine("El area del cuadrado es {0}", resultado);
                    break;

                default:
                    Console.WriteLine("Opcion no válida");
                    break;
            }
        }

        static void Aleatorios(int inicial, int final,int cantidad)
        {
            Random r = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(r.Next(inicial, final));
                Console.Write(" ");

            }
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ingrese cantidad de numeros aleatorios a generar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero inicial del rango:");
            int inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero final del rango:");
            int final = Convert.ToInt32(Console.ReadLine());
            Aleatorios(inicial, final,cantidad);
        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }
            // Es primo :)
            return true;
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un numero entero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (EsPrimo(numero))
            {
                Console.WriteLine("El numero {0} es primo",numero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo", numero);
            }

        }

        static void factorial(int numero)
        {
            int fact = 1;
            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + numero + " es: " + fact);
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese un numero entero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            factorial(numero);
        }

        static string Binario(int numero)
        {
            string resto = "";
            string binario = "";

            while ((numero >= 2))
            {
                resto = resto + (numero % 2).ToString();
                numero = numero / 2;
            }
            resto = resto + numero.ToString();

            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }

            return binario;
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ingrese un numero entero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            string binario = Binario(numero);
            Console.WriteLine("\nEl numero " + numero + " en binario es: " + binario);

        }

        static int CuentaCifras(int numero)
        {
            string str = Convert.ToString(numero);                     

            int length = str.Length;            
            return length;
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Ingrese un numero entero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int cantidad = CuentaCifras(numero);
            Console.WriteLine("\nEl numero de cifras de " + numero + " es: " + cantidad);
        }

        static void Cambio(double numero,int moneda)
        {
            switch (moneda)
            {
                case 1:
                    Console.WriteLine("\n" + numero + " euros son : " + numero * 0.86 + " Libras");
                    break;
                case 2:
                    Console.WriteLine("\n" + numero + " euros son : " + numero * 1.28611 + " Dolares");
                    break;
                case 3:
                    Console.WriteLine("\n" + numero + " euros son : " + numero * 129.852 + " Yenes");
                    break;

                default:
                    Console.WriteLine("Valor no valido para moneda");
                    break;
            }

        }
        static void Ejercicio7()
        {
            Console.WriteLine("Ingrese la cantidad de euros:");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escoga la moneda (1. Libras 2. Dolares 3. Yenes)");
            int moneda = Convert.ToInt32(Console.ReadLine());            
            Cambio(numero, moneda);
        }

        static void Ejercicio13_16()
        {            
            Console.WriteLine("13. Ingrese la cantidad de numeros del arreglo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[numero];
            Console.WriteLine("Numeros aleatorios generados..");

            Random r = new Random();
            for (int i = 0; i < numero; i++)
            {                
                arreglo[i] = r.Next(1, 10);
                Console.Write(arreglo[i] +  " ");
            }

            Console.WriteLine("\n 14. Ingrese numero a buscar:");
            int busca = Convert.ToInt32(Console.ReadLine());

            if (arreglo.Contains(busca)) {
                Console.WriteLine("El elemento " + busca + " existe en el arreglo");
            }
            else
            {
                Console.WriteLine("El elemento " + busca + " no existe en el arreglo");
            }

            Console.WriteLine("\n 15. Invirtiendo valores del arreglo");

            //saco una copia
            int[] arreglo2 = new int[numero];
            arreglo.CopyTo(arreglo2, 0);

            //le doy vuelta al arreglo
            Array.Reverse(arreglo);
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }

            Console.WriteLine("\n 16. CAPICUA");
            //si los dos arreglos son igual es es capicua          
            bool capicua = true;

            int[] numeros = { 1, 2, 2, 1 };
            int[] numeros2 = new int[4];
            numeros.CopyTo(numeros2, 0);
            Array.Reverse(numeros2);

            Console.WriteLine("\n Arreglo 1");
            foreach (int valor in numeros)
            {
                Console.Write(valor + " ");
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != numeros2[i])
                {
                    capicua = false;
                    break;
                }
            }
            if (capicua)
            {
                Console.WriteLine("\n Es capicua");
            }
            else
            {
                Console.WriteLine("\n No es capicua");
            }

            capicua = true;

            int[] numeros3= { 1, 2, 3, 1 };
            int[] numeros4 = new int[4];
            numeros3.CopyTo(numeros4, 0);
            Array.Reverse(numeros4);

            Console.WriteLine("\n Arreglo 2");
            foreach (int valor in numeros3)
            {
                Console.Write(valor + " ");
            }

            for (int i = 0; i < numeros3.Length; i++)
            {
                if (numeros3[i] != numeros4[i])
                {
                    capicua = false;
                    break;
                }
            }

            if (capicua)
            {
                Console.WriteLine("\n Es capicua");
            }
            else
            {
                Console.WriteLine("\n No es capicua");
            }
        }


        //static void Genera_Aleatorios(int inicial, int final, int cantidad)
        static void Ejercicio19_21()
        {
            Console.WriteLine("Ingrese cantidad de numeros del arreglo:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero inicial del rango:");
            int inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero final del rango:");
            int final = Convert.ToInt32(Console.ReadLine());

            int[] arreglo = new int[cantidad];
            int contador = 0;


            Random r = new Random();            
            do
            {
                int numero = r.Next(inicial, final);
                if (EsPrimo(numero))
                {
                    arreglo[contador] = numero;
                    contador++;
                }                
            } while (contador < cantidad);

            int mayor = 0;
            Console.WriteLine("Valores del arreglo");
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");                
                if (valor > mayor)
                {
                    mayor = valor;
                }
            }
            Console.WriteLine("\n El mayor es {0}",mayor);

            Console.WriteLine("Ingrese ultimo digito a verificar:");
            int ultimo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los valores terminados en {0}",ultimo);
            foreach (int valor in arreglo)
            {
                if (valor % 10 == ultimo)
                {
                    Console.Write(valor + " ");
                }                
            }

        }
        

    } //class Program
} //namespace T05_METODOS_ARRAYS
