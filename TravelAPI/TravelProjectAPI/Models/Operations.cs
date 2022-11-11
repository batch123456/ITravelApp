using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProjectAPI.Models
{
    public class Operations
    {
        TravelContext context = new TravelContext();

        public List<Admin> GetAdmin()
        {
            return context.Admins.ToList();
        }
        public Admin GetAdmin(int id)
        {
            return context.Admins.ToList().Find(x => x.AdminId == id);
        }
        public void PostAdmin(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void PutAdmin(int id, Admin admin)
        {
            var found = context.Admins.ToList().Find(x => x.AdminId == id);
            context.Admins.Remove(found);
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void DeleteAdmin(int id)
        {
            var found = context.Admins.ToList().Find(x => x.AdminId == id);
            context.Admins.Remove(found);
            context.SaveChanges();
        }






        public List<User> GetUser()
        {
            return context.Users.ToList();
        }
        public User GetUser(int id)
        {
            return context.Users.ToList().Find(x => x.UserId == id);
        }
        public void PostUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void PutUser(int id, User user)
        {
            var found = context.Users.ToList().Find(x => x.UserId == id);
            context.Users.Remove(found);
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            var found = context.Users.ToList().Find(x => x.UserId == id);
            context.Users.Remove(found);
            context.SaveChanges();
        }


        public List<TravelDetails> GetDetails()
        {
            return context.TravelDetails.ToList();
        }
        public TravelDetails GetDetails(int id)
        {
            return context.TravelDetails.ToList().Find(x => x.TravelId == id);
        }
        public void PostDetails(TravelDetails details)
        {
            context.TravelDetails.Add(details);
            context.SaveChanges();
        }
        public void PutDetails(int id, TravelDetails details)
        {
            var found = context.TravelDetails.ToList().Find(x => x.TravelId == id);
            context.TravelDetails.Remove(found);
            context.TravelDetails.Add(details);
            context.SaveChanges();
        }
        public void DeleteDetails(int id)
        {
            var found = context.TravelDetails.ToList().Find(x => x.TravelId == id);
            context.TravelDetails.Remove(found);
            context.SaveChanges();
        }


    }
}