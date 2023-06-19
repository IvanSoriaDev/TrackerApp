using Microsoft.Maui.Maps;
using TrackerApp.ViewModel;

namespace TrackerApp.View;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}
