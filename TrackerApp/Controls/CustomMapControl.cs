using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace TrackerApp.Controls
{
	public class CustomMapControl : Microsoft.Maui.Controls.Maps.Map
    {
        #region Properties
        public Location InitialPosition
        {
            get => (Location)GetValue(InitialPositionProperty);
            set => SetValue(InitialPositionProperty, value);
        }

        public ObservableCollection<Pin> PinList
        {
            get => (ObservableCollection<Pin>)GetValue(PinListProperty);
            set => SetValue(PinListProperty, value);
        }

        public static readonly BindableProperty InitialPositionProperty = BindableProperty.Create(nameof(InitialPosition),
            typeof(Location),
            typeof(CustomMapControl),
            propertyChanged: OnInitialPositionChanged);

        public static readonly BindableProperty PinListProperty = BindableProperty.Create(nameof(PinList),
            typeof(ObservableCollection<Pin>),
            typeof(CustomMapControl),
            propertyChanged: OnPinListPropertyChanged);
        #endregion

        #region Property changed
        private static void OnInitialPositionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;

            var control = (CustomMapControl)bindable;

            var value = (Location)newValue;

            MapSpan mapSpan = MapSpan.FromCenterAndRadius(value, Distance.FromKilometers(0.444));
            control.MoveToRegion(mapSpan);
        }

        private static void OnPinListPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;

            var control = (CustomMapControl)bindable;

            var pinList = (ObservableCollection<Pin>)newValue;

            pinList.ToList().ForEach(pin => control.Pins.Add(pin));
        }
        #endregion

        public CustomMapControl()
		{
		}
	}
}

