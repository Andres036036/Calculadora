using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Bienvenido a la calculadora");
            while (true)
            {
                Console.WriteLine("\nPor favor, escoja una opción:");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicación");
                Console.WriteLine("4) División");
                string opcion = Console.ReadLine();

                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
                {
                    Console.WriteLine("Opción no válida. Intenta otra vez.");
                    continue;
                }

                Console.Write("Primer número: ");
                bool esNumero1 = double.TryParse(Console.ReadLine(), out double num1);
                Console.Write("Segundo número: ");
                bool esNumero2 = double.TryParse(Console.ReadLine(), out double num2);

                if (!esNumero1 || !esNumero2)
                {
                    Console.WriteLine("Solo puedes escribir números.");
                    continue;
                }

                Calculadora2 cal = new Calculadora2(num1, num2);
                double resultado = 0;

                switch (opcion)
                {
                    case "1":
                        resultado = cal.sumar();
                        break;
                    case "2":
                        resultado = cal.restar();
                        break;
                    case "3":
                        resultado = cal.multiplicar();
                        break;
                    case "4":
                        resultado = cal.dividir();
                        break;
                }
                Console.WriteLine("El resutado es: " + resultado);
                while (true)
                {
                    Console.WriteLine("\nPresiona ENTER para hacer otra operacion o escribe 'salir' para terminar:");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta == "")
                    {
                        break;
                    }
                    else if (respuesta == "salir")
                    {
                        Console.WriteLine("Gracias por usar la calculadora.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Solo puedes presionar ENTER para continuar o escribir 'salir' para terminar.");
                    }
                }
            }*/
            int op = 0;
            List<Persona> Personas = new List<Persona>();

            do
            {
                Console.WriteLine("\nAplicación para usuarios");
                Console.WriteLine("1. Ingresar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Consulta 2");
                Console.WriteLine("4. Salir");
                Console.Write("Digite su opción: ");
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Ingrese un número válido.\n");
                    continue;
                }
                switch (op)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();

                        Console.Write("Correo: ");
                        string mail = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        string tel = Console.ReadLine();

                        Personas.Add(new Persona(nom, mail, tel));
                        Console.WriteLine("Usuario ingresado correctamente.");
                        break;
                    case 2:
                        foreach (var persona in Personas)
                        {
                            Console.WriteLine(persona.mostrarpersona());
                        }
                        break;
                    case 3:
                        for (int i = 0; i< Personas.Count(); i++)
                        {
                            Console.WriteLine(Personas[i].mostrarpersona());
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            } while (op != 4) ;
            }
        }
    }
