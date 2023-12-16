using _20231213.Pages;

namespace _20231213
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GraphicsPage), typeof(GraphicsPage));
            Routing.RegisterRoute(nameof(ScannerPage), typeof(ScannerPage));
        }
    }
}
