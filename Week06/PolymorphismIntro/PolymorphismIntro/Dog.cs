using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Dog : Animal
    {
        public string Breed;

        public override void Speak()
        {
            Bark();
        }
        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name, double weight)
        {
            Breed = breed;
            Height = height;
            Name = name;
            Weight = weight;
        }
    }
}