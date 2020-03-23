using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Userservice.Model;

namespace Userservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> users = new List<User>
            {
                   new User {
                               UserId= 2,
                               FirstName="Narendo",
                               LastName ="Jogi",
                               Age=20
                            },
                    new User
                            {
                                UserId= 3,
                               FirstName="Raju",
                               LastName ="Joshi",
                               Age=40
                            },
            };
            //List<User> users = new List<User>();
            //User user = new User();
            //user.UserId = 1;
            //user.FirstName = "John";
            //user.LastName = "Doe";
            //user.Age = 50;
            //users.Add(user);
            //return new string[] { "value1", "value2" };
            return users;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
