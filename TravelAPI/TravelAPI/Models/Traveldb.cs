using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelAPI.Models
{

    public class Traveldb : DropCreateDatabaseIfModelChanges<TravelContext>
    {
        protected override void Seed(TravelContext context)
        {
            List<Admin> admin = new List<Admin>();
            admin.Add(new Admin() { AdminId=1,AdminEmail = "admin@gmail.com", AdminPassword = "admin" });
            context.Admins.AddRange(admin);
            
            
           List<User> users = new List<User>();
            
            users.Add(new User() { UserId = 1, FirstName = "Pravalli", LastName = "adieni", Email = "sweety@gmail.com", Password = "sweety", ConfirmPassword = "sweety" });
            users.Add(new User() { UserId = 2, FirstName = "Navi", LastName = "karakam", Email = "nani@gmail.com", Password = "nani", ConfirmPassword = "nani" });
          
            context.Users.AddRange(users);
            context.SaveChanges();
            base.Seed(context);

        }
    }
}