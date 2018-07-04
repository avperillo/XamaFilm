using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{
    public class AcknowledgmentViewModel : ViewModelBase
    {

        private List<License> _licenses;

        public List<License> Licenses
        {
            get { return _licenses; }
            set { _licenses = value; OnPropertyChanged(); }
        }


        public AcknowledgmentViewModel()
        {

            Licenses = new List<License>()
            {
                new License("ACR User Dialogs", "The MIT License", "https://github.com/aritchie/userdialogs"),
                new License("CarouselView control for Xamarin Forms", "The MIT License", "https://github.com/alexrainman/CarouselView"),
                new License("Fluent URL builder and testable HTTP for .NET", "The MIT License", "http://tmenier.github.io/Flurl/"),
                new License("Humanizer", "The MIT License", "https://github.com/Humanizr/Humanizer"),
                new License("Microcharts", "The MIT License", "https://github.com/aloisdeniel/Microcharts/"),
                new License("Monkey Cache", "The MIT License", "https://github.com/jamesmontemagno/monkey-cache"),
                new License("Json.NET", "The MIT License", "https://www.newtonsoft.com/json"),
                new License("Multilingual Plugin for Xamarin and Windows ", "The MIT License", "https://github.com/CrossGeeks/MultilingualPlugin"),
                new License("Splat", "The MIT License", "https://github.com/reactiveui/splat/"),
                new License("Iconize Plugin for Xamarin Forms", "Apache License, Version 2.0", "https://github.com/jsmarcus/Iconize"),
                new License("Xamarin Forms", "The MIT License", "https://www.xamarin.com/forms"),
                new License("Xamarin Forms Maps", "The MIT License", "https://www.xamarin.com/forms"),
            };

        }

    }
}
