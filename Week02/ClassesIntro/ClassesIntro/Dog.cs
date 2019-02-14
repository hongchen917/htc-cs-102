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

        public void bark() {
            MessageBox.Show("bark!");
        }

        public void sayname()
        {
          
            MessageBox.Show(name);
        }
    }
}