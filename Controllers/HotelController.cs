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
    public class HotelController : Controller
    {
        #region testcase 

        private static List<Hotel> hotels = new List<Hotel>
        {
/*            new Hotel(1, "dai dong phu", 200, "48 bui thi xuan"),
            new Hotel(2, "dau cung duoc",400 , "whereever you go"),
            new Hotel(3, "Paradis" ,500, "big duck"),*/
        };

        #endregion

        #region Get method

        //get all hotel
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return HotelData.Instance.GetAllHotel();
        }


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return HotelData.Instance.GetHotel(id);
        }

        // GET api/hotel/id/crew
        [HttpGet("{id}/crew")]
        public IEnumerable<Crew> GetCrew(int id)
        {
            return HotelData.Instance.GetCrewbyHotelID(id);
        }
        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Hotel value)
        {
            HotelData.Instance.insertHotel(value);
        }
        #endregion

        #region Put method


        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody] Hotel value)
        {
            HotelData.Instance.updateHotel(value);
        }
        #endregion

        #region Delete method

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            HotelData.Instance.deteleHotel(id);
        }


        #endregion







    }
}
