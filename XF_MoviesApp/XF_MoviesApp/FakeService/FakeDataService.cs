using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_MoviesApp.Models;

namespace XF_MoviesApp.FakeService {

    public class FakeDataService {

        public List<Movie> Movies { get; set; }
        public List<Director> Directors { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Actor> Actors { get; set; }
        public List<MovieActor> MoviesActors { get; set; }
        public List<Rating> Ratings { get; set; }

        public FakeDataService() {

            Genres = new List<Genre>() {

                new Genre() {
                    GenreId = 1,
                    Title = "Action"
                },

                new Genre() {
                    GenreId = 2,
                    Title = "Comedy"
                },

                new Genre() {
                    GenreId = 3,
                    Title = "Drama"
                },

                new Genre() {
                    GenreId = 4,
                    Title = "Crime"
                }
            };

            Directors = new List<Director>() {

                new Director() {
                    Age = 60,
                    DirectorId = 1,
                    FullName = "Martin Scorsese",
                    PhotoUrl = "https://pbs.twimg.com/profile_images/862827383/martytwitter_400x400.jpg"
                },

                new Director() {
                    DirectorId = 2,
                    PhotoUrl = "https://pbs.twimg.com/profile_images/565153007751667713/2eOoTi3g_400x400.jpeg",
                    FullName = "Quentin Tarantino",
                    Age = 55
                },

                new Director() {
                    DirectorId = 3,
                    Age = 41,
                    FullName = "Christopher Nolan",
                    PhotoUrl = "https://pbs.twimg.com/profile_images/534269668395991040/IlT5fubW_400x400.jpeg",
                },

                new Director() {
                    FullName = "Woody Allen",
                    DirectorId = 4,
                    PhotoUrl = "https://pbs.twimg.com/profile_images/1325800330/me_-_Copy_400x400.jpg",
                    Age = 60
                }
            };

            Actors = new List<Actor>() {

                new Actor() {
                    Age = 44,
                    PhotoUrl = "https://pbs.twimg.com/profile_images/603269306026106880/42CwEF4n_400x400.jpg",
                    FullName = "Tom Cruise",
                    ActorId = 1
                },

                new Actor(){
                    ActorId = 2,
                    FullName = "Tom Hanks",
                    PhotoUrl = "https://pbs.twimg.com/profile_images/280455139/l_ecdf8f7aa81d5163129fee54d83a5e63_400x400.jpg",
                    Age = 50
                },

                new Actor(){
                    ActorId = 3,
                    FullName = "Robert De Niro",
                    PhotoUrl = "https://pbs.twimg.com/profile_images/467239392554541056/93RpcwVD_400x400.jpeg",
                    Age = 74
                },

                new Actor(){
                    ActorId = 4,
                    FullName = "Will Smith",
                    PhotoUrl = "https://pbs.twimg.com/profile_images/601285380214693888/gVtTqq1B_400x400.jpg",
                    Age = 74
                },
            };


            Movies = new List<Movie>() {

                new Movie(){

                    DirectorId = 1,
                    Director = Directors.Where(x => x.DirectorId == 1).FirstOrDefault(),
                    Genre = Genres.Where(x => x.GenreId == 1).FirstOrDefault(),
                    GenreId = 1,
                    MovieId = 1,
                    Title = "The Shawshank Redemption",
                    Year = 1997,
                    PhotoUrl = "http://image.tmdb.org/t/p/w185/9O7gLzmreU0nGkIB6K3BsJbzvNv.jpg"
                },

                 new Movie(){

                    DirectorId = 3,
                    Director = Directors.Where(x => x.DirectorId == 3).FirstOrDefault(),
                    Genre = Genres.Where(x => x.GenreId == 2).FirstOrDefault(),
                    GenreId = 2,
                    MovieId = 2,
                    Title = "The Dark Knight",
                    Year = 2008,
                    PhotoUrl = "http://image.tmdb.org/t/p/w185/1hRoyzDtpgMU7Dz4JF22RANzQO7.jpg"
                },

                 new Movie(){

                    DirectorId = 4,
                    Director = Directors.Where(x => x.DirectorId == 4).FirstOrDefault(),
                    Genre = Genres.Where(x => x.GenreId == 3).FirstOrDefault(),
                    GenreId = 3,
                    MovieId = 3,
                    Title = "Schindler's List",
                    Year = 1993,
                    PhotoUrl = "http://image.tmdb.org/t/p/w185/yPisjyLweCl1tbgwgtzBCNCBle.jpg"
                },

                 new Movie(){

                    DirectorId = 2,
                    Director = Directors.Where(x => x.DirectorId == 2).FirstOrDefault(),
                    Genre = Genres.Where(x => x.GenreId == 4).FirstOrDefault(),
                    GenreId = 4,
                    MovieId = 4,
                    Title = "Forrest Gump",
                    Year = 1994,
                    PhotoUrl = "http://image.tmdb.org/t/p/w185/yE5d3BUhE8hCnkMUJOo1QDoOGNz.jpg"
                },

            };

            MoviesActors = new List<MovieActor>() {

                new MovieActor(){
                    MovieId = 1,
                    Movie = Movies.Where(x => x.MovieId == 1).FirstOrDefault(),
                    ActorId = 1,
                    Actor = Actors.Where(x => x.ActorId == 1).FirstOrDefault(),
                    MovieActorId = 1
                },
                new MovieActor(){
                    MovieId = 1,
                    Movie = Movies.Where(x => x.MovieId == 1).FirstOrDefault(),
                    ActorId = 2,
                    Actor = Actors.Where(x => x.ActorId == 2).FirstOrDefault(),
                    MovieActorId = 2
                },

                new MovieActor(){
                    MovieId = 1,
                    Movie = Movies.Where(x => x.MovieId == 1).FirstOrDefault(),
                    ActorId = 3,
                    Actor = Actors.Where(x => x.ActorId == 3).FirstOrDefault(),
                    MovieActorId = 3
                },

                new MovieActor(){

                    MovieId = 2,
                    Movie = Movies.Where(x => x.MovieId == 2).FirstOrDefault(),
                    ActorId = 1,
                    Actor = Actors.Where(x => x.ActorId == 1).FirstOrDefault(),
                    MovieActorId = 4
                },

                new MovieActor(){

                    MovieId = 2,
                    Movie = Movies.Where(x => x.MovieId == 2).FirstOrDefault(),
                    ActorId = 2,
                    Actor = Actors.Where(x => x.ActorId == 2).FirstOrDefault(),
                    MovieActorId = 5
                },

                new MovieActor(){

                    MovieId = 2,
                    Movie = Movies.Where(x => x.MovieId == 2).FirstOrDefault(),
                    ActorId = 4,
                    Actor = Actors.Where(x => x.ActorId == 4).FirstOrDefault(),
                    MovieActorId = 6
                },

                new MovieActor(){

                    MovieId = 3,
                    Movie = Movies.Where(x => x.MovieId == 3).FirstOrDefault(),
                    ActorId = 4,
                    Actor = Actors.Where(x => x.ActorId == 4).FirstOrDefault(),
                    MovieActorId = 7
                },

                new MovieActor(){

                    MovieId = 3,
                    Movie = Movies.Where(x => x.MovieId == 3).FirstOrDefault(),
                    ActorId = 3,
                    Actor = Actors.Where(x => x.ActorId == 3).FirstOrDefault(),
                    MovieActorId = 8
                },

                new MovieActor(){

                    MovieId = 4,
                    Movie = Movies.Where(x => x.MovieId == 4).FirstOrDefault(),
                    ActorId = 3,
                    Actor = Actors.Where(x => x.ActorId == 3).FirstOrDefault(),
                    MovieActorId = 9
                },

                new MovieActor(){

                    MovieId = 4,
                    Movie = Movies.Where(x => x.MovieId == 4).FirstOrDefault(),
                    ActorId = 1,
                    Actor = Actors.Where(x => x.ActorId == 1).FirstOrDefault(),
                    MovieActorId = 10
                },

            };

        }
    }
}
