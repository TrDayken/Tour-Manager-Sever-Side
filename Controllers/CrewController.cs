using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tour_Manager_Sever_Side.Objects;
using Tour_Manager_Sever_Side.DataBase;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tour_Manager_Sever_Side.Controllers.Account_Controller
{
    [Route("api/[controller]")]
    public class CrewController : Controller
    {

        #region Get method

        // GET: api/crew

/*        [HttpGet]
        public IEnumerable<Crew> GetAllCrew()
        {
            //return 
        }
*/
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string GetSpecificCrew(int id)
        {
            return "value";
        }

        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Crew body)
        {
            // create new crew;

            //return 404 if already exists?
        }

        #endregion

        #region Put method

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Crew body)
        {
            // udpate crew value to database 
        }

        #endregion

        #region Delete method

        #endregion




        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
