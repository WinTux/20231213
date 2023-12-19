using _20231213.Pages;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui;

namespace _20231213
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit()
                .UseMauiMaps();
            builder.UseBarcodeReader();
            //Lo siguiente no es obligatorio, es para cuando notemos que nunca se gatilla el evento de lectura de codigo (barras/QR)
            builder.ConfigureMauiHandlers(h => {
                h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView),
                    typeof(CameraBarcodeReaderViewHandler)
                    );
                h.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView),
                    typeof(BarcodeGeneratorViewHandler)
                    );
            });
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<GraphicsPage>();
            builder.Services.AddTransient<ScannerPage>();
            builder.Services.AddTransient<TrazosPage>();
            builder.Services.AddTransient<MapaPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
