using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.utils
{
    public class SubMenuEquipo
    {
        public static void Mostrar()
        {
            //SubMenu.
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****                EQUIPOS                 *****");
            Console.WriteLine("**************************************************");
            Console.WriteLine("***** 1. REGISTRO DE EQUIPOS.                *****");
            Console.WriteLine("***** 2. REGISTRO DE CUERPO TECNICO.         *****");
            Console.WriteLine("***** 3. REGISTRO DE CUERPO MEDICO.          *****");
            Console.WriteLine("***** 4. INSCRIPCION DEL TORNEO.             *****");
            Console.WriteLine("***** 5. NOTIFICACION DE TRANSFERENCIA.      *****");
            Console.WriteLine("***** 6. SALIR DEL TORNEO.                   *****");
            Console.WriteLine("***** 7. SALIR.                              *****");
            Console.WriteLine("**************************************************");

            //Accion a realizar segun la opcion.
            string? opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Registre un equipo...");
                    break;
                case "2":
                    Console.WriteLine("Registre cuerpo tecnico...");
                    break;
                case "3":
                    Console.WriteLine("Registre cuerpo medico...");
                    break;
                case "4":
                    Console.WriteLine("Realice la inscripcion al torneo...");
                    break;
                case "5":
                    Console.WriteLine("Notifique la transferencia...");
                    break;
                case "6":
                    Console.WriteLine("Salida del torneo...");
                    break;
                case "7":
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