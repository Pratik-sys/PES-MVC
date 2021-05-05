using PESMVC.API.Interface;
using PESMVC.Data.DTO.Endorsement;
using PESMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PESMVC.API.Services
{
    public class EndorsementService: IEndorsementService
    {
        private readonly PES_TestEntities _dbContext;
        public EndorsementService(PES_TestEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public bool EndorsementApproval(EndorsementApprovalRequest endorsementApprovalRequest)
        {
            bool flag = false;
            try
            {
                _dbContext.endorsementApproval(endorsementApprovalRequest.endorsementId, endorsementApprovalRequest.policyNumber, endorsementApprovalRequest.Flag);

                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }

        public List<GetEndorsementsRespone> GetAllEndorsements()
        {
            List<GetEndorsementsRespone> result = new List<GetEndorsementsRespone>();
            GetEndorsementsRespone endorsement = null;
            try
            {
                var endorsements = _dbContext.getAllEndorsements();
                foreach (var e in endorsements)
                {
                    endorsement = new GetEndorsementsRespone();
                    endorsement.endorsementId = e.endorsementId;
                    endorsement.policyNumber = e.policyNumber;
                    endorsement.FieldChanges = e.FieldChanges;
                    endorsement.endorsementStatus = e.EndorsementStatus.ToString();
                    result.Add(endorsement);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public List<GetEndorsementsStatusResponse> GetAllEndorsementStatus(string id)
        {
            List<GetEndorsementsStatusResponse> result = new List<GetEndorsementsStatusResponse>();
            GetEndorsementsStatusResponse endorsementStatus = null;
            try
            {
                var endorsementsStatus = _dbContext.getAllEndorsementsStatus(id);
                foreach (var es in endorsementsStatus)
                {
                    endorsementStatus = new GetEndorsementsStatusResponse();
                    endorsementStatus.endorsementId = es.endorsementId;
                    endorsementStatus.policyNumber = es.policyNumber;
                    endorsementStatus.endorsementStatus = es.endorsementStatus;
                    result.Add(endorsementStatus);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}