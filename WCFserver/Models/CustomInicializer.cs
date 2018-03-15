using System.Data.Entity;

namespace WCFserver
{
    internal class CustomInicializer<T> : DropCreateDatabaseAlways<GastroModel>
    {
        protected override void Seed(GastroModel context)
        {
            context.Accounts.Add(new Account { Login = "test", Password = "test", FirstName = "Andriy", Surname = "Valentynovych",
            Email="test@gmail.com", Address="Naberegna 58", PhoneNumber="+12345678952300"});
            context.Accounts.Add(new Account { Login = "test1", Password = "test1", FirstName = "Sergiy", Surname = "Igorov",
            Email="test@gmail.com", Address="Street 58", PhoneNumber="+12345952300"});
             context.Accounts.Add(new Account { Login = "test2", Password = "test2", FirstName = "Oleg", Surname = "Maksymov",
            Email="test@gmail.com", Address="Street 5", PhoneNumber="+12345950"});
             context.Accounts.Add(new Account { Login = "test3", Password = "test3", FirstName = "Artem", Surname = "Ignativ",
            Email="test@gmail.com", Address="Street 8", PhoneNumber="+123459500"});

            //
            context.Categories.Add(new Category { Name = "Pizza", Description = "Mochne" });
            context.Categories.Add(new Category { Name = "Salat", Description = "Sochne" });
            context.Categories.Add(new Category { Name = "Drink", Description = "Pytne" });

            //
            context.UnitsOfMeasurements.Add(new UnitsOfMeasurement { Name = "Gram", Abbreviation = "g" });
            context.UnitsOfMeasurements.Add(new UnitsOfMeasurement { Name = "Liters", Abbreviation = "l" });

            //
            context.ProductTypes.Add(new ProductsType { Name = "Meat" });
            context.ProductTypes.Add(new ProductsType { Name = "Cheese" });
            context.ProductTypes.Add(new ProductsType { Name = "Vegatables" });
            context.ProductTypes.Add(new ProductsType { Name = "Sausage" });
            context.ProductTypes.Add(new ProductsType { Name = "Saucase" });

            //
            context.Ingredients.Add(new Ingredients { Name = "Cheder", Description = "Pizza base", PriceForItem = 4.4 });
            context.Ingredients.Add(new Ingredients { Name = "Parmesane", Description = "Pizza added", PriceForItem = 10 });
            context.Ingredients.Add(new Ingredients { Name = "Goland", Description = "Pizza added", PriceForItem = 1.9 });

            context.Ingredients.Add(new Ingredients { Name = "Varenka", Description = "Pizza or salat added", PriceForItem = 2 });
            context.Ingredients.Add(new Ingredients { Name = "Salami", Description = "Pizza added", PriceForItem = 4 });
            context.Ingredients.Add(new Ingredients { Name = "Moscowska", Description = "Pizza added", PriceForItem = 8 });

            context.Ingredients.Add(new Ingredients { Name = "Tomato", Description = "Pizza or salat added", PriceForItem = 0.6 });
            context.Ingredients.Add(new Ingredients { Name = "Selera", Description = "Pizza or salat added", PriceForItem = 0.3 });
            context.Ingredients.Add(new Ingredients { Name = "Cabbage", Description = "Pizza or salat added", PriceForItem = 0.9 });
            context.Ingredients.Add(new Ingredients { Name = "Salad", Description = "Pizza or salat added", PriceForItem = 0.2 });

            context.Ingredients.Add(new Ingredients { Name = "Bekon", Description = "Salat added", PriceForItem = 10 });
            context.Ingredients.Add(new Ingredients { Name = "Beef", Description = "Salat added", PriceForItem = 19 });
            context.Ingredients.Add(new Ingredients { Name = "Chiken", Description = "Salat added", PriceForItem =7 });

            context.Ingredients.Add(new Ingredients { Name = "Sprite", Description = "Drinkin", PriceForItem = 2 });
            context.Ingredients.Add(new Ingredients { Name = "Pepsi", Description = "Drinkin", PriceForItem = 3 });


            //
            context.BlogsCategorys.Add(new BlogsCategory { Name = "Revie", Description = "Revies of food"});
            context.BlogsCategorys.Add(new BlogsCategory { Name = "News", Description = "Future new meals" });

            //
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Four chesse", Description = "Beeter Italian Pizza from Milano", Raiting = 4.6, Size = "XXL" });

            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });
            context.ReadyMeals.Add(new ReadyMeals { Name = "Cezar", Description = "Jedna od prednosti LCHF-a je svakako veći izbor", Raiting = 4.6, Size = "250g" });

            //
            context.Blogs.Add(new Blogs { Title = "Pizza reviev", Text = "Jedna od prednosti LCHF-a je svakako veći izbor dresinga (preliva) za salate. " +
                "Verovatno su vam već dosadila 2 glavna dressinga za “tople” i hladne” salate: sok limuna i maslinovo ulje ILI jogurt, kari, maslinovo ulje i limun.",
                DateTime  = new System.DateTime(12,10,2017), Raiting = 3.6 });

            context.Blogs.Add(new Blogs { Title = "Pizza ", Text = "Jedna od prednosti LCHF-a je svakako veći izbor dresinga (preliva) za salate. " +
                "Verovatno su vam već dosadila 2 glavna dressinga za “tople” i hladne” salate: sok limuna i maslinovo ulje ILI jogurt, kari, maslinovo ulje i limun.",
                DateTime  = new System.DateTime(11,11,2017), Raiting = 3.8 });

            //
            context.SaveChanges();
        }
    }
}