using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
    public class RegisterController : ApiController
    {


        Operations op = new Operations();
        // GET api/<controller>
        public IEnumerable<Register> Get()
        {
            return op.GetRegister();
        }

        // GET api/<controller>/5
        public Register Get(string mail)
        {
            return op.GetRegister(mail);
        }

        // POST api/<controller>
        public void Post([FromBody] Register value)
        {
            op.PostRegister(value);
        }

        // PUT api/<controller>/5
        public void Put(string mail, [FromBody] Register value)
        {
            op.PutRegister(mail, value);
        }

        // DELETE api/<controller>/5
        public void Delete(string mail)
        {
            op.DeleteRegister(mail);
        }
    }
}