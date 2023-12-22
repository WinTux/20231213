namespace _20231213.Pages;

public partial class MediaPage : ContentPage
{
	public MediaPage()
	{
		InitializeComponent();
	}
	public void OnBotonClic(object sender, EventArgs e)
	{
		if(video.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
			video.Pause();
		else
			video.Play();

		double vol = video.Volume;
		video.Volume = vol++;
		
	}
}