public class GameConfig { 

    private static bool jugando = true;
    private static int puntuacion;

    public static void SetJugando(bool _jugando)
    {
        jugando = _jugando;
    }

    public static bool IsJugando()
    {
        return jugando;
    }

    public static void SetPuntuacion(int _puntuacion)
    {
        puntuacion = _puntuacion;
    }

    public static int GetPuntuacion()
    {
        return puntuacion;
    }

    public static void Arrancajuego()
    {
        jugando = true;
        puntuacion = 0;
    }

    public static void ParaJuego()
    {
        jugando = false;
    }

}
