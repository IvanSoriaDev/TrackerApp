using System;
using Microsoft.Maui.Controls.Maps;

namespace TrackerApp.Models
{
	public class CustomPin : Pin
	{
		public string TripId { get; set; }
		public string VehicleId { get; set; }
		public string VehicleLabel { get; set; }
	}
}

