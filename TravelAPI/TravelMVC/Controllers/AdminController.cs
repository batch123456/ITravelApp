using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TravelMVC.Models;

namespace TravelMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Uri baseAddress = new Uri("https://localhost:44396/api");
        HttpClient client;
        public AdminController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult Index()
        {
            List<Admin> l = new List<Admin>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Admin").Result;
            if (response.IsSuccessStatusCode)
            {
                String Data = response.Content.ReadAsStringAsync().Result;
                l = JsonConvert.DeserializeObject<List<Admin>>(Data);
            }
            return View(l);
        }
        public ActionResult Edit(String email)
        {
            User l = new User();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/user/" + email).Result;
            if (response.IsSuccessStatusCode)
            {
                String Data = response.Content.ReadAsStringAsync().Result;
                l = JsonConvert.DeserializeObject<User>(Data);
            }
            return View(l);
        }
        [HttpPost]
        public ActionResult Edit(User model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent Content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(baseAddress + "/user/" + model.Email, Content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
