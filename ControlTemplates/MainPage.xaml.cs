namespace ControlTemplates
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void ProximaTela(object sender, EventArgs e)
		{
			Shell.Current.GoToAsync("pagina1");
		}
	}

}
