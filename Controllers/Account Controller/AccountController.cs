using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tour_Manager_Sever_Side.DataBase;
using Tour_Manager_Sever_Side.Model;

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
        public IEnumerable<int> Get()
        {

            //return new string[] { "id 1", "id 2" };
            return AccountData.Instance.GetAllId();
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name = "Get_specific_account")]
        public string Get(int id)
        {
            //return "id = " + id ;
            return "id = " + AccountData.Instance.login("1", "1");
        }

        #endregion

        #region Post method
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }


        [HttpPost("login")]
        public int Login([FromBody] UserCred cred)
        {
            return AccountData.Instance.login(cred.UserName, cred.Password);
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
