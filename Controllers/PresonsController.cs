using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPI.Models;
using Newtonsoft.Json;

namespace RestAPI.Controllers
{
    public class PresonsController : ApiController
    {
        // GET: api/Read
        public IEnumerable<Person> Get()
        {
            var Person = new Person();
            return Person.GetPerson();
        }

        

        // GET: api/Read/5
        
        // POST: api/Read
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Read/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Read/5
        public void Delete(int id)
        {
        }
    }
}
