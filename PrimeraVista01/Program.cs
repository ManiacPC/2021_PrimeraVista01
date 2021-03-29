using System; // imports?

namespace PrimeraVista01 // package?
{
    class Program
    {
        static void Main(string[] args)
        {
            // configuración de consola
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            /* POO: Pruebas y demostraciones */
            Player jugadorUno = new Player("AnakinWolf31");            

            // salida
            Console.WriteLine("Esta es una app de consola");
            //Console.WriteLine("Se ha conectado el jugador " + jugadorUno.Nickname);
            Console.WriteLine($"Se ha conectado el jugador {jugadorUno.Nickname}");

            // pausa antes del cierre de consola
            Console.ReadKey();
        }
    }
}
