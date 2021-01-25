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
    public class PersonController : Controller
    {

        #region Get method

        #endregion

        #region Post method

        #endregion

        #region Put method

        #endregion

        #region Delete method

        #endregion

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return PersonData.Instance.GetAllPerson();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return PersonData.Instance.GetPerson(id);
        }

        [HttpGet("{id}/crew")]
        public IEnumerable<Crew> GetCrew(int id)
        {
            return PersonData.Instance.GetCrewbyPersonID(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            PersonData.Instance.insertPerson(person);
        }

        [HttpPost("{id1}/crew/{id2}")]
        public int PostCrew(int id1, int id2)
        {
            return CrewData.Instance.add_PersontoCrew(id2, id1);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put([FromBody]Person value)
        {
            PersonData.Instance.updatePerson(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PersonData.Instance.detelePerson(id);
        }

        [HttpDelete("{id1}/crew/{id2}")]
        public void DeleteCrew(int id1, int id2)
        {
            CrewData.Instance.delete_PersontoCrew(id2, id1);
        }
    }
}
