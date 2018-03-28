using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFserver.DTO
{
    public class ReadyMealDTO
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