﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [HttpPost]
        [Route("moi")]
        public string SanoMoi()
        {
            return "Moikka ASP.NET:istä!";
        }

        [HttpGet]
        [Route("aika")]
        public DateTime Kellonaika()
        {
            return DateTime.Now;
        }

        // [HttpGet]
        [Route("luvut")]
        public int[] Luvut()
        {
            return new int[] { 3, 5, 7, 9, 11 };
        }
    }
}
