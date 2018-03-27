namespace WCFserver
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class GastroModel : DbContext
    {
        // Your context has been configured to use a 'gastroModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WCFserver.gastroModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'gastroModel' 
        // connection string in the application configuration file.
        public GastroModel()
            : base("name=gastroModel")
        {
            Database.SetInitializer<GastroModel>(new CustomInicializer<GastroModel>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ProductsType> ProductTypes { get; set; }
        public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }
        public virtual DbSet<BlogsCategory> BlogsCategorys { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<ReadyMeals> ReadyMeals { get; set; }
        public virtual DbSet<Blogs> Blogs { get; set; }
    }
}