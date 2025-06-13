// JugadorBase.cs
namespace JugadorCansado
{
    public abstract class JugadorBase : IJugador
    {
        protected int MinutosCorriendo { get; set; }
        protected int LimiteMinutos { get; private set; }

        public bool Correr(int minutos)
        {
            if (Cansado())
            {
                return false;
            }

            MinutosCorriendo += minutos;
            return true;
        }

        public bool Cansado()
        {
            return MinutosCorriendo >= LimiteMinutos;
        }

        public void Descansar(int minutos)
        {
            MinutosCorriendo = System.Math.Max(0, MinutosCorriendo - minutos);
        }
    }
}