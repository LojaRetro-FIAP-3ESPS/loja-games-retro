using System.Globalization;
using LojaGamesRetro.Data;

namespace LojaGamesRetro.Forms;

public class FormRelatorio : Form
{
    private static readonly CultureInfo PtBr = new("pt-BR");

    private readonly Label lblTitulo = new();
    private readonly DataGridView grid = new();

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

        ConfigurarGrid();

        Controls.Add(lblTitulo);
        Controls.Add(grid);

        CarregarVendas();
    }

    private void ConfigurarGrid()
    {
        grid.Bounds = new Rectangle(30, 80, 840, 420);
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToResizeRows = false;
        grid.RowHeadersVisible = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grid.BackgroundColor = Color.FromArgb(30, 30, 60);
        grid.GridColor = Color.FromArgb(70, 70, 120);
        grid.BorderStyle = BorderStyle.None;
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 90, 200);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 11, FontStyle.Bold);
        grid.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 80);
        grid.DefaultCellStyle.ForeColor = Color.White;
        grid.DefaultCellStyle.Font = new Font("Consolas", 10);
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 90);

        grid.Columns.Add("colJogo", "Jogo");
        grid.Columns.Add("colConsole", "Console");
        grid.Columns.Add("colPreco", "Preço");
        grid.Columns.Add("colData", "Data / Hora");
    }

    private void CarregarVendas()
    {
        grid.Rows.Clear();

        foreach (var venda in Repositorio.Vendas)
        {
            grid.Rows.Add(
                venda.Jogo.Nome,
                venda.Jogo.Console,
                venda.Jogo.Preco.ToString("C", PtBr),
                venda.Data.ToString("dd/MM/yyyy HH:mm", PtBr));
        }
    }
}
