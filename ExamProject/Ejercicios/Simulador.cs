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
                Console.WriteLine("3. Diésel");
                Console.Write("Ingrese el tipo de combustible (1-3): ");
                tipoCombustible = Convert.ToInt32(Console.ReadLine());

            } while (tipoCombustible < 1 || tipoCombustible > 3);

            // 2. Lectura y validación de la cantidad de litros (> 0 y <= 60)
            decimal litrosSolicitados;
            do
            {
                Console.Write("Ingrese la cantidad de litros solicitada (máximo 60): ");
            } while (!decimal.TryParse(Console.ReadLine(), out litrosSolicitados) || litrosSolicitados <= 0 || litrosSolicitados > 60);

            // 3. Asignación de precio por litro y nombre según el tipo (utilizando switch)
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
                    nombreCombustible = "Diésel";
                    break;
            }

            // 4. Simulación de carga en bloques de 5 litros (utilizando ciclo while)
            Console.WriteLine("\n--- Iniciando Carga de Combustible ---");
            decimal acumuladoLitros = 0m;

            while (acumuladoLitros < litrosSolicitados)
            {
                acumuladoLitros += 5.0m;

                // Ajustar si el último bloque excede lo solicitado
                if (acumuladoLitros > litrosSolicitados)
                {
                    acumuladoLitros = litrosSolicitados;
                }

                Console.WriteLine($"Progreso: {acumuladoLitros:N2} L. cargados...");
            }

            Console.WriteLine("--- Carga completada con éxito ---\n");

            // 5. Cálculos económicos
            decimal subtotal = acumuladoLitros * precioPorLitro;

            // Descuento según subtotal (utilizando if / else)
            decimal porcentajeDescuento = 0m;
            if (subtotal >= 1500.00m)
            {
                porcentajeDescuento = 0.05m; // 5%
            }
            else if (subtotal >= 1000.00m)
            {
                porcentajeDescuento = 0.03m; // 3%
            }
            else
            {
                porcentajeDescuento = 0.00m; // Sin descuento
            }

            decimal montoDescuento = subtotal * porcentajeDescuento;
            decimal totalPagar = subtotal - montoDescuento;

            // 6. Impresión del resumen / comprobante
            Console.WriteLine("==============================================");
            Console.WriteLine("             RESUMEN DE CARGA                 ");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Tipo de Combustible:  {nombreCombustible}");
            Console.WriteLine($"Precio por Litro:     L. {precioPorLitro:N2}");
            Console.WriteLine($"Total Litros Cargados:{acumuladoLitros:N2} L.");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Subtotal:             L. {subtotal:N2}");
            Console.WriteLine($"Descuento ({porcentajeDescuento * 100}%):     -L. {montoDescuento:N2}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"TOTAL A PAGAR:        L. {totalPagar:N2}");
            Console.WriteLine("==============================================\n"); 

        }
    }
}