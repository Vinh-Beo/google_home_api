using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.ReportState
{
    public class ReportStateDevices
    {
        public string requestId { get; set; }
        public string agentUserId { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public Devices devices { get; set; }
    }

    public class Devices
    {
        public object states { get; set; }
    }

    public class infoOnOffReportState
    {
        public bool on { get; set; }

    }

    public class infoOpenCloseReportState
    {
        public int openPercent { get; set; }
    }

  
    public class infoTempReportState
    {
        public double thermostatTemperatureSetpoint { get; set; }
    }

    public class infoModeReportState
    {
        public string thermostatMode { get; set; }
    }

    public class infoScenesReportState
    {
        public bool on { get; set; }
    }

}