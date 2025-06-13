using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cronometro
    {
        private int minutos;
        private int segundos;

        public Cronometro()
        {
            minutos = 0;
            segundos = 0;
        }

        public void Reiniciar()
        {
            minutos = 0;
            segundos = 0;
        }

        public void IncrementarTiempo()
        {
            segundos++;

            if (segundos >= 60)
            {
                minutos++;
                segundos = 0;
            }
        }

        public string MostrarTiempo()
        {
            return minutos + " minutos, " + segundos + " segundos";
        }
    }

}
