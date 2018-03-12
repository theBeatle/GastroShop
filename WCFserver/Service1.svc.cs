using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFserver
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Category[] CategoriesToReturn()
        {
            Category[] categoryToReturn = null;
            using (var ctx = new GastroModel())
            {

                categoryToReturn = ctx.Categories.ToArray();
            }
            return categoryToReturn;
        }

        public Account ValidateUser(string login, string password)
        {
            Account userToReturn = null;
            using (var ctx = new GastroModel())
            {
                userToReturn = ctx.Accounts.FirstOrDefault(i => i.Login == login && i.Password == password);
            }
            return userToReturn;
        }

        
    }
}
