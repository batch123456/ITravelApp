using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
    public class UserController : ApiController
    {
        Operations op = new Operations();


        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            return op.GetUser();
        }

        // GET api/<controller>/5
        public User Get(string name)
        {
            return op.GetUser(name);
        }

        // POST api/<controller>
        public void Post([FromBody] User value)
        {
            op.PostUser(value);
        }

        // PUT api/<controller>/5
        public void Put(string name, [FromBody] User value)
        {
            op.PutUser(name, value);
        }

        // DELETE api/<controller>/5
        public void Delete(string name)
        {
            op.DeleteUser(name);
        }
    }
}