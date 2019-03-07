using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace InheritanceIntro
{
    class Frog : Animals
    {
        public string Ispoisonous;
        public Frog()  {    }

        public Frog(int height, string name, string ispoisonous)
        {
            Height = height;
            Name = name;
            Ispoisonous = ispoisonous;
        }

        public void Ribbit()
        {
            MessageBox.Show("Ribbit!");
        }
    }
}
