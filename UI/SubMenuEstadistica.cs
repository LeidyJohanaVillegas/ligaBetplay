using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.utils
{
    public class SubMenuEstadistica
    {
        public static void Mostrar()
        {
            //SubMenu.
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****               JUGADORES                *****");
            Console.WriteLine("**************************************************");
            Console.WriteLine("***** 1. JUGADOR CON MAS ASISTENCIAS.        *****");
            Console.WriteLine("***** 2. EQUIPOS CON MAS GOLES EN CONTRA.    *****");
            Console.WriteLine("***** 3. JUGADORES MAS CAROS POR EQUIPO.     *****");
            Console.WriteLine("***** 4. JUGADORES < AL PROMEDIO DE EDAD.    *****");
            Console.WriteLine("***** 5. SALIR.                              *****");
            Console.WriteLine("**************************************************");

            //Accion a realizar segun la opcion.
            string? opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Consulta el jugador con mas asistencias en el torneo...");
                    break;
                case "2":
                    Console.WriteLine("Consulte los equipos con mas goles en contra...");
                    break;
                case "3":
                    Console.WriteLine("Consulta los jugadores mas caros de los equipos del torneo...");
                    break;
                case "4":
                    Console.WriteLine("Consulta los jugadores que son menores al promedio de edad del torneo...");
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