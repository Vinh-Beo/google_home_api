using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Response.Query
{
    public class ResponseQueryModel
    {
        public string requestId { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public object devices { get; set; }
    }
    public class infoOnOnff
    {
        public bool on { get; set; }
        public bool online { get; set; }
        public string status { get; set; }
    }

    public class infoScene
    {
        public bool online { get; set; }
        public string status { get; set; }
    }

    public class infoAC
    {
        public bool online { get; set; }
        public string activeThermostatMode { get; set; }
        public long targetTempReachedEstimateUnixTimestampSec { get; set; }
        public float thermostatHumidityAmbient { get; set; }
        public string thermostatMode { get; set; }
        public double thermostatTemperatureAmbient { get; set; }
        public  double thermostatTemperatureSetpoint { get; set; }
        public string thermostatTemperatureSetpointHigh { get; set; }
        public string thermostatTemperatureSetpointLow { get; set; }
        public string status { get; set; }
    }

    public class infoBrightness
    {
        public int brightness { get; set; }
        public bool online { get; set; }
        public string status { get; set; }
    }




    public class infoOpenClose
    {
        public bool on { get; set; }
        public bool online { get; set; }
        public Openstate[] openState { get; set; }
        public float openPercent { get; set; }
        public string openDirection { get; set; }
    }

    public class MyClass
    {
       
        public Color color { get; set; }
        public string currentFanSpeedSetting { get; set; }
        public string currentInput { get; set; }
        public string activityState { get; set; }
        public string playbackState { get; set; }
        public Currentmodesettings currentModeSettings { get; set; }
        public bool isPaused { get; set; }
        public bool isRunning { get; set; }
        public Currenttogglesettings currentToggleSettings { get; set; }
    }

    public class Currenttogglesettings
    {
        public bool sterilization { get; set; }
    }


    public class Currentmodesettings
    {
        public string drytype { get; set; }
        public string load { get; set; }
        public string temperature { get; set; }
    }

    public class Color
    {
        public int spectrumRgb { get; set; }
    }

    public class Openstate
    {
        public float openPercent { get; set; }
        public string openDirection { get; set; }
    }

    public class ResponseDvChannelStatus
    {
        public string Id { get; set; }
        public int Status { get; set; }
    }

    public class ResponseDvChannelTemp
    {
        public string Id { get; set; }
        public int thermostatTemperatureSetpoint { get; set; }
    }


    public class ResponseDvChannelState
    {
        public string Id { get; set; }
        public int Status { get; set; }
    }
}