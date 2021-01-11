﻿using System;
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

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Hotel value)
        {
            HotelData.Instance.insertHotel(value);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody] Hotel value)
        {
            HotelData.Instance.updateHotel(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            HotelData.Instance.deteleHotel(id);
        }
    }
}
