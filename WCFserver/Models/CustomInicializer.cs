﻿using System.Data.Entity;

namespace WCFserver
{
    class CustomInicializer<T> : DropCreateDatabaseAlways<GastroModel>
    {
        protected override void Seed(GastroModel context)
        {
            var unitsOFMeasurement = new UnitsOfMeasurement { Name = "Gram", Abbreviation = "g" };

            var catChees = new Category { Name = "Chees", Description = "Chees" };
            var catMeat = new Category { Name = "Meat", Description = "Meat" };
            var catVegatables = new Category { Name = "Vegatables", Description = "Vegatables" };
            var catMochne = new Category { Name = "Mochne", Description = "Mochne" };
            var catSauces = new Category { Name = "Sauces", Description = "Sauces" };

            var typePizza = new ProductsType { Name = "Pizza" };
            var typeSalat = new ProductsType { Name = "Salat" };

            ProductsType[] typeForPizzaSalat = { typePizza, typeSalat };
            ProductsType[] typeForPizza = { typePizza};
            ProductsType[] typeForSalat = { typeSalat };

            var ingCheder = new Ingredients
            {
                ProductTypes = typeForPizza,
                Name = "Cheder",
                Description = "tasty",
                PriceForItem = 67.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement
            };

            var ingChehel = new Ingredients
            {
                ProductTypes = typeForPizza,
                Name = "Chechel",
                Description = "tasty",
                PriceForItem = 32.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingAsadero = new Ingredients
            {
                ProductTypes = typeForPizza,
                Name = "Asadero",
                Description = "tasty",
                PriceForItem = 12.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingAsiago = new Ingredients
            {
                ProductTypes = typeForPizza,
                Name = "Asiago",
                Description = "tasty",
                PriceForItem = 19.78,
                Category = catChees,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingPaperoni = new Ingredients
            {
                ProductTypes = typeForPizzaSalat,
                Name = "Pepperoni",
                Description = "tasty",
                PriceForItem = 45.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingSalami = new Ingredients
            {
                ProductTypes = typeForPizzaSalat,
                Name = "Salami",
                Description = "tasty",
                PriceForItem = 65.18,
                Category = catMeat,
                UnitsOfMeasurements = unitsOFMeasurement

            };

            var ingKopchena = new Ingredients
            {
                ProductTypes = typeForPizzaSalat,
                Name = "Kopchena",
                Description = "tasty",
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
                Name = "PizzaFourChees",
                Description = "Some tasty pizza",
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

            var accOleg = new Account
            {
                FirstName = "Oleg",
                Surname = "Knyaz",
                Login = "Oleg_Knyaz",
                Password = "steppassword",
                Email = "oleg_knyaz@gmail.com",
                Address = "Naberegna 58",
                Carma = 12,
                PhoneNumber = "+18076253745",
            };

            var blogForDiablo = new Blogs
            {
                Account = accOleg,
                Title = "Revie pizza Diablo",
                Text = "London is a capital of Great Britain",
                DateTime = new System.DateTime(12, 10, 2017),
                BlogsCategory = catBlogsRevie,
                Raiting = 7.8,
                ReadyMeals = PizzaDiablo
            };
            context.Blogs.Add(blogForDiablo);

            var blogNewsSalat = new Blogs
            {
                Title = "In the near future we present new SALAT 'Ceaser'!!! Its a fantastic meals right from creame moutains  France!",
                Text = "London is a capital of Great Britain",
                DateTime = new System.DateTime(12, 10, 2017),
                BlogsCategory = catBlogsRevie,
                Raiting = 7.8,
                ReadyMeals = PizzaDiablo
            };
            context.Blogs.Add(blogNewsSalat);

            context.SaveChanges();
        }
    }
}