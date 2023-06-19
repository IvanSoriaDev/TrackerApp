using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Maps;
using TrackerApp.Models;

namespace TrackerApp.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		ObservableCollection<Pin> mapPinsList = new ObservableCollection<Pin>();

		[ObservableProperty]
		Location initialPin = new Location
		{
			Latitude = 33.09903715489089,
			Longitude = -96.82118755867151
        };

        public MainViewModel()
		{
			mapPinsList = new ObservableCollection<Pin>
			{
				new Pin
                {
					Label = "Home",
					Location = new Location(33.09903715489089, -96.82118755867151)
				}
			};
		}
	}
}

