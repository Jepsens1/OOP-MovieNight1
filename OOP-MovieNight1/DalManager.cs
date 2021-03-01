using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace OOP_MovieNight1
{
    class DalManager
    {
        //Creates connection string
        private static string connstring = @"Server=DESKTOP-L52FU9Q\MSSQLSERV2;Initial Catalog=MCU; Integrated Security=SSPI";

        public static List<Movie> GetMovies()
        {
            List<Movie> moviesList = new List<Movie>();
            //Select data from the database
            string DataFromMovies = "SELECT * FROM Movie";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Opens the connection to database
                connection.Open();

                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(DataFromMovies, connection);

                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    string genre = (string)rdr["Genre"];
                    int year = (int)rdr["Year"];
                    string description = (string)rdr["Description"];
                    //Creates movie object, and adds to list
                    Movie m = new Movie(id, title, year, genre, description);
                    moviesList.Add(m);
                }
                
            }
                return moviesList;
        }
        public static List<Actor> GetActors()
        {
            List<Actor> actorList = new List<Actor>();
            //Select statement
            string getActor = "Select * FROM actor";
            //Connects to database
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Open the connection
                connection.Open();
                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(getActor, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through data
                while (rdr.Read())
                {
                    int id = (int)rdr["SID"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["LastName"];
                    int year = (int)rdr["Year"];
                    string desc = (string)rdr["Description"];

                    Actor actor = new Actor(id, firstName, lastName, year, desc);
                    actorList.Add(actor);
                }
            }
            return actorList;
        }
        public static List<Movie> GetMovieTitle(string search)
        {

            List<Movie> movieTitleList = new List<Movie>();
            //Select data from the database
            string DataFromMovies = "SELECT * FROM Movie WHERE Title LIKE @search";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Opens the connection to database
                connection.Open();

                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(DataFromMovies, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    string genre = (string)rdr["Genre"];
                    int year = (int)rdr["Year"];
                    string description = (string)rdr["Description"];
                    //Creates movie object, and adds to list
                    Movie movietitle = new Movie(id, title, year, genre, description);
                    movieTitleList.Add(movietitle);
                }

            }
            return movieTitleList;
        }
        public static List<Actor> GetActorSearch(string search)
        {
            List<Actor> actorList = new List<Actor>();
            //Select statement
            string getActor = "Select * FROM actor WHERE LastName LIKE @search";
            //Connects to database
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Open the connection
                connection.Open();
                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(getActor, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through data
                while (rdr.Read())
                {
                    int id = (int)rdr["SID"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["LastName"];
                    int year = (int)rdr["Year"];
                    string desc = (string)rdr["Description"];

                    Actor actor = new Actor(id, firstName, lastName, year, desc);
                    actorList.Add(actor);
                }
            }
            return actorList;
        }
        public static List<Movie> GetMovieGenreSearch(string search)
        {
            List<Movie> movieGenreList = new List<Movie>();
            //Select data from the database
            string DataFromMovies = "SELECT * FROM Movie WHERE Genre Like @search";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Opens the connection to database
                connection.Open();

                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(DataFromMovies, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    string genre = (string)rdr["Genre"];
                    int year = (int)rdr["Year"];
                    string description = (string)rdr["Description"];
                    //Creates movie object, and adds to list
                    Movie moviegenre = new Movie(id, title, year, genre, description);
                    movieGenreList.Add(moviegenre);
                }

            }
            return movieGenreList;
        }
    }
}
