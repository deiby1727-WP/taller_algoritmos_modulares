using System;

class punto1
{
    static string[] nombres = new string[20];
    static int[] edades = new int[20];
    static string[] tipos = new string[20];
    static int cantidad = 0;

    public static void menu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- IPS ---");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Mostrar pacientes");
            Console.WriteLine("3. Estadísticas");
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
                    estadisticas();
                    break;
            }

        } while (opcion != 4);
    }

    public static void registrar()
    {
        if (cantidad >= 20)
        {
            Console.WriteLine("Capacidad llena");
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Tipo (1 Urgente, 2 Prioritario, 3 General): ");
        int t = int.Parse(Console.ReadLine());

        string tipo = "";

        if (t == 1) tipo = "Urgente";
        else if (t == 2) tipo = "Prioritario";
        else if (t == 3) tipo = "General";
        else
        {
            Console.WriteLine("Tipo inválido");
            return;
        }

        nombres[cantidad] = nombre;
        edades[cantidad] = edad;
        tipos[cantidad] = tipo;
        cantidad++;

        Console.WriteLine("Paciente registrado");
    }

    public static void mostrar()
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(nombres[i] + " - " + edades[i] + " años - " + tipos[i]);
        }
    }

    public static void estadisticas()
    {
        int u = 0, p = 0, g = 0;

        for (int i = 0; i < cantidad; i++)
        {
            if (tipos[i] == "Urgente") u++;
            else if (tipos[i] == "Prioritario") p++;
            else g++;
        }

        Console.WriteLine("Urgentes: " + u);
        Console.WriteLine("Prioritarios: " + p);
        Console.WriteLine("Generales: " + g);
    }
}
