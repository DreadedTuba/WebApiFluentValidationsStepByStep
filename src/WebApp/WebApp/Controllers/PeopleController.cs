using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PeopleController : ApiController
    {
        // GET: api/People
        public IEnumerable<Person> Get()
        {
            return new Person[] {
                new Person() {
                    Name = "Thing 1",
                    DateOfBirth = new DateTime(1970,1,1),
                    Email = "thing1@seuss.com"
                    },
                new Person() {
                    Name = "Thing 2",
                    DateOfBirth = new DateTime(1970,1,1),
                    Email = "thing2@seuss.com"
                    }
            };
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return new Person()
            {
                Name = "Thing 1",
                DateOfBirth = new DateTime(1970, 1, 1),
                Email = "thing1@seuss.com"
            };

        }

        // POST: api/People
        public void Post([FromBody] Person value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody] Person value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
