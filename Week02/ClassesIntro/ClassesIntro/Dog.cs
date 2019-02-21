using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string breed;
        public int height;
        public string name;

        public Dog(string breed,  int height, string name)
        {
            this.breed = breed;
            this.height = height;
            this.name = name;
        }

        public void bark() {
            MessageBox.Show("bark!");
        }

        public void sayname()
        {
          
            MessageBox.Show(name);
        }
    }
}