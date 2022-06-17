using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Request.Query
{
    public class RequestQueryModel
    {
        public Input[] inputs { get; set; }
        public string requestId { get; set; }
    }

    public class Input
    {
        public string intent { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public Device[] devices { get; set; }
    }

    public class Device
    {
        public Customdata customData { get; set; }
        public string id { get; set; }
    }

    public class Customdata
    {
        public bool barValue { get; set; }
        public string bazValue { get; set; }
        public int fooValue { get; set; }
    }

}