using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Request.Execute
{
    public class RequestExecuteModel
    {
        public Input[] inputs { get; set; }
        public string requestId { get; set; }
    }

    public class Input
    {
        public Context context { get; set; }
        public string intent { get; set; }
        public Payload payload { get; set; }
    }

    public class Context
    {
        public string locale_country { get; set; }
        public string locale_language { get; set; }
    }

    public class Payload
    {
        public Command[] commands { get; set; }
    }

    public class Command
    {
        public Device[] devices { get; set; }
        public Execution[] execution { get; set; }
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

    public class Execution
    {
        public string command { get; set; }
        public Params @params { get; set; }
    }

    public class Params
    {
        public string on { get; set; }
        public int openPercent { get; set; }
        public bool deactivate { get; set; }
        public float thermostatTemperatureSetpoint { get; set; }
        public string thermostatMode { get; set; }
        public int brightness { get; set; }
    }

}