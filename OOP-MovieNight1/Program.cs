using System;
using System.Collections.Generic;

namespace OOP_MovieNight1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movie = MovieManager.GetMovies();
            List<Actor> actor = MovieManager.GetActors();
            List<Movie> movietitle = MovieManager.GetMovieTitle("The Dark Knight");
            List<Actor> Actorsearch = MovieManager.GetActorSearch("Freeman");
            List<Movie> genresearch = MovieManager.GetMoviesGenre("Drama");
            Console.WriteLine("Movies:");
            foreach (Movie item in movie)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("\nActors:");
            foreach (Actor item in actor)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("\nMovieTitle with parameters");
            foreach (Movie item in movietitle)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("\nActor search with parameters");
            foreach (Actor item in Actorsearch)
            {
                Console.WriteLine(item.LastName);
            }
            Console.WriteLine("\nGenre search with parameters");
            foreach (Movie item in genresearch)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
