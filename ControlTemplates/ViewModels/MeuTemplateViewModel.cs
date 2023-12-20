using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ControlTemplates.ViewModels
{
	public partial class MeuTemplateViewModel : ObservableObject
	{
		[RelayCommand]
		private void VerTermos()
		{
			App.Current.MainPage.DisplayAlert("Clicou", "Clicou sim!", "OK");
		}
	}
}
