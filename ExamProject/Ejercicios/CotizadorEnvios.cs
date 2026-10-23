using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ExamProject.Ejercicios
{
    public class CotizadorEnvios
    {
        public void Cotizar()
        {
            
            Console.WriteLine(" Cotizador de envios    ");
            Console.WriteLine("==============================================\n");

            Console.Write("Ingrese el nommbre del cliente: ");
            string cliente = Console.ReadLine();
            Console.WriteLine($"Cliente: {cliente}");

            int zone=0;
            do 
            {
                Console.WriteLine("ZONAS DE ENVIOS ");
                Console.WriteLine("1. Zona 1 Local");
                Console.WriteLine("2. Zona 2 Departamental");
                Console.WriteLine("3. Zona 3 Nacional");
                Console.Write("Ingrese la zona de envio (1-3): ");
                zone = Convert.ToInt32(Console.ReadLine());
                
            } while (zone < 1 || zone > 3);

            decimal pesoPaquete;
            do
            {
                Console.Write("Ingrese el peso del paquete (kg): ");
                pesoPaquete = Convert.ToDecimal(Console.ReadLine());
                if (pesoPaquete <= 0)
                {
                    Console.WriteLine("El peso del paquete debe ser mayor a 0. Intente nuevamente.");
                }
            } while (pesoPaquete <= 0);

            int servicio;
            do
            {
                Console.WriteLine("TIPOS DE SERVICIO ");
                Console.WriteLine("1. Servicio Normal");
                Console.WriteLine("2. Servicio Express");
                Console.WriteLine("3. Mismo dia.");
                Console.Write("Ingrese el tipo de servicio (1-3): ");
                servicio = Convert.ToInt32(Console.ReadLine());
                if (servicio < 1 || servicio > 3)
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
                
            } while (servicio < 1 || servicio > 3);

            decimal valorPaquete;
            do
            {
                Console.Write("Ingrese el valor del paquete (HNL): ");
                valorPaquete = Convert.ToDecimal(Console.ReadLine());
                if (valorPaquete <= 0)
                {
                    Console.WriteLine("El valor del paquete debe ser mayor a 0.00 HNL. Intente nuevamente.");
                }
            } while (valorPaquete <= 0);

            decimal tarifaBase = 0m;
            string nombreZona = "";
            switch (zone)
            {
                case 1:
                    tarifaBase = 60.00m;
                    nombreZona = "Local";
                    break;
                case 2:
                    tarifaBase = 100.00m;
                    nombreZona = "Departamental";
                    break;
                case 3:
                    tarifaBase = 150.00m;
                    nombreZona = "Nacional";
                    break;
            }

            decimal recargo = 0m;
            if (pesoPaquete <= 1.0m)
            {
                recargo = 0.00m;
            }
            else if (pesoPaquete <= 5.0m)
            {
                recargo = 40.00m;
            }
            else if (pesoPaquete <= 10.0m)
            {
                recargo = 80.00m;
            }
            else
            {
                recargo = 140.00m;
            }

            
            decimal sumaBaseRecargo = tarifaBase + recargo;
            decimal porcentajeServicio = 0m;
            string nombreServicio = "";

            switch (servicio)
            {
                case 1:
                    porcentajeServicio = 0.00m;
                    nombreServicio = "estandar (+0%)";
                    break;
                case 2:
                    porcentajeServicio = 0.25m;
                    nombreServicio = "Express (+25%)";
                    break;
                case 3:
                    porcentajeServicio = 0.50m;
                    nombreServicio = "Mismo dia (+50%)";
                    break;
            }

            decimal recargoServicio = sumaBaseRecargo * porcentajeServicio; 


            decimal precioSeguro = 0m;
            bool EsAsegurado = valorPaquete > 5000.00m;

            if (EsAsegurado)
            {
                precioSeguro = valorPaquete * 0.02m;
            }
            decimal subtotal = sumaBaseRecargo + recargoServicio + precioSeguro;

           
            decimal ValorDescuento = 0m;
            if (subtotal > 700.00m)
            {
                ValorDescuento = subtotal * 0.05m;
            }

            decimal totalPagar = subtotal - ValorDescuento;

            string estadoSeguro = EsAsegurado ? "Envío asegurado" : "Envío sin seguro";

            // RECIBO 
            Console.WriteLine("              RECIBO DE ENVÍO                 ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Cliente:            {cliente}");
            Console.WriteLine($"Zona de Destino:    {nombreZona}");
            Console.WriteLine($"Peso del Paquete:   {pesoPaquete:N2} kg");
            Console.WriteLine($"Tipo de Servicio:   {nombreServicio}");
            Console.WriteLine($"Valor Declarado:    LPS. {valorPaquete:N2}");
            Console.WriteLine($"Estado de Seguro:   {estadoSeguro}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Tarifa Base (Zona): LPS. {tarifaBase:N2}");
            Console.WriteLine($"Recargo por Peso:   LPS. {recargo:N2}");
            Console.WriteLine($"Recargo Servicio:   LPS. {recargoServicio:N2}");
            Console.WriteLine($"Costo de Seguro:    LPS. {precioSeguro:N2}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Subtotal:           LPS. {subtotal:N2}");
            Console.WriteLine($"Descuento (5%):    -LPS. {ValorDescuento:N2}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"TOTAL A PAGAR:      LPS. {totalPagar:N2}");
        
        }
    }
}