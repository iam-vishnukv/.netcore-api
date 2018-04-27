using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Core.Entity;
using TestProject.Core.Interfaces;
using TestApplication.Filters;
using TestApplication.Response;

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
        public ResponseMessage Get()
        { 
            var users =   this.userRepository.GetUsersListByFilter(new User());

            return new ResponseMessage(ResponseType.Sucess,users);
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
        public ResponseMessage Post([FromBody] User newUser)
        {
            
                if (this.userRepository.AddUser(newUser))
                {
                return new ResponseMessage(ResponseType.Sucess, newUser);
                }
              return new ResponseMessage(ResponseType.Failed, newUser);

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
