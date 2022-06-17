using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Oauth2
{
    public class ResponseLogin
    {
            public string token_type { get; set; }
            public string access_token { get; set; }
            public string refresh_token { get; set; }
            public long expires_in { get; set; }
    }
}