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

            context.SaveChanges();
        }
    }
}