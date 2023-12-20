namespace Componentizacao.Componentes;

public partial class Cartao : ContentView
{
	public static readonly BindableProperty TituloProperty = BindableProperty.Create(nameof(Titulo), typeof(string), typeof(Cartao));
	public static readonly BindableProperty EnderecoImagemProperty = BindableProperty.Create(nameof(EnderecoImagem), typeof(string), typeof(Cartao));

    public string? Titulo 
	{ 
		get 
		{  
			return (string)GetValue(TituloProperty);
		} 
		set
		{
			SetValue(TituloProperty, value);
		}
	}

    public string? EnderecoImagem 
	{
		get
		{
			return (string)GetValue(EnderecoImagemProperty);
		}
		set
		{
			SetValue(EnderecoImagemProperty, value);
		}
	}

    public Cartao()
	{
		InitializeComponent();
	}
}