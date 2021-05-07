﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Token.Manager
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        public string Error { get; set; }
    }
}
