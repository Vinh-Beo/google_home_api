using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.RequestWelcomeControl
{

    public class RequestWelcomeControl
    {
        public string responseId { get; set; }
        public Queryresult queryResult { get; set; }
        public Originaldetectintentrequest originalDetectIntentRequest { get; set; }
        public string session { get; set; }
    }

    public class Queryresult
    {
        public string queryText { get; set; }
        public string action { get; set; }
        public Parameters parameters { get; set; }
        public bool allRequiredParamsPresent { get; set; }
        public string fulfillmentText { get; set; }
        public Fulfillmentmessage[] fulfillmentMessages { get; set; }
        public Outputcontext[] outputContexts { get; set; }
        public Intent intent { get; set; }
        public float intentDetectionConfidence { get; set; }
        public string languageCode { get; set; }
    }

    public class Parameters
    {
    }

    public class Intent
    {
        public string name { get; set; }
        public string displayName { get; set; }
    }

    public class Fulfillmentmessage
    {
        public Text text { get; set; }
    }

    public class Text
    {
        public string[] text { get; set; }
    }

    public class Outputcontext
    {
        public string name { get; set; }
    }

    public class Originaldetectintentrequest
    {
        public string source { get; set; }
        public string version { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public User user { get; set; }
        public Conversation conversation { get; set; }
        public Input[] inputs { get; set; }
        public Surface surface { get; set; }
        public bool isInSandbox { get; set; }
        public Availablesurface[] availableSurfaces { get; set; }
    }

    public class User
    {
        public string accessToken { get; set; }
        public string locale { get; set; }
        public DateTime lastSeen { get; set; }
        public string userVerificationStatus { get; set; }
    }

    public class Conversation
    {
        public string conversationId { get; set; }
        public string type { get; set; }
    }

    public class Surface
    {
        public Capability[] capabilities { get; set; }
    }

    public class Capability
    {
        public string name { get; set; }
    }

    public class Input
    {
        public string intent { get; set; }
        public Rawinput[] rawInputs { get; set; }
    }

    public class Rawinput
    {
        public string inputType { get; set; }
        public string query { get; set; }
    }

    public class Availablesurface
    {
        public Capability1[] capabilities { get; set; }
    }

    public class Capability1
    {
        public string name { get; set; }
    }

}