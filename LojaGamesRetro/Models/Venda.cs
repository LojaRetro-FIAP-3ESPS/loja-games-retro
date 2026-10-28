namespace LojaGamesRetro.Models;

public class Venda
{
    public Jogo Jogo { get; }
    public DateTime Data { get; }

    public Venda(Jogo jogo, DateTime data)
    {
        Jogo = jogo;
        Data = data;
    }
}
