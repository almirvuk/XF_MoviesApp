using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF_MoviesApp.FakeService;
using XF_MoviesApp.Models;
using XF_MoviesApp.SAL;

namespace XF_MoviesApp.ViewModels {

    public class MoviesListViewModel : BaseViewModel {

        private ObservableCollection<Movie> movies;
        public ObservableCollection<Movie> Movies {
            get { return movies; }
            set { movies = value; }
        }

        private ObservableCollection<Genre> genres;
        public ObservableCollection<Genre> Genres {
            get { return genres; }
            set { genres = value; }
        }

        private Genre selectedGenre = null;
        public Genre SelectedGenre {
            get { return selectedGenre; }
            set {
                selectedGenre = value;
                OnPropertyChanged();
            }
        }


        private bool searchItemsVisibility;
        public bool SearchItemsVisibility {
            get { return searchItemsVisibility; }
            set {
                searchItemsVisibility = value;
                OnPropertyChanged();
            }
        }


        public ICommand ShowSearchItemsCommand { get; private set; }
        public ICommand SearchCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }


        private MovieService movieService;
        private GenresService genreService;

        public MoviesListViewModel() {

            genreService = new GenresService();
            movieService = new MovieService();

            Genres = new ObservableCollection<Genre>(genreService.GetAllGenres());
            Movies = new ObservableCollection<Movie>();

            ShowSearchItemsCommand = new Command(ShowSearchItems);
            SearchCommand = new Command(RePopulateCollection);
            ResetCommand = new Command(
                () => {
                    selectedGenre = null;
                    RePopulateCollection();
                });

            RePopulateCollection();

        }

        void ShowSearchItems() {
            SearchItemsVisibility = !SearchItemsVisibility;
        }

        void RePopulateCollection() {

            Movies.Clear();

            if (selectedGenre != null) {

                var genreId = selectedGenre.GenreId;
                var filteredMovies = movieService.GetAllMoviesByGenre(genreId);
                foreach (var movie in filteredMovies) 
                    Movies.Add(movie);

            } else {

                var allMovies = movieService.GetAllMovies();
                foreach (var movie in allMovies)
                    Movies.Add(movie);
            }
           
        }
    }
}
