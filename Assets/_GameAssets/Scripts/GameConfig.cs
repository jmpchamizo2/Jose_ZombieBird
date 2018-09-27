public class GameConfig { 

    private static bool jugando = true;

    public static void SetJugando(bool _jugando)
    {
        jugando = _jugando;
    }

    public static bool IsJugando()
    {
        return jugando;
    }

    public static void Arrancajuego()
    {
        jugando = true;
    }

    public static void ParaJuego()
    {
        jugando = false;
    }

}
