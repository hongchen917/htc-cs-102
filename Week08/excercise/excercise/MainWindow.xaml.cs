using System;
using System.Collections.Generic;
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

namespace excercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();

            /*Rectangle myRect = new Rectangle();
            myRect.Height = 100;
            myRect.Width = 100;
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;

            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);

            myCanvas.Children.Add(myRect);*/

           /* Diamond myDiamond1 = new Diamond();
            myDiamond1.Fill = Brushes.Bisque;
            myDiamond1.Stroke = Brushes.Red;
            myDiamond1.StrokeThickness = 2;
            myCanvas.Children.Add(myDiamond1);*/
            

            Diamond myDiamond2 = new Diamond();
            myDiamond2.Height = 200;
            myDiamond2.Width = 50;
            myDiamond2.Fill = Brushes.AliceBlue;
            myDiamond2.Stroke = Brushes.Red;
            myDiamond2.StrokeThickness = 2;
            Canvas.SetLeft(myDiamond2,0);
            Canvas.SetTop(myDiamond2, 0);
            myCanvas.Children.Add(myDiamond2);
        }
    }
}
