using LojaGamesRetro.Forms;

namespace LojaGamesRetro;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormSplash());
    }
}
