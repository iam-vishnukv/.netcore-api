using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Core.Entity;
using TestProject.Core.Interfaces;
using TestApplication.Filters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ValidateModel]
    public class UserController : Controller
    {

        private readonly IUserRepository userRepository ;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return this.userRepository.GetUsersListByFilter(new User());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Route("post")]
        [ValidateModel]
        public bool Post([FromBody] User  i)
        {
            if (ModelState.IsValid)
            {
                //return this.userRepository.AddUser(user);
                return true;
            }

            return false;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] User user)
        {
            return this.userRepository.UpdateUser(user);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
