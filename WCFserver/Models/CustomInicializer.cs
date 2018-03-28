using System.Data.Entity;

namespace WCFserver
{
    class CustomInicializer<T> : DropCreateDatabaseAlways<GastroModel>
    {
        protected override void Seed(GastroModel context)
        {
            var unitsOFMeasurement = new UnitsOfMeasurement { Name = "Gram", Abbreviation = "g" };

            var catChees = new Category { Name = "Chees", Description = "Chees" };
            var catMeat = new Category { Name = "Meat", Description = "Meat" };


            var ingCheder = new Ingredients
            {
               
                Name = "Cheder",
                Description = "tasty",
                PriceForItem = 67.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement
            };

          

            var ingChehel = new Ingredients
            {
                Name = "Chechel",
                Description = "tasty",
                PriceForItem = 32.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingAsadero = new Ingredients
            {
                Name = "Asadero",
                Description = "tasty",
                PriceForItem = 12.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingAsiago = new Ingredients
            {
                Name = "Asiago",
                Description = "tasty",
                PriceForItem = 19.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingPaperoni = new Ingredients
            {
                Name = "Papperoni",
                Description = "tasty",
                PriceForItem = 45.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingSalami = new Ingredients
            {
                Name = "Salami",
                Description = "tasty",
                PriceForItem = 65.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingKopchena = new Ingredients
            {
                Name = "Kopchena",
                Description = "tasty",
                PriceForItem = 45.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            Ingredients[] ingsFourChees = { ingCheder, ingPaperoni, ingChehel };

            context.ReadyMeals.Add(new ReadyMeals
            {
                MealPicUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwaKXTIRx1VRogry4_aM6RLR9-0pkO0VzfOtAoQs6QXX79jHVu",
                Name = "PizzaFourChees",
                Description = "Some tasty pizza",
                Raiting = 5.6,
                Size = "XXL",
                Ingredients = ingsFourChees
            });

            Ingredients[] ingsDiablo = { ingKopchena, ingAsiago, ingPaperoni };

            context.ReadyMeals.Add(new ReadyMeals
            {
                MealPicUrl = "http://images.pizza33.ua/products/product/yQfkJqZweoLn9omo68oz5BnaGzaIE0UJ.jpg",
                Name = "PizzaDiablo",
                Description = "Very hot tasty pizza",
                Raiting = 7.6,
                Size = "XXL",
                Ingredients = ingsDiablo
            });

            Ingredients[] ingsNapoletana = { ingAsiago, ingAsadero };

            context.ReadyMeals.Add(new ReadyMeals
            {
                MealPicUrl = "http://express-pizza.vn.ua/uploads/1/4/145b8f8eb6397682902b47ea3e5eaa2e.png",
                Name = "PizzaNapoletana",
                Description = "Light tasty pizza",
                Raiting = 3.6,
                Size = "XXL",
                Ingredients = ingsNapoletana
            });

            context.SaveChanges();
        }
    }
}