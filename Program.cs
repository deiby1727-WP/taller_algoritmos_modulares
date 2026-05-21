using System;

internal class Program
{
    public static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\nMENU PRINCIPAL");
            Console.WriteLine("1. Punto 1");
            Console.WriteLine("2. Punto 3");
            Console.WriteLine("3. Punto 4");
            Console.WriteLine("4. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    punto1.ips();
                    break;
                case 2:
                    punto3.registro_estudiantes();
                    break;
                case 3:
                    punto4.menu();
                    break;
            }

        } while (opcion != 4);
    }
}
