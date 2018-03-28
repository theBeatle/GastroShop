using System.Data.Entity;

namespace WCFserver
{
    class CustomInicializer<T> : DropCreateDatabaseAlways<GastroModel>
    {
        protected override void Seed(GastroModel context)
        {
            var unitsOFMeasurement = new UnitsOfMeasurement { Name = "Gram", Abbreviation = "g" };

            var catChees = new Category { Name = "Cheese", Description = "Cheese is a " +
                "dairy product derived from milk that is produced in a wide range of " +
                "flavors, textures, and forms by coagulation of the milk protein casein. " +
                "It comprises proteins and fat from milk, usually the milk of cows, " +
                "buffalo, goats, or sheep. During production, the milk is usually " +
                "acidified, and adding the enzyme rennet causes coagulation. The solids " +
                "are separated and pressed into final form.[1] Some cheeses have molds " +
                "on the rind, the outer layer, or throughout. Most cheeses melt at " +
                "cooking temperature." };
            var catMeat = new Category { Name = "Salami", Description = "Salami (singular " +
                "salame) is a type of cured sausage consisting of fermented and air-dried " +
                "meat, typically beef or pork. Historically, salami was popular among " +
                "southern and central European peasants because it stores at room " +
                "temperature for up to 40 days once cut, supplementing a potentially " +
                "meager or inconsistent supply of fresh meat. Countries and regions " +
                "across Europe make their own traditional varieties of salami." };

            ProductsType[] typeForPizzaSalat = { typePizza, typeSalat };
            ProductsType[] typeForPizza = { typePizza};
            ProductsType[] typeForSalat = { typeSalat };

            var ingCheder = new Ingredients
            {
                Name = "Cheddar",
                Description = "Cheddar cheese is a relatively hard, off-white " +
                "(or orange if spices such as annatto are added), sometimes sharp-tasting" +
                " (i.e., bitter[1]), natural cheese. Originating in the English village " +
                "of Cheddar in Somerset,[2] cheeses of this style are produced beyond the" +
                " region and in several countries around the world",
                PriceForItem = 67.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement
            };

            var ingChehel = new Ingredients
            {
                Name = "Sulguni",
                Description = "Sulguni (Georgian: სულგუნი, სულუგუნი sulguni, suluguni; " +
                "Mingrelian: სელეგინ selegin) is a brined Georgian cheese from the " +
                "Samegrelo region. It has a sour, moderately salty flavor, a dimpled " +
                "texture, and an elastic consistency; these attributes are the result of " +
                "the process used, as is the source of its moniker \"pickle cheese\". " +
                "Its color ranges from white to pale yellow. Sulguni is often deep-fried, " +
                "which masks its odor. It is often served in wedges.",
                PriceForItem = 32.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingAsadero = new Ingredients
            {
                ProductTypes = typeForPizza,
                Name = "Asadero",
                Description = "Asadero is an off-white, semi-firm Mexican cheese often " +
                "sold in a log shape for convenient and easy slicing. It is an excellent " +
                "cooking cheese: when it melts, it becomes quite creamy without giving " +
                "off any oil, even at higher temperatures. It has a light, fresh taste " +
                "with just a bit of tang to it.It is very creamy, and layered almost " +
                "like fresh Mozzarella. Made particularly in the Chihuahua area of " +
                "Northern Mexico.In some parts of Chihuahua, a plant is used to curdle " +
                "the milk instead of animal rennet.",
                PriceForItem = 12.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingAsiago = new Ingredients
            {
                ProductTypes = typeForPizza,
                Name = "Asiago",
                Description = "Asiago (/ɑːsiˈɑːɡoʊ/ or /ɑːˈsjɑːɡoʊ/; Italian: [aˈzjaːɡo])" +
                " is an Italian cow's milk cheese that can assume different textures," +
                " according to its aging, from smooth for the fresh Asiago (Asiago" +
                " Pressato) to a crumbly texture for the aged cheese (Asiago d'allevo)," +
                " the flavor of which is similar to Parmesan. The aged cheese is often" +
                " grated in salads, soups, pastas, and sauces while the fresh Asiago is" +
                " sliced to prepare panini or sandwiches; it can also be melted on a" +
                " variety of dishes and cantaloupe.",
                PriceForItem = 19.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingPaperoni = new Ingredients
            {
                Name = "Pepperoni",
                Description = "Pepperoni (also known as pepperoni sausage) is an " +
                "American variety of salami, made from cured pork and" +
                " beef mixed together and seasoned with paprika or other chili" +
                "pepper. Pepperoni is characteristically soft, slightly smoky, and " +
                "bright red in color. Thinly sliced pepperoni is a popular pizza " +
                "topping in American - style pizzerias[5] and is used as filling in " +
                "the West Virginia pepperoni roll.",
                PriceForItem = 45.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingSalami = new Ingredients
            {
                ProductTypes = typeForPizzaSalat,
                Name = "Salami",
                Description = "Salami (singular salame) is a type of cured sausage " +
                "consisting of fermented and air-dried meat, typically beef or pork. " +
                "Historically, salami was popular among southern and central European " +
                "peasants because it stores at room temperature for up to 40 days once " +
                "cut, supplementing a potentially meager or inconsistent supply of " +
                "fresh meat. Countries and regions across Europe make their own " +
                "traditional varieties of salami.",
                PriceForItem = 65.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingKopchena = new Ingredients
            {
                Name = "Lardo",
                Description = "Lardo is a type of salumi made by curing strips of" +
                " fatback with rosemary and other herbs and spices.",
                PriceForItem = 45.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingTomato = new Ingredients
            {
                ProductTypes = typeForPizzaSalat,
                Name = "Tomato",
                Description = "tasty",
                PriceForItem = 5.18,
                Category = catVegatables,
                UnitsOfMeasurements = unitsOFMeasurement
            };

            var ingSalad = new Ingredients
            {
                ProductTypes = typeForPizzaSalat,
                Name = "Salad",
                Description = "tasty",
                PriceForItem = 3.18,
                Category = catVegatables,
                UnitsOfMeasurements = unitsOFMeasurement
            };

            var ingGrenka = new Ingredients
            {
                ProductTypes = typeForSalat,
                Name = "Grenka",
                Description = "tasty",
                PriceForItem = 1.1,
                Category = catMochne,
                UnitsOfMeasurements = unitsOFMeasurement
            };

            var ingSauces = new Ingredients
            {
                ProductTypes = typeForSalat,
                Name = "Sauces creamy",
                Description = "tasty",
                PriceForItem = 2,
                Category = catSauces,
                UnitsOfMeasurements = unitsOFMeasurement
            };

            Ingredients[] ingsCeesar = { ingSalad, ingTomato, ingGrenka, ingSalami, ingSauces };
            var SalatCeesar = new ReadyMeals
            {
                MealPicUrl = "https://avatars.mds.yandex.net/get-pdb/34158/380697426-salat-tsezar-caesar-salad-1464179972.11/s800",
                Name = "Ceesar",
                Description = "Very good salatik",
                Raiting = 9.6,
                Size = "200g",
                Ingredients = ingsCeesar
            };
            context.ReadyMeals.Add(SalatCeesar);

            Ingredients[] ingsFourChees = { ingCheder, ingPaperoni, ingChehel };
            var PizzaFourChees = new ReadyMeals
            {
                MealPicUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwaKXTIRx1VRogry4_aM6RLR9-0pkO0VzfOtAoQs6QXX79jHVu",
                Name = "Quattro Formaggio",
                Description = "Virtually any combinations of four cheeses can be" +
                " sued in this pizza, but this one uses Parmesan, Mozzarella," +
                " Ricotta, and Gorgonzola",
                Raiting = 5.6,
                Size = "XXL",
                Ingredients = ingsFourChees
            };
            context.ReadyMeals.Add(PizzaFourChees);

            Ingredients[] ingsDiablo = { ingKopchena, ingAsiago, ingPaperoni };
            var PizzaDiablo = new ReadyMeals
            {
                MealPicUrl = "http://images.pizza33.ua/products/product/yQfkJqZweoLn9omo68oz5BnaGzaIE0UJ.jpg",
                Name = "PizzaDiablo",
                Description = "Very hot tasty pizza",
                Raiting = 7.6,
                Size = "XXL",
                Ingredients = ingsDiablo
            };
            context.ReadyMeals.Add(PizzaDiablo);

            Ingredients[] ingsNapoletana = { ingAsiago, ingAsadero };

            var PizzaNapoletana = new ReadyMeals
            {
                MealPicUrl = "http://express-pizza.vn.ua/uploads/1/4/145b8f8eb6397682902b47ea3e5eaa2e.png",
                Name = "PizzaNapoletana",
                Description = "Light tasty pizza",
                Raiting = 3.6,
                Size = "XXL",
                Ingredients = ingsNapoletana
            };
            context.ReadyMeals.Add(PizzaNapoletana);

            var catBlogsRevie = new BlogsCategory { Name = "Revie", Description = "Revies of food" };
            var catBlogsNews = new BlogsCategory { Name = "News", Description = "Future new meals" };

           //var accOleg = new Account
           //{
           //    FirstName = "Oleg",
           //    Surname = "Knyaz",
           //    Login = "Oleg_Knyaz",
           //    Password = "blablabla",
           //    Email = "oleg_knyaz@gmail.com",
           //    Address = "Naberegna 58",
           //    Carma = 12,
           //    PhoneNumber = "+18076253745",
           //};
           //
           //context.Blogs.Add(new Blogs
           //{
           //    Account = accOleg,
           //    Title = "Revie pizza Diablo",
           //    Text = "London is a capital of Great Britain",
           //    //DateTime = new System.DateTime(12, 10, 2017),
           //    BlogsCategory = catBlogsRevie,
           //    Raiting = 7.8,
           //    ReadyMeals = PizzaDiablo
           //    });
           //

            context.SaveChanges();
        }
    }
}