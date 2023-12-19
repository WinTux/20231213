using _20231213.Pages;

namespace _20231213
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

       async void OnEjemplo1Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GraphicsPage));
        }
        async void OnEjemplo2Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ScannerPage));
        }
        async void OnEjemplo3Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TrazosPage));
        }
        async void OnEjemplo4Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MapaPage));
        }
    }

}
