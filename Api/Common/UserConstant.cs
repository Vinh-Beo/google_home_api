namespace Common
{
    public class UserConstant
    {
        public const int Version = 1;
        public const string ConnDB = "";
        public const long TimeTO = (60 * 60);

        public const string PrivateKeySW = "Z8XbNZHV8Yf4N9Ps";

        public const string LogPath = "log";

        public const string True = "true";
        public const string False = "false";

        public const string NoExist = "NoExist";
        public const string Exist = "Exist";

        public const string STORE = "STORE";
        public const string SOLD = "SOLD";


        public const string PublicKey = "XhBpJ7c8Tx34MTat";
        //public const string GoogleAPIKey = "971e94579f244c8327f502fe5576fb55";

        public const string GoogleAssistantClientId = "";
        public const string GoogleAssistantSceneControlIntent = "NameScene";
        public const string GoogleAssistantDeviceControlIntent = "Control";
        public const string GoogleAssistantGetStatusIntent = "GetStatus";
        public const string GoogleAssistantWelcomeIntent = "Default Welcome Intent";


        

    }

    public class AuthorizationConstant
    {
        public const string Authorization = "Authorization";
        public const string Bearer = "Bearer";
    }

    public class LinkConstant
    {
        public const string Scope = "https://www.googleapis.com/auth/homegraph";
        public const string Audience = "https://accounts.google.com/o/oauth2/token";
        public const string Token = "https://accounts.google.com/o/oauth2/token";
        public const string RequestSync = "https://homegraph.googleapis.com/v1/devices:requestSync";
    }

    public class WebRequestConstant
    {
        public const string AuthorHeader = "Authorization";
        public const string PostMethod = "POST";
        public const string ContentTypeUnEncode = "application/x-www-form-urlencoded";
        public const string ContentTypeJson = "application/json";
    }

    public class IntentConstant
    {
        public const string SYNC = "action.devices.SYNC";
        public const string QUERY = "action.devices.QUERY";
        public const string EXECUTE = "action.devices.EXECUTE";
        public const string DISCONNECT = "action.devices.DISCONNECT";
    }

    public class StatusHttpResp
    {
        public const string NotFound = "Oops! Page not found";
        public const string BadRequest = "Your browser sent a request that this server could not understand";
        public const string ExpectationFailed = "Expectation Failed";
        public const string Unauthorized = "Response status code does not indication success";
    }


    public class APIKeyConstant
    {
        public const string TPToken = "";
    }

    public class ThermostatModeCode
    {
        public const string On = "on";
        public const string Off = "off";
        public const string Auto = "auto";
        public const string Cool = "cool";
        public const string Eco = "eco";
        public const string Dry = "dry";
        public const string Heat = "heat";
        public const string HeatCool = "heatcool";
        public const string FanOnly = "fan-only";
        public const string Purifier = "purifier";

    }

    public class ActionDeviceTypes
    {
        public const string Light = "action.devices.types.LIGHT";
        public const string Curtain = "action.devices.types.CURTAIN";
        public const string Door = "action.devices.types.DOOR";
        public const string Scene = "action.devices.types.SCENE";
        public const string TV = "action.devices.types.TV";
        public const string AWNING = "action.devices.types.AWNING";
        public const string Blinds = "action.devices.types.BLINDS";
        public const string REMOTECONTROL = "action.devices.types.REMOTECONTROL";
        public const string Switch = "action.devices.types.SWITCH";
        public const string ThermostStat = "action.devices.types.THERMOSTAT";

    }
    public class ActionDeviceStraits
    {
        public const string OnOff = "action.devices.traits.OnOff";
        public const string FanSpeed = "action.devices.traits.FanSpeed";
        public const string OpenClose = "action.devices.traits.OpenClose";
        public const string Brightness = "action.devices.traits.Brightness";
        public const string ColorSetting = "action.devices.traits.ColorSetting";
        public const string Scene = "action.devices.traits.Scene";
        public const string AppSelector = "action.devices.traits.AppSelector";
        public const string Modes = "action.devices.traits.Modes";
        public const string InputSelector = "action.devices.traits.InputSelector";
        public const string MediaState = "action.devices.traits.MediaState";
        public const string TransportControl = "action.devices.traits.TransportControl";
        public const string Volume = "action.devices.traits.Volume";
        public const string Toggles = "action.devices.traits.Toggles";
        public const string TempSetting = "action.devices.traits.TemperatureSetting";

    }
    public class ActionDeviceCommands
    {
        public const string OnOff = "action.devices.commands.OnOff";
        public const string ActivateScene = "action.devices.commands.ActivateScene";
        public const string AppSelect = "action.devices.commands.appSelect";
        public const string SetFanSpeed = "action.devices.commands.SetFanSpeed";
        public const string OpenClose = "action.devices.commands.OpenClose";
        public const string SetModes = "action.devices.commands.SetModes";
        public const string TherTempSetpoint = "action.devices.commands.ThermostatTemperatureSetpoint";
        public const string TherSetMode = "action.devices.commands.ThermostatSetMode";
        public const string TherTemperSetRange = "action.devices.commands.ThermostatTemperatureSetRange";
        public const string TempRelative = "action.devices.commands.TemperatureRelative";
        public const string BrightnessAbsolute = "action.devices.commands.BrightnessAbsolute";
    }

}