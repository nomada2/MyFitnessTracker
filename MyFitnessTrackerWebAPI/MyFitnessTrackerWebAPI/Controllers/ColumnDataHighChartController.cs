﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFitnessTrackerWebAPI.Controllers
{
    public class ColumnDataHighChartController : ApiController
    {
        // GET: api/ColumnDataHighChart
        public IEnumerable<string> Get(DateTime startDate, DateTime endDate)
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ColumnDataHighChart/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ColumnDataHighChart
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ColumnDataHighChart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ColumnDataHighChart/5
        public void Delete(int id)
        {
        }
    }
}
