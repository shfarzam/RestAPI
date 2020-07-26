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
    public class PersonsController : ApiController
    {
        // GET: Persons
        
        public IEnumerable<Person> Get()
        {
            var Person = new Person();
            return Person.GetPerson();
        }

        // GET: Persons/5
        
        public List<Person> Get(string name)
        {
            var Person = new Person();
            return Person.GetPersonByColor(name);

        }

        // GET: Persons/5        
        public List<Person> Get(int id)
        {
            var Person = new Person();
            return Person.GetPersonById(id);

        }

         // POST: api/Persons
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Persons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Persons/5
        public void Delete(int id)
        {
        }
    }
}
