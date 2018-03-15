namespace WCFserver
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class gastroModel : DbContext
    {
        // Your context has been configured to use a 'gastroModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WCFserver.gastroModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'gastroModel' 
        // connection string in the application configuration file.
        public gastroModel()
            : base("name=gastroModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.


    }


    public class Account
    {
        
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Carma { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        //public ICollection<Blogs> Blog { get; set; }
    }

    public class BlogsCategory
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public ICollection<Blogs> Blog { get; set; }
    }

    public class UnitsOfMeasurement
    {
  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        //public ICollection<Ingredients> Ingredients{ get; set; }

    }

    public class ProductsType
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }



}