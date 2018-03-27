using System.Data.Entity;

namespace WCFserver
{
    class CustomInicializer<T> : DropCreateDatabaseAlways<GastroModel>
    {
        protected override void Seed(GastroModel context)
        {

            var ing1 = new Ingredients
            {
                Name = "chees",
                Description = "tasty",
                PriceForItem = 67.78,
                Category = new Category { Name = "chees" }
            };

            var ing2 = new Ingredients
            {
                Name = "papperoni",
                Description = "tasty",
                PriceForItem = 45.18,
                Category = new Category { Name = "kolbasa" }
            };

            Ingredients[] ings = { ing1, ing2 };



            context.ReadyMeals.Add(new ReadyMeals
            {
                MealPicUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwaKXTIRx1VRogry4_aM6RLR9-0pkO0VzfOtAoQs6QXX79jHVu",
                Name = "Pizza",
                Description = "Some tasty pizza",
                Raiting = 5.6,
                Size = "XXL",
                Ingredients = ings
            });


            context.SaveChanges();
        }
    }
}