using EjercicioExcepciones;

bool salir = false;

while (!salir)
{
    Console.WriteLine("\n1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write("Elija una opción: ");
   


    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            RealizarOperacion('+');
            break;
        case 2:
            RealizarOperacion('-');
            break;
        case 3:
            RealizarOperacion('*');
            break;
        case 4:
            RealizarOperacion('/');
            break;
        case 5:
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
            break;
    }
}
    

    static void RealizarOperacion(char operador)
{
    double resultado = 0;

    try
    {
        Console.Write("Ingrese el primer número: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double b = double.Parse(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = Operaciones.Sumar(a, b);
                break;
            case '-':
                resultado = Operaciones.Restar(a, b);
                break;
            case '*':
                resultado = Operaciones.Multiplicar(a, b);
                break;
            case '/':
                resultado = Operaciones.Dividir(a, b);
                break;
            default:
                Console.WriteLine("Operador no válido.");
                return;
        }

        Console.WriteLine($"El resultado es:  {resultado}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un número válido.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
}
