using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Dog : Animals
    {
        public string Breed;

        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            Breed = breed;
            Height = height;
            Name = name;
        }

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

    }
}