namespace Screensound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        /*
         * Agora é sua vez! Na classe Avaliacao, crie uma regra de negócio para não permitir que notas menores que zero sejam registradas
         * Além disso, notas maiores que dez também não podem ser registradas
         */
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    
    }

    public int Nota { get; }


    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}   