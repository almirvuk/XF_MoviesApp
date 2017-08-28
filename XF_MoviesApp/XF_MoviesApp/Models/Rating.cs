using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_MoviesApp.Models {

    public class Rating {

        public int RatingId { get; set; }
        public string FullName { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
    }
}
