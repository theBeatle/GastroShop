using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFserver
{
    public class EatConstruct
    {
        public string TypeOfMeals { get; set; }
        public string CategoryIngredients { get; set; }
        public string Ingredient { get; set; }
        public string MeasurementUnit { get; set; }
        public double PriceForItem { get; set; }
    }
}