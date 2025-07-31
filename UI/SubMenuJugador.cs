using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.utils
{
    public class SubMenuJugador
    {
        public static void Mostrar()
        {
            //SubMenu.
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****               JUGADORES                *****");
            Console.WriteLine("**************************************************");
            Console.WriteLine("***** 1. AGREGAR JUGADOR.                    *****");
            Console.WriteLine("***** 2. ACTUALIZAR DATOS DEL JUGADOR.       *****");
            Console.WriteLine("***** 3. BUSCAR JUGADOR.                     *****");
            Console.WriteLine("***** 4. ELIMINAR JUGADOR.                   *****");
            Console.WriteLine("***** 5. SALIR.                              *****");
            Console.WriteLine("**************************************************");

            //Accion a realizar segun la opcion.
            string? opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Registre un jugador...");
                    break;
                case "2":
                    Console.WriteLine("Actualice los datos del jugador...");
                    break;
                case "3":
                    Console.WriteLine("Consulte los datos del jugador...");
                    break;
                case "4":
                    Console.WriteLine("Elimine el jugador...");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("\nPresione ENTER para volver...");
            Console.ReadLine();
        }
    }
}