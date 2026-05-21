internal class punto3
{
    public static void registro_estudiantes()
    {
        Console.WriteLine("---Sistema de control académico para seguimiento de notas---");
        Console.WriteLine("¿Cuantos estudiantes desea ingresar?");
        int cantidad = int.Parse(Console.ReadLine());
        string[] estudiantes;
        estudiantes = new string[cantidad];
        string dato = "";
        double nota = 0;
        double total_n = 0;
        double promedio = 0;
        double definitiva2 = 0;
        double prom_general = 0;
        double menor = 0;
        double mayor = 0;
        if (cantidad > 25 || cantidad < 0)
        {
            Console.WriteLine("Cantidad ingresada no permitida, debe ser entre 1 y 25");
        }
        else
        {
            double[,] datos_est = new double[cantidad, 3];
            for (int v = 0; v < estudiantes.Length; v++)
            {
                Console.WriteLine($"Ingrese el nombre del estudiante #{v + 1}");
                estudiantes[v] = Console.ReadLine();
            }
            for (int f = 0; f < datos_est.GetLength(0); f++)
            {
                double definitiva = 0;
                for (int c = 0; c < datos_est.GetLength(1); c++)
                {

                    switch (c)
                    {
                        case 0:
                            dato = "Codigo";
                            break;
                        case 1:
                            dato = "Nota";
                            break;
                        case 2:
                            dato = "Porcentaje de asistencia";
                            break;
                        default: break;
                    }
                    if (c == 1)
                    {
                        for (int c2 = 0; c2 < 3; c2++)
                        {
                            Console.WriteLine($"Ingrese la nota #{c2 + 1} del estudiante {estudiantes[f]}");
                            nota = double.Parse(Console.ReadLine());
                            if (nota < 0 || nota > 5)
                            {
                                Console.WriteLine("La nota ingresada debe ser entre 0 y 5.0");
                                c2--;
                            }
                            else
                            {
                                total_n = nota + total_n;
                            }
                        }
                        definitiva = total_n / 3;
                        total_n = 0;
                        datos_est[f, c] = definitiva;
                        promedio = promedio + definitiva;
                    }
                    else
                    {
                        Console.WriteLine($"Ingrese el {dato} del estudiante {estudiantes[f]}");
                        datos_est[f, c] = double.Parse(Console.ReadLine());
                    }
                    prom_general = definitiva / cantidad;
                }
                if (definitiva < 2.5)
                {
                    Console.WriteLine($"Tu definitiva es {definitiva}, Repruebas");
                }
                else
                {
                    if (definitiva < 3)
                    {
                        Console.WriteLine($"Tu definitiva es {definitiva} , puedes habilitar");
                    }
                    else
                    {
                        Console.WriteLine($"Tu definitiva es {definitiva}, Aprobado");
                    }
                }
                Console.WriteLine();
                if (f == 0)
                {
                    definitiva2 = definitiva;
                    mayor = definitiva2;
                }
                else
                {
                    if (definitiva > definitiva2)
                    {

                        if (definitiva > definitiva2)
                        {
                            mayor = definitiva;
                        }
                    }
                }
                if (f == 0)
                {
                    definitiva2 = definitiva;
                    menor = definitiva2;
                }
                else
                {
                    if (definitiva < definitiva2)
                    {

                        if (definitiva < definitiva2)
                        {
                            menor = definitiva;
                        }
                    }
                }
                definitiva = 0;
            }
            Console.WriteLine("El promedio general de todos los estudiantes es de: " + prom_general);
            Console.WriteLine("El mejor promedio es : " + mayor);
            Console.WriteLine("El peor promedio es : " + menor);
            Console.WriteLine();
            return;
        }
    }
}
