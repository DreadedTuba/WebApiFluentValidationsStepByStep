using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AddressesController : ApiController
    {
        // GET: api/Addresses
        public IEnumerable<Address> Get()
        {
            return new Address[] {
                new Address()
                {
                    Street = "123 Easy St",
                    City = "Nowhere",
                    State = "OfMind",
                    PostalCode = "12345"
                },
                new Address()
                {
                    Street = "666 Elm St",
                    City = "Amittyville",
                    State = "Horror",
                    PostalCode = "89989"
                }
            };
        }

        // GET: api/Addresses/5
        public Address Get(int id)
        {
            return new Address()
            {
                Street = "666 Elm St",
                City = "Amittyville",
                State = "Horror",
                PostalCode = "89989"
            };
        }

        // POST: api/Addresses
        public void Post([FromBody] Address value)
        {
        }

        // PUT: api/Addresses/5
        public void Put(int id, [FromBody] Address value)
        {
        }

        // DELETE: api/Addresses/5
        public void Delete(int id)
        {
        }
    }
}
