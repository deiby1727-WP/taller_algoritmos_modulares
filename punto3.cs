using System;

class punto3
{
    static string[] nombres = new string[20];
    static double[] notas = new double[20];
    static int cantidad = 0;

    public static void menu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- ESTUDIANTES ---");
            Console.WriteLine("1. Registrar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Promedio");
            Console.WriteLine("4. Volver");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    registrar();
                    break;
                case 2:
                    mostrar();
                    break;
                case 3:
                    promedio();
                    break;
            }

        } while (opcion != 4);
    }

    public static void registrar()
    {
        Console.Write("Nombre: ");
        nombres[cantidad] = Console.ReadLine();

        Console.Write("Nota: ");
        notas[cantidad] = double.Parse(Console.ReadLine());

        cantidad++;
    }

    public static void mostrar()
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(nombres[i] + " - " + notas[i]);
        }
    }

    public static void promedio()
    {
        double suma = 0;

        for (int i = 0; i < cantidad; i++)
        {
            suma += notas[i];
        }

        Console.WriteLine("Promedio: " + (suma / cantidad));
    }
}
