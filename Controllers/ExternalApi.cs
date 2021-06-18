using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Dynamic;
using TLPD.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace TLPD.Controllers
{​​​​​​​
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalApi : ControllerBase
    {​​​​​​​


        [HttpGet]
        public IActionResult Get(string From, string Destination, int Height, int Length, int Width, int Weight)
        {​​​​​​​
            ItemData foo = new ItemData();
            // calculate price and time
            foo.Time = 30;
            foo.Price = 250;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(foo);
            return Ok(json);
        }​​​​​​​
    }​​​​​​​
}