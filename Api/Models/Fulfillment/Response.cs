using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Api.Models.Response
{
    public class ResponseEnd
    {
        public PayloadEnd payload { get; set; }
        public string fulfillmentText { get; set; }
        public string speech { get; set; }
        public string displayText { get; set; }
        public string source { get; set; }
    }

    public class Response
    {
        public Payload payload { get; set; }
        public string fulfillmentText { get; set; }
        public string speech { get; set; }
        public string displayText { get; set; }
        public string source { get; set; }
    }

    public class PayloadEnd
    {
        public GoogleEnd google { get; set; }
    }
    public class Payload
    {
        public Google google { get; set; }
    }
    public class GoogleEnd
    {
        public bool expectUserResponse { get; set; }
        public Finalresponse finalResponse { get; set; }
    }
    public class Google
    {
        public bool expectUserResponse { get; set; }
        public Richresponse richResponse { get; set; }
    }

    public class Richresponse
    {
        public Item[] items { get; set; }
    }

    public class Item
    {
        public Simpleresponse simpleResponse { get; set; }
    }

    public class Simpleresponse
    {
        public string textToSpeech { get; set; }
        public string languageCode { get; set; }
    }


    
    public class Finalresponse
    {
        public Richresponse richResponse { get; set; }
    }
}