namespace LojaGamesRetro.Forms;

public class FormRelatorio : Form
{
    private readonly Label lblTitulo = new();

    public FormRelatorio()
    {
        Text = "Relatório de Vendas";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(900, 600);
        BackColor = Color.FromArgb(20, 20, 40);

        lblTitulo.Text = "RELATÓRIO DE VENDAS";
        lblTitulo.Font = new Font("Consolas", 20, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Gold;
        lblTitulo.AutoSize = false;
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblTitulo.Bounds = new Rectangle(0, 15, 900, 50);

        Controls.Add(lblTitulo);
    }
}
