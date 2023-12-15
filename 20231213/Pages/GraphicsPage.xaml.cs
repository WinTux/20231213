using System.Timers;

namespace _20231213.Pages;

public partial class GraphicsPage : ContentPage
{
	public GraphicsPage()
	{
		InitializeComponent();
		var temporizador = new System.Timers.Timer(1000);
		temporizador.Elapsed += new ElapsedEventHandler(RedibujarReloj);
		temporizador.Start();
	}

	public void RedibujarReloj(object sender, ElapsedEventArgs e)
	{
		var graficosView = this.relojGraphicsView;
		graficosView.Invalidate();
    }
}