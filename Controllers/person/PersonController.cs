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

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            PersonData.Instance.insertPerson(person);
        }

        // PUT api/<controller>/5
        [HttpPut]
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
    }
}
