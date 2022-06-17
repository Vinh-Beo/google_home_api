using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Response.Execute
{
    
    public class ResponseExecuteModel
    {
        public string requestId { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public Command[] commands { get; set; }
    }

    public class Command
    {
        public string[] ids { get; set; }
        public string status { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object states { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode { get; set; }
    }


    #region OnOff
    public class StatesOnOff
    {
        public bool on { get; set; }
        public bool online { get; set; }
    }
    #endregion OnOff
    #region Brightness
    public class StatesBrightness
    {
        public int brightness { get; set; }
    }
    #endregion Brightness
    #region OpenClose
    public class StatesOpenClose
    {
        public bool on { get; set; }
        public bool online { get; set; }
        public int openPercent { get; set; }
        public Openstate[] openState { get; set; }
        
    }
    #endregion OpenClose
    #region Scene
    public class StatesScene
    {
        
    }
    #endregion Scene
    #region TemperatureSetting
    public class StatesTemperatureSetting
    {
        public double thermostatTemperatureSetpoint { get; set; }
    }

    public class StatesTherModeSetting
    {
        public string thermostatMode { get; set; }
    }

    #endregion TemperatureSetting
    #region AppSelector
    public class StatesAppSelector
    {
        public bool online { get; set; }
        public string currentApplication { get; set; }
    }
    #endregion AppSelector
    #region FanSpeed
    public class StatesFanSpeed
    {
        public string currentFanSpeedSetting { get; set; }
    }
    #endregion FanSpeed
    #region InputSelector
    public class StatesInputSelector
    {
        public string currentInput { get; set; }
    }
    #endregion InputSelector
    #region Modes
    public class StatesModes
    {
        public Currentmodesettings currentModeSettings { get; set; }
    }
    public class Currentmodesettings
    {
        public string drytype { get; set; }
        public string load { get; set; }
    }

    #endregion Modes
    #region Toggles
    public class StatesToggles
    {
        public Currenttogglesettings currentToggleSettings { get; set; }
    }

    public class Currenttogglesettings
    {
        public bool sterilization { get; set; }
        public bool energysaving { get; set; }
    }
    #endregion Toggles
    #region Volume
    public class StatesVolume
    {
        public bool online { get; set; }
        public int currentVolume { get; set; }
    }
    #endregion Volume

    public class ControlDvChannel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public int Index { get; set; }
        public int Channel { get; set; }
        public int ControlStatus { get; set; }
        public int ReturnStatus { get; set; }
        public bool IsNeedAck { get; set; }
        public bool IsAck { get; set; }
        public string Command { get; set; }
        public string SetPoint { get; set; }
    }

    public class ParamsAC
    {
        public float thermostatTemperatureSetpoint { get; set; }
        public string thermostatMode { get; set; }
    }


    public class ControlDvSendCmd
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public int Index { get; set; }

        public string Cmd { get; set; }
        public string Data { get; set; }
        public string DataResp { get; set; }

        public bool IsAck { get; set; }
    }

    public class ControlDvAck
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public int Index { get; set; }
        public bool IsAck { get; set; }

        public string DataResp { get; set; }
    }

    public class Color
    {
        public int spectrumRgb { get; set; }
        public SpectrumHsv spectrumHsv { get; set; }
    }

    public class SpectrumHsv
    {
        public int hue { get; set; }
        public int saturation { get; set; }
        public int value { get; set; }
        public long temperatureK { get; set; }
    }

    public class Openstate
    {
        public int openPercent { get; set; }
        public string openDirection { get; set; }
    }
}