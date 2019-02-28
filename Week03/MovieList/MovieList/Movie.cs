using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string MovieName;
        private int ReleaseYear;
        private string Director;
        private int length;
        private string genre;

        public Movie (string name, int releaseYear)
        {
            MovieName = name;
            ReleaseYear = releaseYear;
        }

        public void Show_movie()
        {
            MessageBox.Show(MovieName + "  " + ReleaseYear);
        }
    }
}
