using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

    public class PracticaPOO
    {
        static void Main(string[] args)
        {
            Garaje garaje = new Garaje();
            Coche coche1 = new Coche("BMW", "1234ABC");
            Coche coche2 = new Coche("Mercedes", "5678DEF");

            Random random = new Random();

            // Atender coches
            for (int i = 0; i < 2; i++)
            {
                if (garaje.aceptarCoche(coche1, "Frenos"))
                {
                    Console.WriteLine($"Coche {coche1.marca} {coche1.matricula} entra al garaje.");
                    double importe = random.NextDouble() * 100;
                    Console.WriteLine($"La avería tratada del coche es: {garaje.averia}");
                    Console.WriteLine($"El importe de la avería tratada es: {importe.ToString("C")}");
                    if (garaje.averia == "Aceite")
                    {
                        coche1.AgregarAceite(10);
                        Console.WriteLine("Se han agregado 10 litros de aceite.");
                    }
                    garaje.devolverCoche();
                    Console.WriteLine($"Coche {coche1.marca} {coche1.matricula} sale del garaje.");
                }

                if (garaje.aceptarCoche(coche2, "Aceite"))
                {
                    Console.WriteLine($"Coche {coche2.marca} {coche2.matricula} entra al garaje.");
                    double importe = random.NextDouble() * 100;
                    Console.WriteLine($"La avería tratada del coche es: {garaje.averia}");
                    Console.WriteLine($"El importe de la avería tratada es: {importe.ToString("C")}");
                    if (garaje.averia == "Aceite")
                    {
                        coche2.AgregarAceite(10);
                        Console.WriteLine("Se han agregado 10 litros de aceite.");
                    }
                    garaje.devolverCoche();
                    Console.WriteLine($"Coche {coche2.marca} {coche2.matricula} sale del garaje.");
                }
            }

            // Mostrar información de los coches
            Console.WriteLine($"El coche {coche1.marca} {coche1.matricula} tiene {coche1.LitrosAceite} litros de aceite.");
            Console.WriteLine($"El coche {coche2.marca} {coche2.matricula} tiene {coche2.LitrosAceite} litros de aceite.");

            Console.ReadLine();
        }
    }
}