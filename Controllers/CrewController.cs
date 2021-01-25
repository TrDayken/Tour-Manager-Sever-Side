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

        [HttpGet("{id}/hotel")]
        public IEnumerable<Hotel> GetHotel(int id)
        {
            return CrewData.Instance.GetHotelbyCrewID(id);
        }

        [HttpGet("{id}/vehicle")]
        public IEnumerable<Vehicle> GetVehicle(int id)
        {
            return CrewData.Instance.GetVehiclebyCrewID(id);
        }
        [HttpGet("{id}/person")]
        public IEnumerable<Person> GetPerson(int id)
        {
            return CrewData.Instance.GetPersonbyCrewID(id);
        }
        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Crew value)
        {
            CrewData.Instance.insertCrew(value);
        }

        [HttpPost("{id1}/hotel/{id2}")]
        public int PostHotel(int id1,int id2)
        {
            return CrewData.Instance.add_HoteltoCrew(id2, id1);
        }
        [HttpPost("{id1}/vehicle/{id2}")]
        public int PostVehicle(int id1, int id2)
        {
            return CrewData.Instance.add_VehicletoCrew(id1, id2);
        }

        [HttpPost("{id1}/person/{id2}")]
        public int PostPerson(int id1, int id2)
        {
            return CrewData.Instance.add_PersontoCrew(id1, id2);
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

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CrewData.Instance.deteleCrew(id);
        }

        [HttpDelete("{id1}/hotel/{id2}")]
        public void DeleteHotel(int id1, int id2)
        {
            CrewData.Instance.delete_HoteltoCrew(id2, id1);
        }

        [HttpDelete("{id1}/vehicle/{id2}")]
        public void DeleteVehicle(int id1, int id2)
        {
            CrewData.Instance.delete_VehicletoCrew(id1, id2);
        }

        [HttpDelete("{id1}/person/{id2}")]
        public void DeletePerson(int id1, int id2)
        {
            CrewData.Instance.delete_PersontoCrew(id1, id2);
        }
        #endregion

    }
}
