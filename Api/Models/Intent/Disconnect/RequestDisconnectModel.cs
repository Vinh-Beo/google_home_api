using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Request.Disconnect
{


    public class RequestDisconnectModel
    {
        public string requestId { get; set; }
        public Input[] inputs { get; set; }
    }

    public class Input
    {
        public string intent { get; set; }
    }

}