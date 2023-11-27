using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewUserController : ControllerBase
    {

        private static List<User> users = new List<User>()
        {
            new User()
            {
                Id= 1,
                FirstName = "FirstOne",
                LastName = "LastOne",
                Email = "one@email.com",
                PhoneNumber = "+31 611111111",
                Password = "password"
            },
            new User()
            {
                Id= 2,
                FirstName = "FirstTwo",
                LastName = "LastTwo",
                Email = "two@email.com",
                PhoneNumber = "+31 622222222",
                Password = "password"
            },
            new User()
            {
                Id= 3,
                FirstName = "FirstThree",
                LastName = "LastThree",
                Email = "three@email.com",
                PhoneNumber = "+31 633333333",
                Password = "password"
            }
        };

        // GET: api/<NewUserController>
        [HttpGet]
        public List<User> Get()
        {
            return users;
        }

        // GET api/<NewUserController>/5
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            var res = users.Where(item => item.Id.Equals(id)).FirstOrDefault();

            return res;
        }

        // POST api/<NewUserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NewUserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NewUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
