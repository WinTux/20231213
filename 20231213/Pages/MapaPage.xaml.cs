using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Diagnostics;

namespace _20231213.Pages;

public partial class MapaPage : ContentPage
{
	public MapaPage()
	{
		InitializeComponent();
		//Location location = new Location(-16.5041316859033, -68.13049947713193);
		//MapSpan mapSpan = new MapSpan(location, 0.01,0.01);
		//mimapa.MoveToRegion(mapSpan);

		mimapa.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin { 
			Label = "Pepe está en el colegio Don Bosco",
			Location = new Location(-16.5034187368878, -68.13048092406169)
		});

		mimapa.MapType = MapType.Satellite;
    }

	async void OnMapaClic(object sender, MapClickedEventArgs e)
	{
		Debug.WriteLine($"[MAPA] Clic: {e.Location.Latitude}, {e.Location.Longitude}");
		Polygon recuadro = new Polygon
		{
			StrokeColor = Color.FromArgb("#FF0000"),
			StrokeWidth = 8,
			FillColor = Color.FromArgb("#8800AAFF"),
			Geopath =
			{
				new Location(-16.500962176388644, -68.13296701536892),
				new Location(-16.501136598993906, -68.13280569465373),
				new Location(-16.50077294413901, -68.13236978548714),
				new Location(-16.50061662170619, -68.13255856504747)
			}
		};
		mimapa.MapElements.Add(recuadro);
	}
}