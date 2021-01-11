using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tour_Manager_Sever_Side.Objects;
using Tour_Manager_Sever_Side.Objects.person;
using Tour_Manager_Sever_Side.DataBase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tour_Manager_Sever_Side.Controllers.Account_Controller
{
    [Route("api/[controller]")]
    public class TransferController : Controller
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
        public IEnumerable<Transfer> Get()
        {
            return TransferData.Instance.GetAllTransfer();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Transfer Get(int id)
        {
            return TransferData.Instance.GetTransfer(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Transfer value)
        {
            TransferData.Instance.insertTransfer(value);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody] Transfer value)
        {
            TransferData.Instance.updateTransfer(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TransferData.Instance.deteleTransfer(id);
        }
    }
}
