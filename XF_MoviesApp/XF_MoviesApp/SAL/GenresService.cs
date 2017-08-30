using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_MoviesApp.FakeService;
using XF_MoviesApp.Models;

namespace XF_MoviesApp.SAL {

    public class GenresService {

        private FakeDataService fakeDataService;

        public GenresService() {

            fakeDataService = new FakeDataService();
        }

        public List<Genre> GetAllGenres() {
            return fakeDataService.Genres;
        }


    }
}
