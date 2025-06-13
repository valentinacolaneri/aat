// Program.cs
using System;

namespace JugadorCansado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear jugadores
            IJugador profesional = new Profesional();
            IJugador amateur = new Amateur();

            // Probar jugador profesional
            ProbarJugador(profesional, "Profesional");

            Console.WriteLine(); // Separador

            // Probar jugador amateur
            ProbarJugador(amateur, "Amateur");
        }

        static void ProbarJugador(IJugador jugador, string tipoJugador)
        {
            Console.WriteLine($"Probando jugador {tipoJugador}:");

            Console.WriteLine($"Puede correr 30 minutos? {jugador.Correr(30)}");
            Console.WriteLine($"Está cansado? {jugador.Cansado()}");

            Console.WriteLine($"Puede correr 20 minutos? {jugador.Correr(20)}");
            Console.WriteLine($"Está cansado? {jugador.Cansado()}");

            jugador.Descansar(30);
            Console.WriteLine($"Descansó 30 minutos. Está cansado? {jugador.Cansado()}");
        }
    }
}