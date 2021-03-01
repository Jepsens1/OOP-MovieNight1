using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MovieNight1
{
    class Actor
    {
        #region Properties
        private int sid;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor
        public Actor(int _sid, string _firstname, string _lastname, int _year, string _description)
        {
            Sid = _sid;
            FirstName = _firstname;
            LastName = _lastname;
            Year = _year;
            Description = _description;
        }
        #endregion


    }
}
