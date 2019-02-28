using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Movie> movielist;

        public MainWindow()
        {
            InitializeComponent();

            movielist = new List<Movie>();

        }

        private void buttonadd_Click(object sender, RoutedEventArgs e)
        {
            //get value from textbox
            string name = textBoxtitle.Text;
            int year = Convert.ToInt32(textBoxrelease.Text);
            //add movie to movie list
            Movie newmovie = new Movie(name, year);
            movielist.Add(newmovie);
            //clear text box
            textBoxtitle.Text = "";
            textBoxrelease.Text = "";
        }

        private void buttonshow_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in movielist)
            {
                movie.Show_movie();
            }
            
            
        }

        private void buttonremove_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
