using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tour_Manager_Sever_Side.DataBase;
using Tour_Manager_Sever_Side.Model;
using Tour_Manager_Sever_Side.Objects.person;
using Tour_Manager_Sever_Side.Objects;

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
        public int Get(int id)
        {
            //return "id = " + id ;
            return  AccountData.Instance.login("1", "1");
        }

        [HttpGet("{id}/person")]
        public Person GetPerson(int id)
        {
            //return "id = " + id ;
            return AccountData.Instance.GetPersonByIDAccount(id);
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



        [HttpPost("register")]
        public int Register([FromBody] UserCred cred)
        {
            int idtk = AccountData.Instance.register(cred.UserName, cred.Password); ;
            if(idtk >=0)
            {
                Person person = new Person(0,"name","123456789",true,"012345678",idtk);
                PersonData.Instance.insertPerson(person);
            }
            return idtk;
        }

        [HttpPost("update")]
        public int  Update([FromBody] List<UserCred> cred)
        {
            // -1 tk hoac mk ko dung
            // 1 update thanh cong
            return AccountData.Instance.update(cred[0].UserName, cred[0].Password, cred[0].Password);

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
