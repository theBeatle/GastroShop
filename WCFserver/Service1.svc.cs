﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using WCFserver.DTO;

namespace WCFserver
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public BlogsCategory[] BlogsCategoriesToReturn()
        {
            BlogsCategory[] categoryToReturn = null;
            using (var ctx = new GastroModel())
            {

                categoryToReturn = ctx.BlogsCategorys.ToArray();
            }
            return categoryToReturn;
        }

        public CategoryDTO[] CategoriesToReturn()
        {

            var ingredient = new IngredientDTO
            {
                ID = 0,
                Name = "Chees",
                Description = "Something"
            };
            var ingredient2 = new IngredientDTO
            {
                ID = 0,
                Name = "Kolbasa",
                Description = "Smachna kolbasa"
            };
            var ingredients = new List<IngredientDTO> { ingredient, ingredient2 }.ToArray();
            var list = new List<CategoryDTO>()
            {
               new CategoryDTO(){ ID = 1, Name = "Pizza", Description = "Muchnoe",
               Ingredients = ingredients
               }
            };


            //using (var ctx = new GastroModel())
            //{
            //
            //    categoryToReturn = ctx.Categories.ToArray();
            //}
            return list.ToArray();
        }

        //fix error
        public EditAccount GetEditAcc(string login, string pass)
        {
            EditAccount acc = null;
            using (var ctx = new GastroModel())
            {
                acc = ctx.Accounts.Where(i => i.Login == login && i.Password == pass)
                    .Select(s => (new EditAccount
                    {
                        FirstName = s.FirstName,
                        SurName = s.Surname,
                        Email = s.Email,
                        Address = s.Address,
                        PhoneNumber = s.PhoneNumber
                    })).SingleOrDefault();
            }
            return acc;
        }

        static RandomMeals[] GetRandMeals(/*int pageNum,*/ int elemetsForPage)
        {
            RandomMeals[] getArr = new RandomMeals[elemetsForPage];
            int[] id = { 0, 1, 2, 3, 4 };
            string[] name = { "Four cheese", "Cessar", "Napoletana", "Grecheskii", "New-York" };
            string[] description = { "Descrition 1", "Descrition 2", "Descrition 3", "Descrition 4", "Descrition 5" };
            double[] raiting = { 1.1, 4.2, 10.5, 11.1, 7.2 };
            string[] size = { "XXL", "XL", "L", "M", "S" };
            Random rand = new Random();
            //int randNum = rand.Next(0, 5);
            for (var i = 0; i < elemetsForPage; i++)
            {
                getArr[i] = new RandomMeals { ID = id[rand.Next(0, 5)], Name = name[rand.Next(0, 5)], Description = description[rand.Next(0, 5)], Raiting = raiting[rand.Next(0, 5)], Size = size[rand.Next(0, 5)] };
            }
            return getArr;
        }

        public Ingredients[] IngredientsToReturn()
        {
            Ingredients[] ingredientsToReturn = null;
            using (var ctx = new GastroModel())
            {

                ingredientsToReturn = ctx.Ingredients.ToArray();
            }
            return ingredientsToReturn;
        }

        public int NumberOfReadyMeals()
        {
            int numb = 0;
            ReadyMeals[] readyMeals = null;
            using (var ctx = new GastroModel())
            {
                readyMeals = ctx.ReadyMeals.ToArray();
                numb = readyMeals.Length;
            }
            return numb;
        }

        public ProductsType[] ProductsTypeToReturn()
        {
            ProductsType[] productsTypeToReturn = null;
            using (var ctx = new GastroModel())
            {

                productsTypeToReturn = ctx.ProductTypes.ToArray();
            }
            return productsTypeToReturn;
        }

        public ReadyMeals[] ReadyMealsToReturn()
        {
            ReadyMeals[] readyMealsToReturn = null;
            using (var ctx = new GastroModel())
            {

                readyMealsToReturn = ctx.ReadyMeals.ToArray();
            }
            return readyMealsToReturn;
        }

        public EatConstruct[] TestEatConstGet()
        {
            ////EatConstruct[] eatConst = null;
            ////using (var ctx = new GastroModel())
            ////{
            //    eatConst = ctx.Ingredients.Include("ProductsType").Include("Category").Include("UnitsOfMeasurement")
            //        .Select(i => (new EatConstruct
            //        {
            //            TypeOfMeals = i.Category.Name,
            //            CategoryIngredients = i.ProductsType.Name,
            //            Ingredient = i.Name,
            //            Amount = i.Name,
            //            PriceForItem = i.PriceForItem
            //        })).ToArray();
            //}
            var eat1 = new EatConstruct
            {
                TypeOfMeals = "Pizza",
                Amount = "2",
                CategoryIngredients = "meat",
                Ingredient = "Varenka",
                PriceForItem = 10.87
            };

            var eat2 = new EatConstruct
            {
                TypeOfMeals = "Salat",
                Amount = "3",
                CategoryIngredients = "vegetables",
                Ingredient = "potato",
                PriceForItem = 34.67
            };

            return new List<EatConstruct> { eat1, eat2 }.ToArray();

        }

        public ClientBlog[] TestUserBlog()
        {
            ClientBlog[] blogs = null;
            using (var ctx = new GastroModel())
            {
                blogs = ctx.Blogs.Include("Accounts").Include("BlogsCategory").Include("ReadyMeals")
                    .Select(i => (new ClientBlog
                    {
                        AuthorName = i.Account.FirstName,
                        AuthorSurname = i.Account.Surname,
                        NameCategory = i.BlogsCategory.Name,
                        Raiting = i.Raiting,
                        Title = i.Title,
                        Text = i.Text,
                        TimeCreate = i.DateTime,
                        NamedDishes = i.ReadyMeals.Name
                    })).ToArray();

            }
            return blogs;
        }

        public UnitsOfMeasurement[] UnitsOfMeasurToReturn()
        {
            UnitsOfMeasurement[] unitsOfMeasurToReturn = null;
            using (var ctx = new GastroModel())
            {

                unitsOfMeasurToReturn = ctx.UnitsOfMeasurements.ToArray();
            }
            return unitsOfMeasurToReturn;
        }

        public string ValidateUser(string login, string password)
        {
            //Account userToReturn = null;
            //using (var ctx = new GastroModel())
            //{
            //    userToReturn = ctx.Accounts.FirstOrDefault(i => i.Login == login && i.Password == password);
            //}
            //return new Account();
            return new JavaScriptSerializer().Serialize($"Test {login} {password}");
            //return userToReturn;
        }

        Blogs[] IService1.BlogsToReturn()
        {
            Blogs[] blogsToReturn = null;
            using (var ctx = new GastroModel())
            {

                blogsToReturn = ctx.Blogs.ToArray();
            }
            return blogsToReturn;
        }
    }
}
