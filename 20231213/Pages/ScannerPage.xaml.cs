using System.Diagnostics;
using ZXing.Net.Maui;

namespace _20231213.Pages;

public partial class ScannerPage : ContentPage
{
	public ScannerPage()
	{
		InitializeComponent();
		lectorCodigo.Options = new BarcodeReaderOptions() { 
			AutoRotate = true,
			Formats = BarcodeFormats.All, //BarcodeFormat.QrCode
            TryHarder = true,
			Multiple = false
		};

    }
	async void OnCodigoDeBarraDetectado(object sender, BarcodeDetectionEventArgs e)
	{
		Debug.WriteLine("Se detect� un c�digo de barras/QR");
		Dispatcher.Dispatch(()=> {
            resultadoCodigo.Text = $"{e.Results[0].Value} / {e.Results[0].Format}";
        });
    }
}