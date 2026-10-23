using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.Ejercicios
{
    public class Simulador
    {
        public void Simular()
        {
            Console.WriteLine("SIMULADOR DE CARGA DE COMBUSTIBLE");

            int tipoCombustible;
            do
            {
                Console.WriteLine("TIPO DE COMBUSTIBLE A CARGAR");
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Premium");
                Console.WriteLine("3. Disel");
                Console.Write("Ingrese el tipo de combustible (1-3): ");
                tipoCombustible = Convert.ToInt32(Console.ReadLine());

            } while (tipoCombustible < 1 || tipoCombustible > 3);

    
            decimal litrosSolicitados;
            do
            {
                Console.Write("Ingrese la cantidad de litros solicitada (maximo 60 litros): ");
                litrosSolicitados = Convert.ToDecimal(Console.ReadLine());
                if (litrosSolicitados <= 0 || litrosSolicitados > 60)
                {
                    Console.WriteLine("Cantidad inválida. Debe ser mayor a 0 y no exceder los 60 litros.");
                }
            } while (litrosSolicitados <= 0 || litrosSolicitados > 60);

            
            decimal precioPorLitro = 0m;
            string nombreCombustible = "";

            switch (tipoCombustible)
            {
                case 1:
                    precioPorLitro = 28.50m;
                    nombreCombustible = "Regular";
                    break;
                case 2:
                    precioPorLitro = 32.00m;
                    nombreCombustible = "Premium";
                    break;
                case 3:
                    precioPorLitro = 26.75m;
                    nombreCombustible = "Diesel";
                    break;
            }

            decimal acumuladoLitros = 0m;

            while (acumuladoLitros < litrosSolicitados)
            {
                acumuladoLitros += 5.0m;

                if (acumuladoLitros > litrosSolicitados)
                {
                    acumuladoLitros = litrosSolicitados;
                }

                Console.WriteLine($" {acumuladoLitros:N2} L. cargados.");
            }

            Console.WriteLine("Combustible cargado con exito...\n");

        
            decimal subtotal = acumuladoLitros * precioPorLitro;

            decimal porcentajeDescuento = 0m;
            if (subtotal >= 1500.00m)
            {
                porcentajeDescuento = 0.05m; 
            }
            else if (subtotal >= 1000.00m)
            {
                porcentajeDescuento = 0.03m;
            }
            else
            {
                porcentajeDescuento = 0.00m; 
            }

            decimal montoDescuento = subtotal * porcentajeDescuento;
            decimal totalPagar = subtotal - montoDescuento;

          
            Console.WriteLine("------------ FACTURA FINAL  ---------------  ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Tipo de Combustible:  {nombreCombustible}");
            Console.WriteLine($"Precio x Litro:     LPS. {precioPorLitro:N2}");
            Console.WriteLine($"Total Litros:{acumuladoLitros:N2} LPS.");
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Sub-total:             LPS. {subtotal:N2}");
            Console.WriteLine($"Descuento ({porcentajeDescuento * 100}%):     -LPS. {montoDescuento:N2}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"TOTAL  LPS. {totalPagar:N2}");
            Console.WriteLine("==============================================\n"); 

        }
    }
}