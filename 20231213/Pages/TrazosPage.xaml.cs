using CommunityToolkit.Maui.Core;

namespace _20231213.Pages;

public partial class TrazosPage : ContentPage
{
	public TrazosPage()
	{
		InitializeComponent();
	}
	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e)
	{
		var stream = await lienzo.GetImageStream(200,200);
		Dispatcher.Dispatch(() => {
			imagen.Source = ImageSource.FromStream(() => stream);
		});
	}
}