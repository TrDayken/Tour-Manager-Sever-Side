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
    public class ExpensesController : Controller
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
        public IEnumerable<Expenses> Get()
        {
            return ExpensesData.Instance.GetAllExpenses();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Expenses Get(int id)
        {
            return ExpensesData.Instance.GetExpenses(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Expenses value)
        {
            ExpensesData.Instance.insertExpenses(value);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody]Expenses value)
        {
            ExpensesData.Instance.updateExpenses(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ExpensesData.Instance.deteleExpenses(id);
        }
    }
}
