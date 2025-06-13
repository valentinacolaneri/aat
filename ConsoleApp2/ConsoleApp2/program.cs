using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            EjercicioCronometro.Ejecutar();
        }
    }

    public class EjercicioCronometro
    {
        public static void Ejecutar()
        {
            Cronometro cronometro = new Cronometro();

            for (int i = 0; i < 5000; i++)
            {
                cronometro.IncrementarTiempo();
            }

            Console.WriteLine(cronometro.MostrarTiempo());
        }
    }
}
