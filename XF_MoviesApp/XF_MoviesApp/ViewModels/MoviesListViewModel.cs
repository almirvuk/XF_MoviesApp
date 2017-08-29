using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_MoviesApp.FakeService;
using XF_MoviesApp.Models;

namespace XF_MoviesApp.ViewModels {

    public class MoviesListViewModel {

        private ObservableCollection<Movie> movies;
        public ObservableCollection<Movie> Movies {
            get { return movies; }
            set { movies = value; }
        }

        public MoviesListViewModel() {

            FakeDataService fakeDataService = new FakeDataService();
            var listOfMovies = fakeDataService.Movies;

            Movies = new ObservableCollection<Movie>(listOfMovies);
        }


    }
}
