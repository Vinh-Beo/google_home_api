using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Oauth2
{
    public class AuthorizationModel
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string RedirectUri { get; set; }

        public string ResponseType { get; set; }

        public string State { get; set; }

        public string Scope { get; set; }

        public string UserLocale { get; set; }

        public string AutherizationCode { get; set; }

        public string AccessToken { get; set; }
    }
}   