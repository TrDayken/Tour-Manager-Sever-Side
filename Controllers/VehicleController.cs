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
    public class VehicleController : Controller
    {

        #region Get method

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return VehicleData.Instance.GetAllVehicle();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return VehicleData.Instance.GetVehicle(id);
        }
        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Vehicle value)
        {
            VehicleData.Instance.insertVehicle(value);
        }

        #endregion

        #region Put method

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody] Vehicle value)
        {
            VehicleData.Instance.updateVehicle(value);
        }

        #endregion

        #region Delete method

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            VehicleData.Instance.deteleVehicle(id);
        }

        #endregion








    }
}
