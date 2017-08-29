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


    }
}
