using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Animals : Organism
    {
        public int Height;
        public string Name;
       

        public void Sayname()
        {
            MessageBox.Show("My name is" + Name);
        }
    }
}
