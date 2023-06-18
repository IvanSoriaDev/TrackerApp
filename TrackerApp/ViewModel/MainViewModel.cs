using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TrackerApp.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		string text = "Demo content";
	}
}

