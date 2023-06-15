using System;
static class Escape
{
    public static string[] IncognitasSalas = { "", "144", "26", "F", "41" };
    public static int estadoJuego = 1;
    public static string mensajeError = "";

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita)
    {
        mensajeError = "";
        if (Sala != estadoJuego)
        {
            mensajeError = "Sala Incorrecta";
            return false;
        }
        if (Incognita == IncognitasSalas[estadoJuego])
        {
            estadoJuego++;
            return true;
        }
        mensajeError = "Respuesta Incorrecta";
        return false;
    }
}