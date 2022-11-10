using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
    public class ForgotPswdController : ApiController
    {
        Operations op = new Operations();
        // GET api/<controller>
        public IEnumerable<ForgotPswd> Get()
        {
            return op.GetForgotPswd();
        }

        // GET api/<controller>/5
        public ForgotPswd Get(string mail)
        {
            return op.GetForgotPswd(mail);
        }

        // POST api/<controller>
        public void Post([FromBody] ForgotPswd value)
        {
            op.PostForgotPswd(value);
        }

        // PUT api/<controller>/5
        public void Put(string mail, [FromBody] ForgotPswd value)
        {
            op.PutForgotPswd(mail, value);
        }

        // DELETE api/<controller>/5
        public void Delete(string mail)
        {
            op.DeleteForgotPswd(mail);

        }
    }
}