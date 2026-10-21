using System.Windows.Forms;

namespace Ceyloro.Windows;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        var openOverlayOnStartup = args.Any(argument => string.Equals(argument, "--show", StringComparison.OrdinalIgnoreCase));
        Application.Run(new TrayApplicationContext(openOverlayOnStartup));
    }
}
