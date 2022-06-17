using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Request.Sync
{
    public class RequestSyncModel
    {
        public Input[] inputs { get; set; }
        public string requestId { get; set; }
    }

    public class Input
    {
        public string intent { get; set; }
    }

}