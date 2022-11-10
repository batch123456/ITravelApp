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
            admin.Add(new Admin() { AdminEmail = "admin@gmail.com", AdminPassword = "admin" });
            context.Admins.AddRange(admin);
            List<User> users = new List<User>();
            users.Add(new User() { Email = "sweety@gmail.com", Password = "sweety" });
            users.Add(new User() { Email = "nani@gmail.com", Password = "nani" });
            context.Users.AddRange(users);

            List<Register> registers = new List<Register>();
            registers.Add(new Register() { Name = "Sam", Email = "register@gmail.com", Password = "register", ConfirmPassword = "register" });
            context.Registers.AddRange(registers);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}