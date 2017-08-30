using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_MoviesApp.FakeService;
using XF_MoviesApp.Models;
using XF_MoviesApp.SAL;

namespace XF_MoviesApp.ViewModels {

    public class MovieDetailsViewModel : BaseViewModel{

        private string moviePhotoUrl;
        public string MoviePhotoUrl {
            get { return moviePhotoUrl; }
            set { moviePhotoUrl = value;
                OnPropertyChanged();
            }
        }

        private string title;
        public string Title {
            get { return title; }
            set { title = value;
                OnPropertyChanged();

            }
        }

        private string genreTitle;
        public string GenreTitle {
            get { return genreTitle; }
            set { genreTitle = value;
                OnPropertyChanged();
            }
        }

        private string directorPhotoUrl;
        public string DirectorPhotoUrl {
            get { return directorPhotoUrl; }
            set { directorPhotoUrl = value;
                OnPropertyChanged();
            }
        }

        private string directorName;
        public string DirectorName {
            get { return directorName; }
            set { directorName = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<Actor> actors;
        public ObservableCollection<Actor> Actors {
            get { return actors; }
            set { actors = value; }
        }

        MovieService movieService ;

        public MovieDetailsViewModel(int movieId) {

            movieService = new MovieService();
            Movie movie = movieService.GetMovieById(movieId);

            Init(movie);
        }

        void Init(Movie movie) {

            MoviePhotoUrl = movie.PhotoUrl;
            Title = movie.Title + "(" + movie.Year + ")";
            GenreTitle = movie.Genre.Title;

            DirectorName = movie.Director.FullName;
            DirectorPhotoUrl = movie.Director.PhotoUrl;

            var allActors = movieService.GetAllActorsById(movie.MovieId);
            Actors = new ObservableCollection<Actor>(allActors);
        }

    }
}
