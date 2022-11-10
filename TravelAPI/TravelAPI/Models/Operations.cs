using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAPI.Models
{
    public class Operations
    {
        TravelContext context = new TravelContext();

        public List<Admin> GetAdmin()
        {
            return context.Admins.ToList();
        }
        public Admin GetAdmin(string id)
        {
            return context.Admins.ToList().Find(x => x.AdminEmail == id);
        }
        public void PostAdmin(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void PutAdmin(string id, Admin admin)
        {
            var found = context.Admins.ToList().Find(x => x.AdminEmail == id);
            context.Admins.Remove(found);
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void DeleteAdmin(string id)
        {
            var found = context.Admins.ToList().Find(x => x.AdminEmail == id);
            context.Admins.Remove(found);
            context.SaveChanges();
        }






        public List<User> GetUser()
        {
            return context.Users.ToList();
        }
        public User GetUser(string name)
        {
            return context.Users.ToList().Find(x => x.Email == name);
        }
        public void PostUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void PutUser(string name, User user)
        {
            var found = context.Users.ToList().Find(x => x.Email == name);
            context.Users.Remove(found);
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void DeleteUser(string name)
        {
            var found = context.Users.ToList().Find(x => x.Email == name);
            context.Users.Remove(found);
            context.SaveChanges();
        }
        public List<Register> GetRegister()
        {
            return context.Registers.ToList();
        }
        public Register GetRegister(string mail)
        {
            return context.Registers.ToList().Find(x => x.Email == mail);
        }
        public void PostRegister(Register register)
        {
            context.Registers.Add(register);
            context.SaveChanges();
        }
        public void PutRegister(string mail, Register register)
        {
            var found = context.Registers.ToList().Find(x => x.Email == mail);
            context.Registers.Remove(found);
            context.Registers.Add(register);
            context.SaveChanges();
        }
        public void DeleteRegister(string mail)
        {
            var found = context.Registers.ToList().Find(x => x.Email == mail);
            context.Registers.Remove(found);
            context.SaveChanges();
        }

        public List<ForgotPswd> GetForgotPswd()
        {
            return context.Pswds.ToList();
        }
        public ForgotPswd GetForgotPswd(string mail)
        {
            return context.Pswds.ToList().Find(x => x.Email == mail);
        }
        public void PostForgotPswd(ForgotPswd pswd)
        {
            context.Pswds.Add(pswd);
            context.SaveChanges();
        }
        public void PutForgotPswd(string mail, ForgotPswd pswd)
        {
            var found = context.Pswds.ToList().Find(x => x.Email == mail);
            context.Pswds.Remove(found);
            context.Pswds.Add(pswd);
            context.SaveChanges();
        }
        public void DeleteForgotPswd(string mail)
        {
            var found = context.Pswds.ToList().Find(x => x.Email == mail);
            context.Pswds.Remove(found);
            context.SaveChanges();
        }/*
        public List<Vaccination> GetVaccination()
        {
            return context.Vaccinations.ToList();
        }
        public Vaccination GetVaccination(int id)
        {
            return context.Vaccinations.ToList().Find(x => x.VaccineId == id);
        }
        public void PostVaccination(Vaccination vaccination)
        {
            context.Vaccinations.Add(vaccination);
            context.SaveChanges();
        }
        public void PutVaccination(int id , Vaccination vaccination)
        {
            var found = context.Vaccinations.ToList().Find(x => x.VaccineId == id);
            context.Vaccinations.Remove(found);
            context.Vaccinations.Add(vaccination);
            context.SaveChanges();
        }
        public void DeleteVaccination(int id)
        {
            var found = context.Vaccinations.ToList().Find(x => x.VaccineId == id);
            context.Vaccinations.Remove(found);
            context.SaveChanges();
        }
        public List<VaccinationStock> GetVaccinationStocks()
        {
            return context.VaccinationStocks.ToList();
        }
        public VaccinationStock GetVaccinationStocks(int id)
        {
            return context.VaccinationStocks.ToList().Find(x => x.StockId == id);
        }
        public void PostVaccinationStocks(VaccinationStock stock)
        {
            context.VaccinationStocks.Add(stock);
            context.SaveChanges();
        }
        public void PutVaccinationStocks(int id , VaccinationStock stock)
        {
          var found = context.VaccinationStocks.ToList().Find(x => x.StockId == id);
            context.VaccinationStocks.Remove(found);
            context.VaccinationStocks.Add(stock);
            context.SaveChanges();
        }
        public void DeleteVaccinationStocks(int id)
        {
          var found = context.VaccinationStocks.ToList().Find(x => x.StockId == id);
            context.VaccinationStocks.Remove(found);
            context.SaveChanges();
        }*/
    }
}