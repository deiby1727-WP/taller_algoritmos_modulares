using System;

internal class punto1
{
    public static void ips()
    {
        Console.WriteLine("---Sistema de control de turnos para una IPS---");

        string[] nombres = new string[30];
        string[] documentos = new string[30];
        int[] edades = new int[30];
        string[] tipos = new string[30];
        int[] prioridades = new int[30];

        int total = 0;
        int opcion;

        do
        {
            opcion = menu();

            if (opcion == 1)
            {
                registrar(nombres, documentos, edades, tipos, prioridades, ref total);
            }
            else if (opcion == 2)
                verPacientes(nombres, edades, tipos, prioridades, total);
            else if (opcion == 3)
                buscar(documentos, nombres, tipos, prioridades, total);
            else if (opcion == 4)
                contarTipos(tipos, total);
            else if (opcion == 5)
            {
                verPrioridades(nombres, prioridades, total);
            }
        } while (opcion != 0);
        return;
    }

    static int menu()
    {
        Console.WriteLine("\n--- MENU IPS ---");
        Console.WriteLine("1. Registrar paciente");
        Console.WriteLine("2. Ver pacientes");
        Console.WriteLine("3. Buscar por documento");
        Console.WriteLine("4. Pacientes por tipo de atención");
        Console.WriteLine("5. Pacientes con mayor prioridad");
        Console.WriteLine("0. Salir");
        Console.Write("Opcion: ");
        return int.Parse(Console.ReadLine());
    }

    static void registrar(string[] nombres, string[] documentos, int[] edades, string[] tipos, int[] prioridades, ref int total)
    {
        if (total > 30)
        {
            Console.WriteLine("No hay cupos.");
        }
        else
        {
            Console.Write("Documento: ");
            documentos[total] = Console.ReadLine();
            Console.Write("Nombre: ");
            nombres[total] = Console.ReadLine();
            Console.Write("Edad: ");
            edades[total] = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo (1 Urgencias / 2 Consulta General / 3 Prioritaria): ");
            System.Console.Write("Seleccione:");
            tipos[total] = Console.ReadLine();
            Console.Write("Prioridad (1 alta, 5 baja): ");
            System.Console.Write("Seleccione:");
            prioridades[total] = int.Parse(Console.ReadLine());
            total++;
            Console.WriteLine("Registrado! Turno #" + total);
        }
    }

    static void verPacientes(string[] nombres, int[] edades, string[] tipos, int[] prioridades, int total)
    {
        if (total == 0)
        {
            System.Console.WriteLine("NO HAY PACIENTES POR MOSTRAR, PRIMERO DEBE DE REGISTRARLOS");
        }
        else
        {
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("\nTurno #" + (i + 1) + " | " + nombres[i] + " | " + edades[i] + " años | " + tipos[i] + " | Prioridad: " + prioridades[i]);
            }
        }
    }

    static void buscar(string[] documentos, string[] nombres, string[] tipos, int[] prioridades, int total)
    {
        if (total == 0)
        {
            System.Console.WriteLine("NO HAY PACIENTES POR MOSTRAR PRIMERO DEBE DE REGISTRARLOS");
        }
        else
        {
            Console.Write("Documento a buscar: ");
            string doc = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < total; i++)
            {
                if (documentos[i] == doc)
                {
                    Console.WriteLine("Encontrado: " + nombres[i] + " | " + tipos[i] + " | Prioridad: " + prioridades[i]);
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("No encontrado.");
        }
    }

    static void contarTipos(string[] tipos, int total)
    {
        int urgencias = 0;
        int consulta = 0;
        int prioritaria = 0;

        for (int i = 0; i < total; i++)
        {
            if (tipos[i] == "1") urgencias++;
            else if (tipos[i] == "2") consulta++;
            else if (tipos[i] == "3") prioritaria++;
        }

        Console.WriteLine("Urgencias: " + urgencias);
        Console.WriteLine("Consulta General: " + consulta);
        Console.WriteLine("Prioritaria: " + prioritaria);
    }

    static void verPrioridades(string[] nombres, int[] prioridades, int total)
    {
        for (int f = 0; f < total; f++)
        {
            if (prioridades[f] == 1 || prioridades[f] == 2)
            {
                Console.WriteLine("El paciente " + nombres[f] + " tiene prioridad ALTA");
            }
            else if (prioridades[f] == 3)
            {
                Console.WriteLine("El paciente " + nombres[f] + " tiene prioridad MEDIA");
            }
            else if (prioridades[f] == 4 || prioridades[f] == 5)
            {
                Console.WriteLine("El paciente " + nombres[f] + " tiene prioridad BAJA");
            }
        }
    }
}
