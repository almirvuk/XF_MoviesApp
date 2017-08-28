using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_MoviesApp.Models {

    public class Movie {

        public int MovieId { get; set; }

        public string PhotoUrl { get; set; }
        public string Title { get; set; }

        public int Year { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
