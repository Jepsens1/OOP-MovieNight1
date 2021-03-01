using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MovieNight1
{
    class Movie
    {
        #region Properties

        
        //POPO Properties
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private int year;

        public int Year
        { 
            get { return year; }
            set { year = value; }
        }
        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region
        public Movie(int _id, string _title, int _year, string _genre, string _desc)
        {
            Id = _id;
            Title = _title;
            Year = _year;
            Genre = _genre;
            Description = _desc;
        }
        #endregion




    }
}
