using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora.net
    {
        internal class Program
        {
            static List<Persona> Personas = new List<Persona>();
            static List<Producto> Productos = new List<Producto>();

            static void Main(string[] args)
            {
                MenuPrincipal();
            }

            static void MenuPrincipal()
            {
                while (true)
                {
                    Console.WriteLine("\nMENÚ PRINCIPAL:");
                    Console.WriteLine("1). Calculadora");
                    Console.WriteLine("2). Personas");
                    Console.WriteLine("3). Productos");
                    Console.WriteLine("4). Salir");
                    Console.Write("Porfavor seleccione una opción: ");
                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            MenuCalculadora();
                            break;
                        case "2":
                            MenuPersonas();
                            break;
                        case "3":
                            MenuProductos();
                            break;
                        case "4":
                            Console.WriteLine("El programa se cerro correctamente.");
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
            static void MenuCalculadora()
            {
                while (true)
                {
                    Console.WriteLine("\nCALCULADORA:");
                    Console.WriteLine("1). Suma");
                    Console.WriteLine("2). Resta");
                    Console.WriteLine("3). Multiplicación");
                    Console.WriteLine("4). División");
                    Console.WriteLine("5). Volver al menú principal");
                    string opcion = Console.ReadLine();
                    if (opcion == "5") return;
                    Console.Write("Primer número: ");
                    if (!double.TryParse(Console.ReadLine(), out double num1))
                    {
                        Console.WriteLine("Solo se pueden escribir números.");
                        continue;
                    }
                    Console.Write("Segundo número: ");
                    if (!double.TryParse(Console.ReadLine(), out double num2))
                    {
                        Console.WriteLine("Solo se pueden escribir números.");
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
                        default:
                            Console.WriteLine("Opción no válida.");
                            continue;
                    }
                    Console.WriteLine($"El resultado es: {resultado}");
                }
            }
            static void MenuPersonas()
            {
                while (true)
                {
                    Console.WriteLine("\nGESTIÓN DE PERSONAS:");
                    Console.WriteLine("1). Ingresar persona");
                    Console.WriteLine("2). Consultar personas");
                    Console.WriteLine("3). Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Nombre: ");
                            string nom = Console.ReadLine();
                            Console.Write("Correo: ");
                            string mail = Console.ReadLine();
                            Console.Write("Teléfono: ");
                            string tel = Console.ReadLine();
                            Personas.Add(new Persona(nom, mail, tel));
                            Console.WriteLine("Usuario ingresado correctamente.");
                            break;
                        case "2":
                            if (Personas.Count == 0)
                            {
                                Console.WriteLine("No hay personas registradas.");
                            }
                            else
                            {
                                foreach (var persona in Personas)
                                {
                                    Console.WriteLine(persona.mostrarpersona());
                                }
                            }
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
            static void MenuProductos()
            {
                while (true)
                {
                    Console.WriteLine("\nGESTIÓN DE PRODUCTOS:");
                    Console.WriteLine("1). Ingresar producto");
                    Console.WriteLine("2). Consultar productos");
                    Console.WriteLine("3). Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Nombre del producto: ");
                            string nombreProducto = Console.ReadLine();

                            Console.Write("Precio del producto: ");
                            if (!double.TryParse(Console.ReadLine(), out double precioProducto))
                            {
                                Console.WriteLine("Ingrese un precio válido.");
                                continue;
                            }
                            Productos.Add(new Producto(nombreProducto, precioProducto));
                            Console.WriteLine("Producto ingresado correctamente.");
                            break;
                        case "2":
                            if (Productos.Count == 0)
                            {
                                Console.WriteLine("No hay productos registrados.");
                            }
                            else
                            {
                                foreach (var producto in Productos)
                                {
                                    Console.WriteLine(producto.MostrarProducto());
                                }
                            }
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
        }
    }
