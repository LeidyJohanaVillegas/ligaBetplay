using ligaBetplay.Infraestructura.Repositorios;
using ligaBetplay.utils;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "server=localhost;database=ligaBetplay;user=root;password=123456;";
        var repo = new MySqlTorneoRepository(connectionString);
        bool salir = false;

        while (!salir)
        {
            MenuPrincipal.MostrarMenu();

            Console.Write("\nSeleccione una opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "0":
                    SubMenuTorneo.Mostrar(repo);
                    break;
                case "1":
                    SubMenuEquipo.Mostrar();
                    break;
                case "2":
                    SubMenuJugador.Mostrar();
                    break;
                case "3":
                    SubMenuTransferencia.Mostrar();
                    break;
                case "4":
                    //SubmenuEstadisticas.Mostrar();
                    break;
                case "5":
                    salir = true;
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (!salir)
            {
                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}
