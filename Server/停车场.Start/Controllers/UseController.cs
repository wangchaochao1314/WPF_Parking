using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 停车场.Start.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public string  Login([FromForm]string usename,string password)
        {
            return "{\"State\":\"True\"}";
        }
      
    }
}
