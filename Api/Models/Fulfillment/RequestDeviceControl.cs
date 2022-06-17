using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.RequestDeviceControl
{

    public class RequestDeviceControl
    {
        public string responseId { get; set; }
        public Queryresult queryResult { get; set; }
        public Webhookstatus webhookStatus { get; set; }
    }

    public class Queryresult
    {
        public string queryText { get; set; }
        public Parameters parameters { get; set; }
        public bool allRequiredParamsPresent { get; set; }
        public string fulfillmentText { get; set; }
        public Fulfillmentmessage[] fulfillmentMessages { get; set; }
        public Intent intent { get; set; }
        public string intentDetectionConfidence { get; set; }
        public Diagnosticinfo diagnosticInfo { get; set; }
        public string languageCode { get; set; }
    }

    public class Parameters
    {
        public string Device { get; set; }
        public string Status { get; set; }
    }

    public class Intent
    {
        public string name { get; set; }
        public string displayName { get; set; }
    }

    public class Diagnosticinfo
    {
        public int webhook_latency_ms { get; set; }
    }

    public class Fulfillmentmessage
    {
        public Text text { get; set; }
    }

    public class Text
    {
        public string[] text { get; set; }
    }

    public class Webhookstatus
    {
        public int code { get; set; }
        public string message { get; set; }
    }


}