using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        public string AnimationStudio { get; set; }
        public string AnimationType { get; set; }

        public AnimatedMovie(string title, int releaseyear, string studio, string type)
        {
            Title = title;
            ReleaseYear = releaseyear;
            AnimationStudio = studio;
            AnimationType = type;
        }

        public override void ShowDetails()
        {

            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            infoString += "\nAnimation Studio: " + this.AnimationStudio;
            infoString += "\nAnimation Type: " + this.AnimationType;
            MessageBox.Show(infoString);
        }

    }
}
