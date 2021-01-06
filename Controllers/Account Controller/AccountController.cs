using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tour_Manager_Sever_Side.Controllers.Account_Controller
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        #region Get method
        // GET: api/<controller>
            
        //GET:: api/Account
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "id 1", "id 2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name = "Get_specific_account")]
        public string Get(int id)
        {
            return "id = " + id ;
        }

        #endregion

        #region Post method
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        #endregion

        #region Put method
        // PUT api/<controller>/5
        [HttpPut("{id}" , Name = "Update Specific Account" )]
        public void Put(int id, [FromBody]string value)
        {
        }
        #endregion

        #region Delete method
        // DELETE api/<controller>/5
        [HttpDelete("{id}", Name = "Delete Specific Account")]
        public void Delete(int id)
        {
        }
        #endregion

    }
}
