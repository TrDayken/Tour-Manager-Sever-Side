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

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Crew> Get()
        {
            return CrewData.Instance.GetAllCrew();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Crew Get(int id)
        {
            return CrewData.Instance.GetCrew(id);
        }

        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Crew value)
        {
            CrewData.Instance.insertCrew(value);
        }

        #endregion

        #region Put method

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody]Crew value)
        {
            CrewData.Instance.updateCrew(value);
        }

        #endregion

        #region Delete method

        #endregion




        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CrewData.Instance.deteleCrew(id);
        }
    }
}
