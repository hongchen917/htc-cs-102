using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.Sayname();
            }

            List<Duck> ducks = new List<Duck>();

            Duck duck1 = new Duck(20, "John");
            Duck duck2 = new Duck(30, "Tom");

            ducks.Add(duck1);
            ducks.Add(duck2);

            foreach (Duck duck in ducks)
            {
                duck.Sayname();
            }
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("C:\\Users\\User1\\Source\\Repos\\htc-cs-102\\Week05\\InheritanceIntro\\InheritanceIntro\\duck.jpg"));
            Duck duck = new Duck();
            duck.Quack(); 
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }
    }
}
