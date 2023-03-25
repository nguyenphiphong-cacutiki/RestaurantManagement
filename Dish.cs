using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroup03_63KTPM2_Version01
{
   
    class Dish
    {
        public string id, name, howUse, pathImage, category;
        public int price;

        public Dish()
        {

        }
        public Dish(string id, string name, int price, string howUse, string pathImage,
            string category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.howUse = howUse;
            this.pathImage = pathImage;
            this.category = category;
        }
    }
}
