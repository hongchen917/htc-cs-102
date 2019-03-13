using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Cat : Animal
    {
        public string Breed;

        public override void Speak()
        {
            Meow();
        }
        public void Meow()
        {
            MessageBox.Show("Meow");
        }

        public Cat() { }

        public Cat(string breed, int height, string name, double weight)
        {
            Breed = breed;
            Height = height;
            Name = name;
            Weight = weight;
        }
    }
}
