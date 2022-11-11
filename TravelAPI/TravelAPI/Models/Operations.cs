﻿using System;
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
