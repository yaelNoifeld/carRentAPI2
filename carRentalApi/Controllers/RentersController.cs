using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentersController : ControllerBase
    {
        private static List<Renter> renters = new List<Renter>();
        private static int idCounter = 0;
        // GET: api/<RentersController>
        [HttpGet]
        public IEnumerable<Renter> Get()
        {
            return renters;
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public Renter Get(int id)
        {
            return renters.Find(x=>x.id==id);
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] Renter renter)
        {
            renter.id = ++idCounter;
            renters.Add(renter);
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Renter renter)
        {
            Renter r = renters.Find(x => x.id == id);
            if (r != null)
            {
                r.discountPercent = renter.discountPercent;
                r.sumRents = renter.sumRents;
                r.name = renter.name;
                return;
            }
            renter.id = ++idCounter;
            renters.Add(renter);
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Renter r= renters.Find(x => x.id == id);
            if (r != null)
                renters.Remove(r);
        }
    }
}
