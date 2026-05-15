internal class punto4
{
    static int cantidad = 0;
    static int[] salida = new int[40];
    static int[] permanencia = new int[40];
    static string[] placa = new string[40];
    static double[,] datos_entrada = new double[40, 6];
    static int hora_en = 0;
    static int hora_sal = 0;
    static int total = 0;
    static int vehiculo = 0;
    static int carro = 0;
    static int moto = 0;
    static int bici = 0;

    public static void funcion()
    {
        Console.WriteLine("Ingrese el numero de la funcion desea ejecutar \n 1-Ingresar registros diarios \n 2-Consultar salida de algun vehiculo \n 3-Calcular el tiempo de permanencia de un vehiculo \n 4-Mostrar cantidad de ingresos por tipo \n 5-Vehiculo con mayor tiempo de permanencia \n 6-Volver a escoger un programa");
        int eleccion = int.Parse(Console.ReadLine());

        if( eleccion == 1)
        {
            registros();
        }
        else
        {
            if( eleccion == 2)
            {
                if (cantidad == 0)
                {
                    nohay();
                }
                else
                {
                    Console.WriteLine("Ingrese la placa del vehiculo para consultar la salida");
                    string consu = Console.ReadLine();
                    for (int i = 0; i < cantidad; i++)
                    {
                        bool encontrada = false;
                        for (int g = 0; g < cantidad; g++)
                        {
                            if (placa[g] == consu)
                            {
                                encontrada = true;
                                Console.WriteLine();
                                Console.WriteLine("Placa encontrada");
                                Console.WriteLine($"El vehiculo de placa {consu} salio a la hora #{datos_entrada[g,4]}");
                                Console.WriteLine();
                                break;
                            }
                        }
                        if (!encontrada)
                        {
                            Console.WriteLine("Placa no encontrada");
                            Console.WriteLine();
                        }
                    }
                    funcion();
                }
            }
            else
            {
                if (eleccion == 3)
                {
                    if (cantidad == 0)
                    {
                        nohay();
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la placa del vehiculo para consultar el tiempo de permanencia");
                        string consu = Console.ReadLine();
                        bool encontrada = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (placa[i] == consu)
                            {
                                encontrada = true;
                                Console.WriteLine("Placa encontrada");
                                Console.WriteLine($"El vehiculo de placa {consu} estuvo un total de {permanencia[i]} horas");
                                Console.WriteLine();
                                break;
                            }
                        }
                        if (!encontrada)
                        {
                            Console.WriteLine("Placa no encontrada");
                            Console.WriteLine();
                        }
                        funcion();
                    }
                }
                else
                {
                    if(eleccion == 4)
                    {
                        if(cantidad == 0)
                        {
                            nohay();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Mostrando cantidad de ingresos por tipo de vehiculo: \n Carros: {carro} \n Motos: {moto} \n Bicicleta: {bici}");
                            Console.WriteLine();
                            funcion();
                        }
                    }
                    else
                    {
                        if (eleccion == 5)
                        {
                            if(cantidad == 0)
                            {
                                nohay();
                            }
                            else
                            {
                                int mayor = permanencia[0];
                                int posicion = 0;
                                for (int i = 1; i < cantidad; i++)
                                {
                                    if (permanencia[i] > mayor)
                                    {
                                        mayor = permanencia[i];
                                        posicion = i;
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine($"El vehiculo con mayor tiempo de permanencia es: \n Placa: {placa[posicion]} \n Hora de ingreso: {datos_entrada[posicion,3]} \n Hora de salida: {datos_entrada[posicion,4]}  \n Tiempo total de permanencia: {mayor}");
                                Console.WriteLine();
                                funcion();
                            }
                        }
                        else
                        {
                            if(eleccion == 6)
                            {
                                menu();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Debes escoger un numero de los disponibles de este menu");
                                Console.WriteLine();
                                funcion();
                            }
                        }
                    }
                }
            }
        }
    }

    public static void nohay()
    {
        Console.WriteLine("");
        Console.WriteLine("--NO HAY REGISTROS--");
        Console.WriteLine("");
        funcion();
    }

    public static void registros()
    {
        Console.WriteLine();
        Console.WriteLine("¿Cuantos registros desea ingresar?");
        int nuevos = int.Parse(Console.ReadLine());
        string dato = "";
        if (cantidad + nuevos < 1 || cantidad + nuevos >40)
        {
            Console.WriteLine();
            Console.WriteLine("Cantidad ingresada no permitida, debe ser entre 1 y 40 ingresos diarios");
            Console.WriteLine();
        }
        else
        {
            for (int f = cantidad; f < cantidad + nuevos; f++)
            {
                for(int c = 0; c < 6; c++)
                {
                    switch (c)
                    {
                        case 0: dato = "Placa";
                            break;
                        case 1:
                            dato = "el numero de la Torre visitada";
                            break;
                        case 2:
                            dato = "el numero del Apartamento";
                            break;
                        case 3:
                            dato = "solo la Hora(Horario militar 0-24) de ingreso";
                            break;
                        case 4:
                            dato = "solo la Hora(Horario militar 0-24) de salida";
                            break;
                        case 5:
                            dato = "el Tipo de vehiculo (1-Carro   2-Moto   3-Bicicleta)";
                            break;
                        default: break;
                    }
                    if (c == 0)
                    {
                        Console.WriteLine($"Ingrese el numero de placa del vehiculo #{f+1}: ");
                        string nuevaPlaca = Console.ReadLine();
                        bool repetida = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (placa[i] == nuevaPlaca)
                            {
                                repetida = true;
                            }
                        }
                        if (repetida)
                        {
                            Console.WriteLine("Ya hay un carro con esa placa, ingrese otra placa nuevamente");
                            Console.WriteLine();
                            c--;
                        }
                        else
                        {
                            datos_entrada[f,c] = 0;
                            placa[f] = nuevaPlaca;
                            total++;
                            Console.WriteLine("Placa guardada");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (c == 3)
                        {
                            Console.WriteLine($"Ingrese {dato} del vehiculo #{f + 1}: ");
                            hora_en = int.Parse(Console.ReadLine());
                            if (hora_en < 0 || hora_en > 24)
                            {
                                Console.WriteLine("Hora ingresada no permitida");
                                Console.WriteLine();
                                c--;
                            }
                            else
                            {
                                datos_entrada[f, c] = hora_en;
                            }
                        }
                        else
                        {
                            if (c == 4)
                            {
                                Console.WriteLine($"Ingrese {dato} del vehiculo #{f + 1}: ");
                                hora_sal = int.Parse(Console.ReadLine());
                                if (hora_sal < 0 || hora_sal > 24 || hora_sal<hora_en)
                                {
                                    Console.WriteLine("Hora ingresada no permitida");
                                    Console.WriteLine();
                                    c--;
                                }
                                else
                                {
                                    datos_entrada[f, c] = hora_sal;
                                    salida[f] = hora_sal;
                                    permanencia[f] = hora_sal - hora_en;
                                }
                            }
                            else
                            {
                                if (c == 5)
                                {
                                    Console.WriteLine($"Ingrese {dato} del vehiculo #{f + 1}: ");
                                    vehiculo = int.Parse(Console.ReadLine());
                                    if (vehiculo < 1 || vehiculo > 3)
                                    {
                                        Console.WriteLine("Tipo de vehiculo incorrecto: ");
                                        Console.WriteLine();
                                        c--;
                                    }
                                    else
                                    {
                                        if (vehiculo == 1)
                                        {
                                            datos_entrada[f,c] = vehiculo;
                                            carro++;
                                        }
                                        else
                                        {
                                            if (vehiculo == 2)
                                            {
                                                datos_entrada[f, c] = vehiculo;
                                                moto++;
                                            }
                                            else
                                            {
                                                datos_entrada[f, c] = vehiculo;
                                                bici++;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Ingrese {dato} del vehiculo #{f + 1}: ");
                                    datos_entrada[f, c] = double.Parse(Console.ReadLine());
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Registro Guardado Correctamente");
                Console.WriteLine();
            }
            cantidad += nuevos;
            funcion();
        }
    }

    public static void menu()
    {
        Console.WriteLine("---BIENVENIDO USUARIO--- \n ¿Que programa desea ejecutar? \n 1.Sistema de control de turnos para una IPS \n 2.Sistema de control academico para seguimiento de notas \n 3.Sistema de control de parqueadero para conjunto residencial \n 4.Cerrar consola");
        int prog = int.Parse(Console.ReadLine());
        if (prog == 1)
        {
            punto1.ips();
        }
        else
        {
            if (prog == 2)
            {
                punto3.registro_estudiantes();
            }
            else
            {
                if(prog == 3)
                {
                    funcion();
                }
                else
                {
                    if(prog == 4)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Debes escoger una opcion de las anteriores");
                        menu();
                    }
                }
            }
        }
    }
}