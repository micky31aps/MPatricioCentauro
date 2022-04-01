using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class GpsController : ApiController
    {
        // GET api/gps
        [Route("api/gps/GetAll")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            ML.Result result = BL.Gps.GetAll();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [HttpGet]
        [Route("api/gps/GetById/{IdGps}")]
        public IHttpActionResult GetById(int IdGps)
        {
            ML.Result result = BL.Gps.GetById(IdGps);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }
        [Route("api/gps/Add")]
        [HttpPost]
        public IHttpActionResult Add([FromBody] ML.Gps gps)
        {
            ML.Result result = BL.Gps.Add(gps);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [HttpPut]
        [Route("api/gps/Update/{IdGps}")]
        public IHttpActionResult Update(int IdGps, [FromBody] ML.Gps gps)
        {
            gps.Id = IdGps;
            ML.Result result = BL.Gps.Update(gps);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }
        
        [HttpDelete]
        [Route("api/gps/Delete/{IdGps}")]
        public IHttpActionResult Delete(int IdGps)
        {
            ML.Gps gps = new ML.Gps();
            gps.Id = IdGps;
            ML.Result result = BL.Gps.Delete(gps);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }
    }
}
