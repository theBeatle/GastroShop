using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFserver.Utils
{
    public static class Utilities
    {
        private static readonly string[] name = { "Four cheese", "Cessar", "Napoletana", "Grecheskii", "New-York" };
        private static readonly string[] description = { "Descrition 1", "Descrition 2", "Descrition 3", "Descrition 4", "Descrition 5" };
        private static readonly double[] raiting = { 1.1, 4.2, 10.5, 11.1, 7.2 };
        private static readonly string[] size = { "XXL", "XL", "L", "M", "S" };

        public static Meals[] RandomMealsGenerator(int mealsCount)
        {
            List<Meals> myMeals = new List<Meals>();

            Random rand = new Random();
            //int randNum = rand.Next(0, 5);
            for (var i = 0; i < mealsCount; i++)
            {
                myMeals.Add(new Meals
                {
                    ID = i,
                    Name = name[rand.Next(0, name.Length)],
                    Description = description[rand.Next(0, description.Length)],
                    Raiting = raiting[rand.Next(0, raiting.Length)],
                    Size = size[rand.Next(0, size.Length)]
                });
            }
            return myMeals.ToArray();
        }
    }
}