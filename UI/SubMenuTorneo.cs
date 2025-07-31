using System;
using ligaBetplay.Dominio.Entidades;
using ligaBetplay.Infraestructura.Repositorios;

namespace ligaBetplay.utils
{
    public class SubMenuTorneo
    {
        public static void Mostrar(MySqlTorneoRepository repo)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("*****                TORNEO                  *****");
                Console.WriteLine("**************************************************");
                Console.WriteLine("***** 1. AGREGAR TORNEO.                     *****");
                Console.WriteLine("***** 2. BUSCAR TORNEO.                      *****");
                Console.WriteLine("***** 3. ELIMINAR TORNEO.                    *****");
                Console.WriteLine("***** 4. ACTUALIZAR TORNEO.                  *****");
                Console.WriteLine("***** 5. SALIR.                              *****");
                Console.WriteLine("**************************************************");
                Console.Write("Seleccione una opción: ");

                string? opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarTorneo(repo);
                        break;
                    case "2":
                        Console.WriteLine("Consulte el torneo...");
                        break;
                    case "3":
                        Console.WriteLine("Elimine el torneo...");
                        break;
                    case "4":
                        Console.WriteLine("Actualice la informacion del torneo...");
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                }
            }
        }

        private static void AgregarTorneo(MySqlTorneoRepository repo)
        {
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****             NUEVO TORNEO               *****");
            Console.WriteLine("**************************************************");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Fecha de inicio (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaInicio);

            Console.Write("Fecha fin (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaFin);

            Console.Write("Ubicación: ");
            string ubicacion = Console.ReadLine() ?? "";

            Console.Write("Estado (activo, finalizado, cancelado): ");
            string estado = Console.ReadLine() ?? "activo";

            var torneo = new Torneo
            {
                Nombre = nombre,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                Ubicacion = ubicacion,
                Estado = estado
            };

            repo.AddTorneo(torneo);
            Console.WriteLine("Torneo agregado con éxito...");
        }
    }
}
