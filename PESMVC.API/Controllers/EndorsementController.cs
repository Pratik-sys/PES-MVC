using PESMVC.API.Interface;
using PESMVC.Data.DTO.Endorsement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PESMVC.API.Controllers
{
    public class EndorsementController : ApiController
    {
        private readonly IEndorsementService _endorsementService;

        public EndorsementController(IEndorsementService endorsementService)
        {
            _endorsementService = endorsementService;
        }

        [HttpGet]
        public List<GetEndorsementsRespone> GetAllEndorsementsApi()
        {
            var result = new List<GetEndorsementsRespone>();
            try
            {
                result = _endorsementService.GetAllEndorsements();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;

        }

        [HttpGet]
        public List<GetEndorsementsStatusResponse> GetAllEndorsementStatusApi(string id)
        {
            var result = new List<GetEndorsementsStatusResponse>();
            try
            {
                result = _endorsementService.GetAllEndorsementStatus(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        
        [HttpPost]
        public IHttpActionResult EndorsementApprovalApi(EndorsementApprovalRequest endorsementApprovalRequest)
        {
            string message = "Failed";
            if (_endorsementService.EndorsementApproval(endorsementApprovalRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }

    }
}
