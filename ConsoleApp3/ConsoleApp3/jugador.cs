namespace JugadorCansado
{
    public interface IJugador
    {
        bool Correr(int minutos);
        bool Cansado();
        void Descansar(int minutos);
    }
}
