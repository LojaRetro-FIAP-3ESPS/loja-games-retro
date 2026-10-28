using System.Globalization;
using LojaGamesRetro.Data;
using LojaGamesRetro.Models;

namespace LojaGamesRetro.Forms;

public class FormCards : Form
{
    private static readonly CultureInfo PtBr = new("pt-BR");

    private readonly Label lblTitulo = new();
    private readonly FlowLayoutPanel painel = new();

    public FormCards()
    {
        Text = "Cards de Jogos";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(920, 600);
        BackColor = Color.FromArgb(20, 20, 40);

        lblTitulo.Text = "ESCOLHA SEU JOGO";
        lblTitulo.Font = new Font("Consolas", 20, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Gold;
        lblTitulo.AutoSize = false;
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblTitulo.Bounds = new Rectangle(0, 10, 920, 50);

        painel.Bounds = new Rectangle(10, 70, 900, 520);
        painel.AutoScroll = true;

        Controls.Add(lblTitulo);
        Controls.Add(painel);

        foreach (var jogo in Repositorio.Jogos)
            painel.Controls.Add(CriarCard(jogo));
    }

    private Panel CriarCard(Jogo jogo)
    {
        var card = new Panel
        {
            Size = new Size(200, 230),
            Margin = new Padding(10),
            BackColor = Color.FromArgb(40, 40, 80)
        };

        var capa = new Label
        {
            Text = jogo.Console,
            Font = new Font("Consolas", 16, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = CorDoConsole(jogo.Console),
            TextAlign = ContentAlignment.MiddleCenter,
            Bounds = new Rectangle(0, 0, 200, 90)
        };

        var nome = new Label
        {
            Text = jogo.Nome,
            Font = new Font("Consolas", 11, FontStyle.Bold),
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Bounds = new Rectangle(5, 95, 190, 50)
        };

        var preco = new Label
        {
            Text = jogo.Preco.ToString("C", PtBr),
            Font = new Font("Consolas", 14, FontStyle.Bold),
            ForeColor = Color.Gold,
            TextAlign = ContentAlignment.MiddleCenter,
            Bounds = new Rectangle(5, 145, 190, 30)
        };

        var botao = new Button
        {
            Text = "Comprar",
            Font = new Font("Consolas", 11, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(0, 150, 90),
            ForeColor = Color.White,
            Cursor = Cursors.Hand,
            Bounds = new Rectangle(30, 182, 140, 35)
        };
        botao.FlatAppearance.BorderColor = Color.Gold;

        card.Controls.Add(capa);
        card.Controls.Add(nome);
        card.Controls.Add(preco);
        card.Controls.Add(botao);
        return card;
    }

    private static Color CorDoConsole(string console) => console switch
    {
        "SNES" => Color.FromArgb(110, 80, 180),
        "NES" => Color.FromArgb(190, 50, 50),
        "Mega Drive" => Color.FromArgb(40, 40, 40),
        "Atari" => Color.FromArgb(200, 120, 30),
        _ => Color.Gray
    };
}
