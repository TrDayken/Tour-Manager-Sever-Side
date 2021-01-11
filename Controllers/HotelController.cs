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
            new Hotel(1, "dai dong phu", 200, "48 bui thi xuan"),
            new Hotel(2, "dau cung duoc",400 , "whereever you go"),
            new Hotel(3, "Paradis" ,500, "big duck"),
        };

        #endregion

        #region Get method

        //get all hotel
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Hotel> GetAllHotel()
        {
            return hotels;
        }


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Hotel GetSpecificHotel(int id)
        {
            return hotels[id];
        }
        #endregion

        #region Post method

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Hotel body)
        {
            for (int i = 0; i < hotels.Count(); i++)
            {
                if(hotels[i].HotelID == body.HotelID)
                {
                    hotels[i] = body;
                    return;
                }
            }

            hotels.Add(body);
        }
        #endregion

        #region Put method


        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Hotel value)
        { 
        }
        #endregion

        #region Delete method

        #endregion







        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
