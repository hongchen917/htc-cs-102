using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    class restaurant
    {
        public string phone_number;
        public string store_name;
        public string order;
        public string size;

       public void tellname()
        {
            store_name = "hello";
            MessageBox.Show(store_name);
        }

    }
}
