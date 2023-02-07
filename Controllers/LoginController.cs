using LoginEntityApi.DB;
using LoginEntityApi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginEntityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // POST api/<LoginController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            SampleDbContext dbContext = new SampleDbContext();
            Customer customer=new Customer();

            customer.Id = Guid.NewGuid();
            customer.UserName=value.UserName;
            customer.Password=value.Password;
            dbContext.customers.Add(customer);
            dbContext.SaveChanges();


        }

       
    }
}
