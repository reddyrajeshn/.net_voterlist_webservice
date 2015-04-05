using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using VoterList.Models;

namespace RESTVoterList.Controllers
{
    public class VoterListMasterController:ApiController
    {
        VotersConcrete vc;
        public VoterListMasterController()
        {
            vc = new VotersConcrete();
        }

        [Route("VoterListMaster")]
        public List<VoterListMaster> GetVoters()
        {
            return vc.GetVoters();
        }

        [Route("VoterListMaster/name/{name}")]
        public List<VoterListMaster> GetVotersByName(string name)
        {
            return vc.GetVotersByName(name);
        }

        [Route("VoterListMaster/father/{name}")]
        public List<VoterListMaster> GetVotersByFatherName(string name)
        {
            return vc.GetVotersByFatherName(name);
        }

        [Route("VoterListMaster/booth/{ID}")]
        public List<VoterListMaster> GetVotersByBoothID(int ID)
        {
            return vc.GetVotersByBoothID(ID);
        }

        [Route("VoterListMaster/constituent/{ID}")]
        public List<VoterListMaster> GetVotersByConstituentID(int ID)
        {
            return vc.GetVotersByConstituentID(ID);
        }

        [Route("VoterListMaster/age/{age}")]
        public List<VoterListMaster> GetVotersByAge(int age)
        {
            return vc.GetVotersByAge(age);
        }

        [Route("VoterListMaster/sex/{sex}")]
        public List<VoterListMaster> GetVotersBySex(string sex)
        {
            return vc.GetVotersBySex(sex);
        }

        [Route("VoterListMaster/ID/{voterID}")]
        public List<VoterListMaster> GetVotersByVoterID(string voterID)
        {
            return vc.GetVotersByVoterID(voterID);
        }

        [Route("VoterListMaster/search/{voter}")]
        public List<VoterListMaster> GetVoters(VoterListMaster vlm)
        {
            return vc.GetVoters(vlm);
        }
    }
}