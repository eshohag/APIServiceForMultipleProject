using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using APIServiceForMultipleProject.DAL;
using APIServiceForMultipleProject.Models;

namespace APIServiceForMultipleProject.Controllers
{
    public class CarController : ApiController
    {
        private readonly CarDatabase aCarDatabase;
        public CarController()
        {
            aCarDatabase = new CarDatabase();
        }
        // GET: api/Car
        public IEnumerable<Car> Get()
        {
            return aCarDatabase.GetCars().AsEnumerable();
        }

        // GET: api/Car/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Car
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
        }
    }
}