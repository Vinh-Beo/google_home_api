using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Response.Sync
{
    public class ResponseSyncModel
    {
        public string requestId { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public string agentUserId { get; set; }
        public object[] devices { get; set; }
    }

    public class DeviceOnOff
    {
        public string id { get; set; }
        public string type { get; set; }
        public string[] traits { get; set; }
        public Name name { get; set; }
        public bool willReportState { get; set; }
        public AttributesOnOff attributes { get; set; }
        public Deviceinfo deviceInfo { get; set; }
        public Customdata customData { get; set; }
    }

    public class DeviceTV
    {
        public string id { get; set; }
        public string type { get; set; }
        public string[] traits { get; set; }
        public Name name { get; set; }
        public bool willReportState { get; set; }
        public AttributesOnOff attributes { get; set; }
        public Deviceinfo deviceInfo { get; set; }
        public Customdata customData { get; set; }
    }

    public class DeviceAC
    {
        public string id { get; set; }
        public string type { get; set; }
        public string[] traits { get; set; }
        public Name name { get; set; }
        public bool willReportState { get; set; }
        public AttributesAC attributes { get; set; }
        public Deviceinfo deviceInfo { get; set; }
        public Customdata customData { get; set; }
    }

    public class DeviceOpenClose
    {
        public string id { get; set; }
        public string type { get; set; }
        public string[] traits { get; set; }
        public Name name { get; set; }
        public bool willReportState { get; set; }
        public AttributeOpenClose attributes { get; set; }
        public Deviceinfo deviceInfo { get; set; }
        public Customdata customData { get; set; }
    }

    public class Scenes
    {
        public string id { get; set; }
        public string type { get; set; }
        public string[] traits { get; set; }
        public Name name { get; set; }
        public bool willReportState { get; set; }
        public AttributeScene attributes { get; set; }
        public Customdata customData { get; set; }

    }

    public class Name
    {
        public string[] defaultNames { get; set; }
        public string name { get; set; }
        public string[] nicknames { get; set; }
    }



    public class AttributesAC
    {
        #region TemperatureSetting
        public string availableThermostatModes { get; set; }
        public ThermostatTemperatureRange thermostatTemperatureRange { get; set; }
        public string thermostatTemperatureUnit { get; set; }
        public double bufferRangeCelsius { get; set; }
        public bool commandOnlyTemperatureSetting { get; set; }
        public bool queryOnlyTemperatureSetting { get; set; }
        #endregion TemperatureSetting
    }


    public class ThermostatTemperatureRange
    {
        public float minThresholdCelsius { get; set; }
        public float maxThresholdCelsius { get; set; }
    }

    public class AttributesOnOff
    {
        #region Modes
        public Availablemode[] availableModes { get; set; }
        #endregion Modes
        #region Rotation
        public bool supportsDegrees { get; set; }
        public bool supportsPercent { get; set; }
        public Rotationdegreesrange rotationDegreesRange { get; set; }
        #endregion Rotation
        #region OnOff
        public bool commandOnlyOnOff { get; set; }
        #endregion OnOff
        #region Brightness
        public bool commandOnlyBrightness { get; set; }
        #endregion
        #region Toggles
        public Availabletoggle[] availableToggles { get; set; }
        #endregion Toggles
        #region AppSelector
        public Availableapplication[] availableApplications { get; set; }
        #endregion AppSelector
        #region InputSelector 
        public Availableinput[] availableInputs { get; set; }
        public bool orderedInputs { get; set; }
        #endregion InputSelector 
        #region MediaState
        public bool supportActivityState { get; set; }
        public bool supportPlaybackState { get; set; }
        #endregion MediaState
        #region TransportControl
        public string[] transportControlSupportedCommands { get; set; }
        #endregion TransportControl
        #region Volume
        public int volumeMaxLevel { get; set; }
        public bool volumeCanMuteAndUnmute { get; set; }
        public int levelStepSize { get; set; }
        public bool commandOnlyVolume { get; set; }
        public int volumeDefaultPercentage { get; set; }
        #endregion Volume
        #region Color Spectrum
        public string colorModel { get; set; }
        #endregion Color Spectrum
        #region ColorSetting
        public Colortemperaturerange colorTemperatureRange { get; set; }
        public bool commandOnlyColorSetting { get; set; }
        #endregion ColorSetting
    }

    public class AttributeScene
    {
        #region Scenes
        public bool sceneReversible { get; set; }
        #endregion Scenes
    }

    public class AttributeOpenClose
    {
        #region OpenClose
        public string[] openDirection { get; set; }
        public bool discreteOnlyOpenClose { get; set; }
        public bool queryOnlyOpenClose { get; set; }
        #endregion OpenClose
    }
    public class Deviceinfo
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string hwVersion { get; set; }
        public string swVersion { get; set; }
    }

    public class Customdata
    {
        public int fooValue { get; set; }
        public bool barValue { get; set; }
        public string bazValue { get; set; }
    }

    public class Name_Values
    {
        public string[] name_synonym { get; set; }
        public string lang { get; set; }
    }

    #region Toggles
    public class Availabletoggle
    {
        public string name { get; set; }
        public Name_Values[] name_values { get; set; }
    }

    #endregion Toggles
    #region Modes
    public class Availablemode
    {
        public string name { get; set; }
        public Name_Values[] name_values { get; set; }
        public Setting[] settings { get; set; }
        public bool ordered { get; set; }
    }
    public class Setting
    {
        public string setting_name { get; set; }
        public Setting_Values[] setting_values { get; set; }
    }
    public class Setting_Values
    {
        public string[] setting_synonym { get; set; }
        public string lang { get; set; }
    }
    #endregion Modes
    #region Rotation
    public class Rotationdegreesrange
    {
        public int rotationDegreesMin { get; set; }
        public int rotationDegreesMax { get; set; }
    }
    #endregion Rotation
    #region Fan Speed
    public class Availablefanspeeds
    {
        public Speed[] speeds { get; set; }
        public bool ordered { get; set; }
    }

    public class Speed
    {
        public string speed_name { get; set; }
        public Speed_Values[] speed_values { get; set; }
    }

    public class Speed_Values
    {
        public string[] speed_synonym { get; set; }
        public string lang { get; set; }
    }
    #endregion Fan Speed
    #region AppSelector 
    public class Availableapplication
    {
        public string key { get; set; }
        public NameAppSelector[] names { get; set; }
    }

    public class NameAppSelector
    {
        public string[] name_synonym { get; set; }
        public string lang { get; set; }
    }
    #endregion AppSelector 
    #region InputSelector 
    public class Availableinput
    {
        public string key { get; set; }
        public NameInputSelector[] names { get; set; }
    }
    public class NameInputSelector
    {
        public string[] name_synonym { get; set; }
        public string lang { get; set; }
    }
    #endregion InputSelector 
    #region ColorSetting
    public class Colortemperaturerange
    {
        public int temperatureMinK { get; set; }
        public int temperatureMaxK { get; set; }
    }
    #endregion ColorSetting
}