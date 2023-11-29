using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private static List<Rent> rents = new List<Rent>();
        private static int idCounter = 0;
        // GET: api/<RentsController>
        [HttpGet]
        public IEnumerable<Rent> Get()
        {
            return rents;
        }

        // GET api/<RentsController>/5
        [HttpGet("{id}")]
        public Rent Get(int id)
        {
            return rents.Find(x => x.id == id);
        }

        // POST api/<RentsController>
        [HttpPost]
        public void Post([FromBody] Rent rent)
        {
            rent.id = ++idCounter;
            rents.Add(rent);
        }

        // PUT api/<RentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Rent rent)
        {
            Rent r = rents.Find(x => x.id == id);
            if (r != null)
            {
                r.renter = rent.renter;
                r.car=rent.car;
                return;
            }
            rent.id = ++idCounter;
            rents.Add(rent);
        }

        // DELETE api/<RentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Rent r = rents.Find(x => x.id == id);
            if (r != null)
                rents.Remove(r);
        }
    }
}
