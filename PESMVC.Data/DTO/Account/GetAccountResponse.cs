using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Account
{
    public class getAccountResponse
    {
        public int Id { get; set; }
        public string loginId { get; set; }
        public string pswd { get; set; }
        public string roleType { get; set; }
    }
}
