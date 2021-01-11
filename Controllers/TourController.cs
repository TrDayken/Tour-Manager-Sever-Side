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
    public class TourController : Controller
    {

        #region Get method

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Tour> Get()
        {
            return TourData.Instance.GetAllTour();
        }

        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Tour tour)
        {
            TourData.Instance.insertTour(tour);
        }

        #endregion

        #region Put method

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody]Tour value)
        {
            TourData.Instance.updateTour(value);
        }


        #endregion

        #region Delete method

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TourData.Instance.deteleTour(id);
        }

        #endregion






    }
}
