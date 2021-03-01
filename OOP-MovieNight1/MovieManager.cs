using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MovieNight1
{
    class MovieManager
    {
        public static List<Movie> GetMovies()
        {
            return DalManager.GetMovies();
        }
        public static List<Actor> GetActors()
        {
            return DalManager.GetActors();
        }
        public static List<Movie> GetMovieTitle(string search)
        {
            return DalManager.GetMovieTitle(search);
        }
        public static List<Actor> GetActorSearch(string search)
        {
            return DalManager.GetActorSearch(search);
        }
        public static List<Movie> GetMoviesGenre(string search)
        {
            return DalManager.GetMovieGenreSearch(search);
        }
    }
}
