﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace TemplateCore.Controllers
{
    public class BaseController
    {
        [HttpGet]
        public async Task<object> GetApartmentsAsync()
        {
            var res =  new List<object>();

            return res;
        }


        public async Task<object> PostLogInUser()
        {
            var res = new List<object>();

            return res;
        }
    }
}