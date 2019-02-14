﻿using System;
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

namespace ClassesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dog bob;
        public MainWindow()
        {
            InitializeComponent();
            bob = new Dog();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            bob.bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            bob.name = DogName.Text;
            bob.sayname();
        }
    }
}
