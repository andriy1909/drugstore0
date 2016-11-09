using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drugstore
{
    class Items
    {
        int id;
        string name;
        string category;
        string text;
        int count;
        double price;
        double discont;
        string image;
        string position;

        public Items()
        {

        }
        public Items(int id, string name, string category, string text, int count, double price, double discont, string image, string position)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.text = text;
            this.count = count;
            this.price = price;
            this.discont = discont;
            this.image = image;
            this.position = position;
        }

        /*public Items getItemId(int id)
        {

            return;
        }*/

    }
}
