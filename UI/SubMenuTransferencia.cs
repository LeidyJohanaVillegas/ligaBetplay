using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.utils
{
    public class SubMenuTransferencia
    {
        public static void Mostrar()
        {
            //SubMenu.
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****            TRANSFERENCIAS              *****");
            Console.WriteLine("**************************************************");
            Console.WriteLine("***** 1. COMPRAR JUGADOR.                    *****");
            Console.WriteLine("***** 2. PRESTAR JUGADOR.                    *****");
            Console.WriteLine("***** 3. SALIR.                              *****");
            Console.WriteLine("**************************************************");

            //Accion a realizar segun la opcion.
            string? opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Realice la compra de un jugador...");
                    break;
                case "2":
                    Console.WriteLine("Solicite el prestamo de un jugador...");
                    break;
                case "3":
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