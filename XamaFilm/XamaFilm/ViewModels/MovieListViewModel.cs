using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{
    public class MovieListViewModel: ViewModelBase
    {

        private IList<Movie> _movies;

        public IList<Movie> Movies
        {
            get => _movies;
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }
        
        private readonly IDataService _dataService;

        public MovieListViewModel(IDataService dataService)
        {
            _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));

            LoadData();
        }

        private async void LoadData()
        {
            Movies = await _dataService.GetMoviesAsync();
        }
    }
}
