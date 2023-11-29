using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static List<Car> cars = new List<Car>();
        private static int idCounter = 0;
        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return cars;
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return cars.Find(x => x.id == id);
        }

        // POST api/<CarsController>
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            car.id = ++idCounter;
            cars.Add(car);
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car car)
        {
            Car c = cars.Find(x => x.id == id);
            if (c != null)
            {
                c.loc = car.loc;
                c.status = car.status;
                return;
            }
            car.id = ++idCounter;
            cars.Add(car);
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Car c = cars.Find(x => x.id == id);
            if (c != null)
                cars.Remove(c);
        }
        [HttpPut("{id}")]
        public void 
    }
}
