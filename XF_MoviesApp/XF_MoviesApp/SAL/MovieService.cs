using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_MoviesApp.FakeService;
using XF_MoviesApp.Models;

namespace XF_MoviesApp.SAL {

    public class MovieService {

        FakeDataService fakeDataService;

        public MovieService() {
            fakeDataService = new FakeDataService();
        }

        public List<Movie> GetAllMovies() {
            // 
            return fakeDataService.Movies;
        }

        public Movie GetMovieById(int id) {
            return fakeDataService.Movies.Where(m => m.MovieId == id).FirstOrDefault();
        }
        
        public List<Actor> GetAllActorsById(int movieId) {
            return fakeDataService.MoviesActors.Where(m => m.MovieId == movieId)
                                               .Select(movieActorItem => movieActorItem.Actor).ToList();
        }

        public List<Movie> GetAllMoviesByGenre(int genreId) {
            return fakeDataService.Movies.Where(x => x.GenreId == genreId).ToList();
        }


    }
}
