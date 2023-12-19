namespace ListaHorizontal
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}

	public class ViewModel
	{
        public List<string> Devices { get; set; }

        public ViewModel()
        {
			Devices = new List<string>()
			{
				"TV",
				"Ar-Condicionado",
				"Video Game",
				"Computador",
				"Notebook"
			};
        }
    }

}
