namespace LojaGamesRetro.Forms;

public class FormMenu : Form
{
    private readonly Label lblTitulo = new();
    private readonly Button btnGames = new();
    private readonly Button btnRelatorio = new();
    private readonly Button btnSair = new();

    public FormMenu()
    {
        Text = "Loja Retro - Menu";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(800, 500);

        lblTitulo.Text = "MENU PRINCIPAL";
        lblTitulo.Font = new Font("Consolas", 22, FontStyle.Bold);
        lblTitulo.AutoSize = false;
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblTitulo.Bounds = new Rectangle(0, 50, 800, 60);

        btnGames.Text = "Games";
        btnGames.Bounds = new Rectangle(250, 150, 300, 55);
        btnGames.Click += (s, e) => new FormCards().ShowDialog(this);

        btnRelatorio.Text = "Relatório de Vendas";
        btnRelatorio.Bounds = new Rectangle(250, 230, 300, 55);
        btnRelatorio.Click += (s, e) => new FormRelatorio().ShowDialog(this);

        btnSair.Text = "Sair";
        btnSair.Bounds = new Rectangle(250, 310, 300, 55);
        btnSair.Click += (s, e) => Close();

        Controls.Add(lblTitulo);
        Controls.Add(btnGames);
        Controls.Add(btnRelatorio);
        Controls.Add(btnSair);
    }
}
