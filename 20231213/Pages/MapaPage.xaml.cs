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

		//mimapa.MapType = MapType.Satellite;

		Polyline polyline = new Polyline { 
			StrokeColor = Colors.Red,
			StrokeWidth = 12,
			Geopath =
			{
				new Location(-16.50616054455793, -68.13072043571943),
				new Location(-16.50525839464598, -68.13176321234529),
				new Location(-16.50616984505056, -68.13240827881617)
			}
		};
		mimapa.MapElements.Add(polyline);
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

		Circle circle = new Circle { 
			Center = new Location(-16.50420002280675, -68.13115371953872),
			Radius = new Distance(20),
			StrokeColor = Color.FromArgb("#88FF0000"),
			StrokeWidth = 5,
			FillColor = Color.FromArgb("#88FFC8C8")
		};
		mimapa.MapElements.Add(circle);
	}
}