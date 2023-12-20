namespace ControlTemplates.Paginas;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}

	private void ProximaTela(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("pagina2");
	}
}