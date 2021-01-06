using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tour_Manager_Sever_Side.Objects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tour_Manager_Sever_Side.Controllers
{
    [Route("api/[controller]")]
    public class LocationController : Controller
    {
        #region testcase
        private static List<Location> locations = new List<Location>
        {
            new Location(1, "Gia Lai", "dai di"),
            new Location(2, "akihabara", "anime land"),
            new Location(3, "Paradis" , "many titan and levi go brrr"),
        };

        #endregion

        #region Get method
        // GET: api/<controller>

        // GET api/<controller>/5
        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return locations;
        }

        //GET api/location/5
        [HttpGet("{id}")]
        public Location Get(int id)
        {
            return locations[id];
        }


        //GET api/location/id={id}
        [HttpGet("id={id}")]
        public Location GetLocationName(int id)
        {
            return locations[id];
        }

        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Location location)
        {
            locations.Add(location); 
        }

        #endregion

        #region Put method
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Location location)
        {
            for (int i = 0; i < locations.Count; i++)
            {
                if (locations[i].LocationId == id)
                    locations[i] = location;
            }
        }
        #endregion

        #region Delete method
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < locations.Count; i++)
            {
                if (locations[i].LocationId == id)
                    locations.RemoveAt(i);
            }
        }
        #endregion









    }
}
