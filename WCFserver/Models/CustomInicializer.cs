using System.Data.Entity;

namespace WCFserver
{
    internal class CustomInicializer<T> : DropCreateDatabaseAlways<GastroModel>
    {
        protected override void Seed(GastroModel context)
        {
            context.Accounts.Add(new Account { Login = "test", Password = "test", FirstName = "Andriy", Surname = "Valentynovych",
            Email="test@gmail.com", Address="Naberegna 58", PhoneNumber="+12345678952300"});

            context.Categories.Add(new Category { Name = "Pizza", Description = "Mochne" });
            context.Categories.Add(new Category { Name = "Salat", Description = "Sochne" });
            context.Categories.Add(new Category { Name = "Drink", Description = "Pytne" });

            context.UnitsOfMeasurements.Add(new UnitsOfMeasurement { Name = "Gram", Abbreviation = "g" });
            context.UnitsOfMeasurements.Add(new UnitsOfMeasurement { Name = "Liters", Abbreviation = "l" });

            context.ProductTypes.Add(new ProductsType { Name = "Meat" });
            context.ProductTypes.Add(new ProductsType { Name = "Seafood" });
            context.ProductTypes.Add(new ProductsType { Name = "Vegatables" });

            context.BlogsCategorys.Add(new BlogsCategory { Name = "Revie", Description = "Revies of food"});
            context.BlogsCategorys.Add(new BlogsCategory { Name = "News", Description = "Future new meals" });

            //
            context.Ingredients.Add(new Ingredients { Name = "Corn", Description = "Pizza base", PriceForItem = 4.4 });
            context.Ingredients.Add(new Ingredients { Name = "Chesse", Description = "Pizza added", PriceForItem = 10 });
            context.Ingredients.Add(new Ingredients { Name = "Tomato", Description = "Pizza added", PriceForItem = 1.9 });
            context.Ingredients.Add(new Ingredients { Name = "Pasta", Description = "Pasta italiana", PriceForItem = 16 });

            //
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });

            context.Blogs.Add(new Blogs { Title = "Pizza reviev", Text = "Jedna od prednosti LCHF-a je svakako veći izbor dresinga (preliva) za salate. " +
                "Verovatno su vam već dosadila 2 glavna dressinga za “tople” i hladne” salate: sok limuna i maslinovo ulje ILI jogurt, kari, maslinovo ulje i limun.",
                DateTime  = new System.DateTime(12,10,2017), Raiting = 3.6 });

            context.SaveChanges();
        }
    }
}