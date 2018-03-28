using System;
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
        private GastroModel _ctx = new GastroModel();

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

                Name = "Chees",
                Description = "Something"
            };
            var ingredient2 = new IngredientDTO
            {

                Name = "Kolbasa",
                Description = "Smachna kolbasa"
            };
            var ingredients = new List<IngredientDTO> { ingredient, ingredient2 }.ToArray();
            var list = new List<CategoryDTO>()
            {
               new CategoryDTO()
               {
                   ID = 1,
                   Name = "Pizza",
                   Description = "Muchnoe",
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

        public EatConstruct[] GetIngredientsForConstructor()
        {
            EatConstruct[] ingredients = null;
            ingredients = _ctx.Ingredients
                .Include("ProductsType")
                .Include("Category")
                .Include("UnitsOfMeasurement")
                    .Select(i => (new EatConstruct
                    {
                        //TypeOfMeals = i.ProductsType.Name,
                        CategoryIngredients = i.Category.Name,
                        Ingredient = i.Name,
                        MeasurementUnit = i.UnitsOfMeasurements.Name,
                        PriceForItem = i.PriceForItem
                    })).ToArray();

            return ingredients;
    }

        /// <summary>
        /// Method for return meals for face page
        /// </summary>
        /// <param name="pageNum">Page number for product plate</param>
        /// <param name="elementsForPage">Count of ready meal on page</param>
        /// <returns>Array of readdy meals for current page</returns>
        public ReadyMealDTO[] GetMeals(int pageNum, int elementsForPage)
        {
            //GastroModel _ctx = new GastroModel();
            var meals = new List<ReadyMealDTO>();
            int mealsCount = _ctx.ReadyMeals.Count();
            var tmpResult = _ctx.ReadyMeals.Include("Ingredients")
                .Select(m => new //ReadyMealDTO
                {
                    m.ID,
                    m.Name,
                    m.Description,
                    m.Raiting,
                    m.Size,
                    m.MealPicUrl,
                    Blogs = m.Blogs.Select(b => b.ID),
                    Price = 1.2 * m.Ingredients.Select(i => i.PriceForItem).Sum(),
                    Ingredients = m.Ingredients.Select(t => new IngredientDTO()
                    {
                        Name = t.Name,
                        Description = t.Description
                    }) //.ToArray()
                })
               .ToList()
               .Select(obj => new ReadyMealDTO
               {
                   ID = obj.ID,
                   Name = obj.Name,
                   Description = obj.Description,
                   Raiting = obj.Raiting,
                   Size = obj.Size,
                   MealPicUrl = obj.MealPicUrl,
                   Price = Math.Round(obj.Price, 2),
                   Ingredients = obj.Ingredients.ToArray(),
                   BlogsIndexes = obj.Blogs.ToArray()
               });

            if (mealsCount <= elementsForPage)
            {
                meals = tmpResult.ToList();
            }
            else
            {
                meals = tmpResult.Skip(pageNum * elementsForPage).Take(elementsForPage).ToList();
            }

            return meals.ToArray();
            //return Utils.Utilities.RandomMealsGenerator(elementsForPage);
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


        //remake with LINQ and private DB context
        public int NumberOfReadyMeals()
        {
            return _ctx.ReadyMeals.Count();
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

        //
        public EatConstruct[] TestEatConstGet()
        {
            var eat1 = new EatConstruct
            {
                TypeOfMeals = "Pizza",
                MeasurementUnit = "2",
                CategoryIngredients = "meat",
                Ingredient = "Varenka",
                PriceForItem = 10.87
            };

            var eat2 = new EatConstruct
            {
                TypeOfMeals = "Salat",
                MeasurementUnit = "3",
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
