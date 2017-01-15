using Xamarin.Forms;

namespace Reto1App
{
	public partial class MainPage : ContentPage
	{
		int numClicks = 1; 		public MainPage() 		{ 			InitializeComponent();

			btnPulsame.Clicked += (sender, e) => 
			{
				lblMensaje.Text = string.Format("Botó pulsado {0} veces", numClicks++);
			};  		}
	}
}
