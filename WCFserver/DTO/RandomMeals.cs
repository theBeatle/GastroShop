using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFserver.DTO;

namespace WCFserver
{
    public class Meals
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Raiting { get; set; }
        public string MealPicUrl { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public IngredientDTO[] Ingredients { get; set; }

    }
}