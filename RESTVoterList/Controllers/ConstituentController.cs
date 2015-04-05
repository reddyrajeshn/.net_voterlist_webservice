using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VoterList.Models;

namespace RESTVoterList.Controllers
{
    public class ConstituentController : ApiController
    {
        VotersConcrete vc;
        public ConstituentController()
        {
            vc = new VotersConcrete();
        }

        [Route("constituent/{ID}")]
        public Constituent GetConstituentByID(int ID)
        {   
            return vc.GetConstituentByID(ID);
        }

        [Route("constituent/name/{name}")]
        public Constituent GetConstitiuentByName(string name)
        {
            return vc.GetConstituentByName(name);
        }

        [Route("constituent/state/{state}")]
        public Constituent GetConstituentByState(string state)
        {
            return vc.GetConstituentByState(state);
        }

        [Route("constituent")]
        public List<Constituent> GetConstituents()
        {
            return vc.GetConstituents();
        }
    }
}
