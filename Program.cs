using System;

internal class Program
{
    public static void Main(string[] args)
    {
        menu_principal();
    }

    public static void menu_principal()
    {
        Console.WriteLine("--- BIENVENIDO USUARIO ---");
        Console.WriteLine("1. Sistema de control de turnos IPS");
        Console.WriteLine("2. Sistema de control academico de notas");
        Console.WriteLine("3. Sistema de parqueadero");
        Console.WriteLine("4. Salir");

        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            punto1.ips();
            menu_principal();
        }
        else
        {
            if (opcion == 2)
            {
                punto3.registro_estudiantes();
                menu_principal();
            }
            else
            {
                if (opcion == 3)
                {
                    punto4.funcion();
                    menu_principal();
                }
                else
                {
                    if (opcion == 4)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida");
                        menu_principal();
                    }
                }
            }
        }
    }
}
