﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Duck : Animal
    {
        public override void Speak()
        {
            Quack();
        }
        public void Quack()
        {
            MessageBox.Show("Quack");
        }

        public Duck() { }

        public Duck(int height, string name, double weight)
        {
            Height = height;
            Name = name;
            Weight = weight;
        }
    }
}