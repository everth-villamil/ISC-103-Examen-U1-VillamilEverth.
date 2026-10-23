using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamProject.Ejercicios;



CotizadorEnvios cotizador = new CotizadorEnvios();
//cotizador.Cotizar();

Simulador simulador = new Simulador();
//simulador.Simular();

int opcion;
do 
{
    Console.WriteLine("             MENU DE EJERCICIOS               ");
    Console.WriteLine("==============================================");
    Console.WriteLine("1. Cotizador de envios");
    Console.WriteLine("2. Simulador de carga de combustible");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción (1-3): ");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

                    switch (opcion)
                {
                    case 1:
                        cotizador.Cotizar();
                        Console.Clear();
                        break;

                    case 2:
                        simulador.Simular();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...\n");
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        Console.Clear();
                        break;
                }
}while  (opcion != 3);
      

