using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VoterList.Models;

namespace RESTVoterList.Controllers
{
    public class BoothController : ApiController
    {
        VotersConcrete vc;
        public BoothController()
        {
            vc = new VotersConcrete();
        }

        [Route("booth")]
        public IEnumerable<PollingBooth> GetBooth()
        {
            try
            {
                return vc.GetBooth();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Route("booth/{ID}")]
        public PollingBooth GetBoothByID(int ID)
        {
            return vc.GetBoothByID(ID);
        }

        [Route("booth/name/{name}")]
        public HttpResponseMessage GetBoothByName(string name)
        {
            HttpResponseMessage test = new HttpResponseMessage();
           
            
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, vc.GetBoothByName(name));
            }
            catch (Exception ex)
            {
                HttpError myCustomError = new HttpError("My custom error message") { { "CustomErrorCode", ex.InnerException.Message } };
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, myCustomError);
            }
        }
    }
}