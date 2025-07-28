Console.WriteLine("Bienvenido a la calculadora");
while (true)
    {
        Console.WriteLine("\nPor favor, escoja una opcion:");
        Console.WriteLine("1) Suma");
        Console.WriteLine("2) Resta");
        Console.WriteLine("3) Multiplicacion");
        Console.WriteLine("4) División");
        string opcion = Console.ReadLine();
        if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
        {
            Console.WriteLine("Opcion no valida. Intenta otra vez.");
            continue;
        }
            Console.Write("Primer numero: ");
            bool esNumero1 = double.TryParse(Console.ReadLine(), out double num1);
            Console.Write("Segundo numero: ");
            bool esNumero2 = double.TryParse(Console.ReadLine(), out double num2);
            if (!esNumero1 || !esNumero2)
            {
                Console.WriteLine("Solo puedes escribir numeros.");
                continue;
            }
            double resultado = 0;
            if (opcion == "1")
                resultado = num1 + num2;
            if (opcion == "2")
                resultado = num1 - num2;
            if (opcion == "3")
                resultado = num1 * num2;
            if (opcion == "4")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede dividir por cero.");
                    continue;
                }
                resultado = num1 / num2;
            }
            Console.WriteLine("Resultado: " + resultado);
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
    }