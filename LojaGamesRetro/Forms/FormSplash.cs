namespace LojaGamesRetro.Forms;

public class FormSplash : Form
{
    private readonly Label lblTitulo = new();
    private readonly Label lblSubtitulo = new();

    public FormSplash()
    {
        Text = "Loja Retro";
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(600, 350);
        BackColor = Color.FromArgb(20, 20, 40);

        lblTitulo.Text = "LOJA DE GAMES RETRO";
        lblTitulo.Font = new Font("Consolas", 26, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Gold;
        lblTitulo.AutoSize = false;
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblTitulo.Bounds = new Rectangle(0, 80, 600, 70);

        lblSubtitulo.Text = "Insert coin to start...";
        lblSubtitulo.Font = new Font("Consolas", 12);
        lblSubtitulo.ForeColor = Color.LightGray;
        lblSubtitulo.AutoSize = false;
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblSubtitulo.Bounds = new Rectangle(0, 160, 600, 30);

        Controls.Add(lblTitulo);
        Controls.Add(lblSubtitulo);
    }
}
