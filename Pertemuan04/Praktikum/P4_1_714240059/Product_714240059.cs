using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240059
{
    public abstract class Product_714240059
    {
        private string myType;
        private string myTitle;

        public Product_714240059()
        {

        }

        //constructor
        public Product_714240059(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        //property MyType
        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }

        //property MyTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        // metode abstrak untuk menampilkan info produk
        public abstract void DisplayInfo();
    }
}
