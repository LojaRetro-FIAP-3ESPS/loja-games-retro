using LojaGamesRetro.Models;

namespace LojaGamesRetro.Data;

public static class Repositorio
{
    public static List<Jogo> Jogos { get; } = new()
    {
        new Jogo("Super Mario World", "SNES", 129.90m),
        new Jogo("Sonic the Hedgehog", "Mega Drive", 89.90m),
        new Jogo("The Legend of Zelda", "NES", 149.90m),
        new Jogo("Street Fighter II", "SNES", 99.90m),
        new Jogo("Pac-Man", "Atari", 59.90m),
        new Jogo("Mortal Kombat", "Mega Drive", 79.90m),
        new Jogo("Donkey Kong Country", "SNES", 119.90m),
        new Jogo("Metroid", "NES", 109.90m)
    };

    public static List<Venda> Vendas { get; } = new();
}
