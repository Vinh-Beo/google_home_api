using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MANCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string PingAck = "PingAck";
        public const string GetConnectionList = "GetConnectionList";
        public const string UpdConnectionList = "UpdConnectionList";
        public const string GetStartStopServiceTime = "GetStartStopServiceTime";
        public const string UpdStartStopServiceTime = "UpdStartStopServiceTime";
        public const string GetVersionInfo = "GetVersionInfo";
        public const string UpdVersionInfo = "UpdVersionInfo";
        public const string GetLogStatus = "GetLogStatus";
        public const string UpdLogStatus = "UpdLogStatus";
        public const string SetLogStatus = "SetLogStatus";
        public const string GetConnString = "GetConnString";
        public const string UpdConnString = "UpdConnString";
        public const string SetLogPath = "SetLogPath";
        public const string UpdLogPath = "UpdLogPath";
        public const string GetLogPath = "GetLogPath";
        public const string GetCntInfo = "GetCntInfo";
        public const string CloseSock = "CloseSock";
        public const string CloseSockAck = "CloseSockAck";
        public const string AddBlackList = "AddBlackList";
        public const string AddBlackListAck = "AddBlackListAck";
        public const string RemoveBlackList = "RemoveBlackList";
        public const string RemoveBlackListAck = "RemoveBlackListAck";
        public const string RemoveBlackListAll = "RemoveBlackListAll";
        public const string RemoveBlackListAllAck = "RemoveBlackListAllAck";
        public const string GetHWConnInfo = "GetHWConnInfo";
        public const string UpdHWConnInfo = "UpdHWConnInfo";
        public const string GetAPPConnInfo = "GetAPPConnInfo";
        public const string UpdAPPConnInfo = "UpdAPPConnInfo";
        public const string GetUnkConnInfo = "GetUnkConnInfo";
        public const string UpdUnkConnInfo = "UpdUnkConnInfo";
        public const string GetMANConnInfo = "GetMANConnInfo";
        public const string UpdMANConnInfo = "UpdMANConnInfo";
        public const string GetTPConnInfo = "GetTPConnInfo";
        public const string UpdTPConnInfo = "UpdTPConnInfo";
        public const string GetBlackListInfo = "GetBlackListInfo";
        public const string UpdBlackListInfo = "UpdBlackListInfo";
        public const string SetBlackListPath = "SetBlackListPath";
        public const string UpdBlackListPath = "UpdBlackListPath";
        public const string GetBlackListPath = "GetBlackListPath";
        public const string SetBypassControl = "SetBypassControl";
        public const string UpdBypassControl = "UpdBypassControl";
        public const string GetBypassControl = "GetBypassControl";
        public const string SyncHWStatus = "SyncHWStatus";
        public const string SyncHWStatusAck = "SyncHWStatusAck";
        public const string HWBridge = "HWBridge";
        public const string SWBridge = "SWBridge";
        public const string HWMess = "HWMess";
        public const string APPMess = "APPMess";

        // bridge for HW
        public const string FOTACheckHWBridge = "ChkFOTAVer";
        public const string FOTAStopHWBridge = "StopFOTA";
        public const string FOTAStopHWBridgeAck = "StopFOTAAck";

        // bridge for ATC
        public const string FOTACheckATCBridge = "ChkFOTAVer";
        public const string FOTAStopATCBridge = "StopFOTA";
        public const string FOTAStopATCBridgeAck = "StopFOTAAck";

        // handle load new fota to cache
        public const string FOTALoad = "FOTALoad"; // Load fota to cache
        public const string FOTALoadAck = "FOTALoadAck"; // Load fota to cache

        // handle delete fota from cache
        public const string FOTADel = "FOTADel"; // delete fota from cache
        public const string FOTADelAck = "FOTADelAck"; // delete fota from cache

        public const string FOTAStatusDwn = "FOTAStatDwn";
        public const string FOTADwnFinish = "FOTADwnFinish";

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }
    public class HWCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string UpdStatus = "UpdStatus";
        public const string PingAck = "PingAck";
        public const string Ping = "Ping";
        public const string GetTime = "GetTime";
        public const string SetTime = "SetTime";
        public const string DispMess = "DispMess";
        public const string SetStatus = "SetStatus";
        public const string GetStatus = "GetStatus";
        public const string StartIRCmd = "StartCmd";
        public const string StartIRAckCmd = "StartAckCmd";
        public const string ConfigIRCmd = "SCmd";
        public const string ConfigIRAckCmd = "SCmdAc";

        public const string StartDCCmd = "StartCmd";
        public const string StartDCAckCmd = "StartAckCmd";
        public const string APPPingAck = "APPPingAck";
        public const string StartScene = "StartScript";
        public const string FinishSceneAck = "ScriptAck";
        public const string UpdDeviceTotal = "UpdDeviceTotal";
        public const string SetDeviceTotal = "SetDeviceTotal";
        public const string GetDeviceTotal = "GetDeviceTotal";
        // misc
        public const string GetName = "GetName";
        public const string SetName = "SetName";
        public const string GetChName = "GetChName";
        public const string SetChName = "SetChName";

        // for sync some thing
        public const string StartSyncScene = "StSySc";
        public const string RequestSyncScene = "ReSyScBl";
        public const string SyncSceneBlock = "SyScBl";
        public const string SyncSceneFinish = "SyScFi";

        // linker
        public const string StartSyncLinker = "StSyLk";
        public const string RequestSyncLinker = "ReSyLkBl";
        public const string SyncLinkerBlock = "SyLkBl";
        public const string SyncLinkerFinish = "SyLkFi";

        // remind
        public const string RemindSync = "SyRm";
        public const string RemindSyncAck = "SyRmAck";
        public const string RemindDoingUpdate = "DoRmUpd";

        // fota
        // bridge from MAN
        public const string FOTACheck = "CFV";
        public const string FOTAStop = "STF";
        public const string FOTAStopAck = "STFa";
        // HW
        public const string GetFOTAVer = "GFV";
        public const string UpdFOTAVer = "UFV";
        public const string GetFOTAInfo = "GFI";
        public const string UpdFOTAInfo = "UFI";
        public const string GetFOTAData = "GFD";
        public const string UpdFOTAData = "UFD";
        public const string UpdFOTAFinish = "DFF";

        // Fota En
        public const string SetFOTAEn = "SFEn";
        public const string GetFOTAEn = "GFEn";
        public const string UpdFOTAEn = "UFEn";

        // MISC
        public const string UpdDoSceneLinkerHW = "UpdScLk";

        // common command
        #region Set and get HW and FW version
        public const string GetVersion = "GVer";
        public const string SetVersion = "SVer";
        public const string UpdVersion = "UVer";
        #endregion
        #region Get Unique ID
        public const string GetUniqueID = "GUID";
        public const string UpdUniqueID = "UUID";
        #endregion
        #region Repeater on Device
        public const string GetRepeaterStatus = "GRFRep";
        public const string SetRepeaterStatus = "SRFRep";
        public const string UpdRepeaterStatus = "URFRep";
        #endregion
        #region Set Auto Off channel ( for ON OFF device)
        public const string GetAutoOffChannel = "GAtOff";
        public const string SetAutoOffChannel = "SAtOff";
        public const string UpdAutoOffChannel = "UAtOff";
        #endregion
        #region Set and get hold status (for ON OFF device)
        public const string GetHoldStatus = "GHSt";
        public const string SetHoldStatus = "SHSt";
        public const string UpdholdStatus = "UHSt";
        #endregion
        #region Set and get lock button (for ON OFF device)
        public const string GetLockButton = "GLBu";
        public const string SetLockButton = "SLBu";
        public const string UpdLockButton = "ULBu";
        #endregion
        #region Set and get background status
        public const string GetBackgroundStatus = "GBgSt";
        public const string SetBackgroundStatus = "SBgSt";
        public const string UpdBackgroundStatus = "UBgSt";
        #endregion
        #region Set and get buzzer status
        public const string GetBuzzerStatus = "GBuzz";
        public const string SetBuzzerStatus = "SBuzz";
        public const string UpdBuzzerStatus = "UBuzz";
        #endregion
        #region Set and get Update fota enable
        public const string GetUpdFotaEn = "GFEn";
        public const string SetUpdFotaEn = "SFEn";
        public const string UpdUpdFotaEn = "UFEn";
        #endregion
        #region Set and get Center device user pass
        public const string GetCenterUserPass = "GUPass";
        public const string SetCenterUserPass = "SUPass";
        public const string UpdCenterUserPass = "UUPass";
        #endregion
        #region Set and get Center type
        public const string GetCenterType = "GMType";
        public const string SetCenterType = "SMType";
        public const string UpdCenterType = "UMType";
        #endregion
        #region Set and get Center max number
        public const string GetSceneMaxNum = "GSCMaxN";
        public const string UpdSceneMaxNum = "USCMaxN";
        #endregion
        #region Set and get Center GMT
        public const string GetGMT = "GetGMT";
        public const string SetGMT = "SetGMT";
        public const string UpdGMT = "UpdGMT";
        #endregion
        #region Timer channel
        public const string GetTimerChannel = "GTCh";
        public const string SetTimerChannel = "STCh";
        public const string UpdTimerChannel = "UTCh";
        #endregion

        #region ManualAutoMode for PIR
        public const string GetManualAutoMode = "GMAM";
        public const string SetManualAutoMode = "SMAM";
        public const string UpdManualAutoMode = "UMAM";
        #endregion
        #region Light Level for PIR
        public const string GetLightLevelMode = "GLLe";
        public const string SetLightLevelMode = "SLLe";
        public const string UpdLightLevelMode = "ULLe";
        #endregion

        #region Start stop PIR active
        public const string GetTimeActiveDev = "GTAt";
        public const string SetTimeActiveDev = "STAt";
        public const string UpdTimeActiveDev = "UTAt";
        #endregion

        #region Set auto effect active for RGB
        public const string GetAutoEffectActive = "GAEA";// index = 0 is manual mode
        public const string SetAutoEffectActive = "SAEA";// index = 0 is manual mode
        public const string UpdAutoEffectActive = "UAEA";// index = 0 is manual mode
        #endregion

        // Reset
        public const string Reset = "Reset";
        public const string ResetAck = "ResetAck";

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }

    public class APPCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string UpdStatus = "UpdStatus";
        public const string PingAck = "PingAck";
        public const string UpdHWConn = "UpdHWConn";
        public const string Ping = "Ping";
        public const string GetTime = "GetTime";
        public const string SetTime = "SetTime";
        public const string DispMess = "DispMess";
        public const string SetREStatus = "SetStatus";
        public const string SetDIStatus = "SetStatus";
        public const string GetREStatus = "GetStatus";
        public const string SetStatus = "SetStatus";
        public const string GetStatus = "GetStatus";
        public const string UpdREStatus = "UpdStatus";
        public const string UpdDIStatus = "UpdStatus";
        public const string StartIRCmd = "StartCmd";
        public const string StartIRAckCmd = "StartAckCmd";
        public const string ConfigIRCmd = "SCmd";
        public const string ConfigIRAckCmd = "SCmdAc";
        public const string StartDCCmd = "StartCmd";
        public const string StartDCAckCmd = "StartAckCmd";

        public const string APPPing = "APPPing";
        public const string APPPingAck = "APPPingAck";
        public const string StartScene = "StartScript";
        public const string FinishSceneAck = "FinishScriptAck";

        public const string UpdDeviceTotal = "UpdDeviceTotal";
        public const string SetDeviceTotal = "SetDeviceTotal";
        public const string SetDeviceTotalAck = "SetDeviceTotalAck";
        public const string GetDeviceTotal = "GetDeviceTotal";

        // for sync scene
        public const string SyncSceneStart = "SyncSceneStart";
        public const string SyncSceneAck = "SyncSceneAck";// SceneId:Status ( Status: OK, NOK, NoConnect, Timeout)
        public const string SyncSceneFinish = "SyncSceneFinish";

        public const string SyncLinkerStart = "SyncLinkerStart";
        public const string SyncLinkerAck = "SyncLinkerAck";// SceneId:Status ( Status: OK, NOK, NoConnect, Timeout)
        public const string SyncLinkerFinish = "SyncLinkerFinish";

        // sync remind
        public const string RemindSync = "SyncRemind";
        public const string RemindSyncAck = "SyncRemindAck";
        public const string RemindDoingUpdate = "RemindDoingUpd";

        // common command
        #region Set and get HW and FW version
        public const string GetVersion = "GVer";
        public const string SetVersion = "SVer";
        public const string UpdVersion = "UVer";
        #endregion
        #region Get Unique ID
        public const string GetUniqueID = "GUID";
        public const string UpdUniqueID = "UUID";
        #endregion
        #region Repeater on Device
        public const string GetRepeaterStatus = "GRFRep";
        public const string SetRepeaterStatus = "SRFRep";
        public const string UpdRepeaterStatus = "URFRep";
        #endregion
        #region Set Auto Off channel ( for ON OFF device)
        public const string GetAutoOffChannel = "GAtOff";
        public const string SetAutoOffChannel = "SAtOff";
        public const string UpdAutoOffChannel = "UAtOff";
        #endregion
        #region Set and get hold status (for ON OFF device)
        public const string GetHoldStatus = "GHSt";
        public const string SetHoldStatus = "SHSt";
        public const string UpdholdStatus = "UHSt";
        #endregion
        #region Set and get lock button (for ON OFF device)
        public const string GetLockButton = "GLBu";
        public const string SetLockButton = "SLBu";
        public const string UpdLockButton = "ULBu";
        #endregion
        #region Set and get background status
        public const string GetBackgroundStatus = "GBgSt";
        public const string SetBackgroundStatus = "SBgSt";
        public const string UpdBackgroundStatus = "UBgSt";
        #endregion
        #region Set and get buzzer status
        public const string GetBuzzerStatus = "GBuzz";
        public const string SetBuzzerStatus = "SBuzz";
        public const string UpdBuzzerStatus = "UBuzz";
        #endregion
        #region Set and get Update fota enable
        public const string GetUpdFotaEn = "GFEn";
        public const string SetUpdFotaEn = "SFEn";
        public const string UpdUpdFotaEn = "UFEn";
        #endregion
        #region Set and get Center device user pass
        public const string GetCenterUserPass = "GUPass";
        public const string SetCenterUserPass = "SUPass";
        public const string UpdCenterUserPass = "UUPass";
        #endregion
        #region Set and get Center type
        public const string GetCenterType = "GMType";
        public const string SetCenterType = "SMType";
        public const string UpdCenterType = "UMType";
        #endregion
        #region Set and get Center max number
        public const string GetSceneMaxNum = "GSCMaxN";
        public const string UpdSceneMaxNum = "USCMaxN";
        #endregion
        #region Set and get Center GMT
        public const string GetGMT = "GetGMT";
        public const string SetGMT = "SetGMT";
        public const string UpdGMT = "UpdGMT";
        #endregion
        #region Timer channel
        public const string GetTimerChannel = "GTCh";
        public const string SetTimerChannel = "STCh";
        public const string UpdTimerChannel = "UTCh";
        #endregion

        #region Set FOTA En
        // Fota En
        public const string SetFOTAEn = "SFEn";
        public const string GetFOTAEn = "GFEn";
        public const string UpdFOTAEn = "UFEn";
        #endregion

        // Reset
        public const string Reset = "Reset";
        public const string ResetAck = "ResetAck";

        #region ManualAutoMode for PIR
        public const string GetManualAutoMode = "GMAM";
        public const string SetManualAutoMode = "SMAM";
        public const string UpdManualAutoMode = "UMAM";
        #endregion
        #region Light Level for PIR
        public const string GetLightLevelMode = "GLLe";
        public const string SetLightLevelMode = "SLLe";
        public const string UpdLightLevelMode = "ULLe";
        #endregion

        #region Start stop PIR active
        public const string GetTimeActiveDev = "GTAt";
        public const string SetTimeActiveDev = "STAt";
        public const string UpdTimeActiveDev = "UTAt";
        #endregion

        #region Set auto effect active for RGB
        public const string GetAutoEffectActive = "GAEA";// index = 0 is manual mode
        public const string SetAutoEffectActive = "SAEA";// index = 0 is manual mode
        public const string UpdAutoEffectActive = "UAEA";// index = 0 is manual mode
        #endregion

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }
    public class TPCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string UpdStatus = "UpdStatus";
        public const string PingAck = "PingAck";
        public const string UpdHWConn = "UpdHWConn";
        public const string Ping = "Ping";
        public const string GetTime = "GetTime";
        public const string SetTime = "SetTime";
        public const string DispMess = "DispMess";
        public const string SetREStatus = "SetStatus";
        public const string SetDIStatus = "SetStatus";
        public const string GetREStatus = "GetStatus";
        public const string SetStatus = "SetStatus";
        public const string GetStatus = "GetStatus";
        public const string UpdREStatus = "UpdStatus";
        public const string UpdDIStatus = "UpdStatus";
        public const string StartIRCmd = "StartCmd";
        public const string StartIRAckCmd = "StartAckCmd";
        public const string ConfigIRCmd = "SCmd";
        public const string ConfigIRAckCmd = "SCmdAc";
        public const string StartDCCmd = "StartCmd";
        public const string StartDCAckCmd = "StartAckCmd";

        public const string TPPing = "TPPing";
        public const string TPPingAck = "TPPingAck";
        public const string StartScene = "StartScript";
        public const string FinishSceneAck = "FinishScriptAck";

        public const string UpdDeviceTotal = "UpdDeviceTotal";
        public const string SetDeviceTotal = "SetDeviceTotal";
        public const string SetDeviceTotalAck = "SetDeviceTotalAck";
        public const string GetDeviceTotal = "GetDeviceTotal";

        // for sync scene
        public const string SyncSceneStart = "SyncSceneStart";
        public const string SyncSceneAck = "SyncSceneAck";// SceneId:Status ( Status: OK, NOK, NoConnect, Timeout)
        public const string SyncSceneFinish = "SyncSceneFinish";

        public const string SyncLinkerStart = "SyncLinkerStart";
        public const string SyncLinkerAck = "SyncLinkerAck";// SceneId:Status ( Status: OK, NOK, NoConnect, Timeout)
        public const string SyncLinkerFinish = "SyncLinkerFinish";

        // sync remind
        public const string RemindSync = "SyncRemind";
        public const string RemindSyncAck = "SyncRemindAck";
        public const string RemindDoingUpdate = "RemindDoingUpd";

        // common command
        #region Set and get HW and FW version
        public const string GetVersion = "GVer";
        public const string SetVersion = "SVer";
        public const string UpdVersion = "UVer";
        #endregion
        #region Get Unique ID
        public const string GetUniqueID = "GUID";
        public const string UpdUniqueID = "UUID";
        #endregion
        #region Repeater on Device
        public const string GetRepeaterStatus = "GRFRep";
        public const string SetRepeaterStatus = "SRFRep";
        public const string UpdRepeaterStatus = "URFRep";
        #endregion
        #region Set Auto Off channel ( for ON OFF device)
        public const string GetAutoOffChannel = "GAtOff";
        public const string SetAutoOffChannel = "SAtOff";
        public const string UpdAutoOffChannel = "UAtOff";
        #endregion
        #region Set and get hold status (for ON OFF device)
        public const string GetHoldStatus = "GHSt";
        public const string SetHoldStatus = "SHSt";
        public const string UpdholdStatus = "UHSt";
        #endregion
        #region Set and get lock button (for ON OFF device)
        public const string GetLockButton = "GLBu";
        public const string SetLockButton = "SLBu";
        public const string UpdLockButton = "ULBu";
        #endregion
        #region Set and get background status
        public const string GetBackgroundStatus = "GBgSt";
        public const string SetBackgroundStatus = "SBgSt";
        public const string UpdBackgroundStatus = "UBgSt";
        #endregion
        #region Set and get buzzer status
        public const string GetBuzzerStatus = "GBuzz";
        public const string SetBuzzerStatus = "SBuzz";
        public const string UpdBuzzerStatus = "UBuzz";
        #endregion
        #region Set and get Update fota enable
        public const string GetUpdFotaEn = "GFEn";
        public const string SetUpdFotaEn = "SFEn";
        public const string UpdUpdFotaEn = "UFEn";
        #endregion
        #region Set and get Center device user pass
        public const string GetCenterUserPass = "GUPass";
        public const string SetCenterUserPass = "SUPass";
        public const string UpdCenterUserPass = "UUPass";
        #endregion
        #region Set and get Center type
        public const string GetCenterType = "GMType";
        public const string SetCenterType = "SMType";
        public const string UpdCenterType = "UMType";
        #endregion
        #region Set and get Center max number
        public const string GetSceneMaxNum = "GSCMaxN";
        public const string UpdSceneMaxNum = "USCMaxN";
        #endregion
        #region Set and get Center GMT
        public const string GetGMT = "GetGMT";
        public const string SetGMT = "SetGMT";
        public const string UpdGMT = "UpdGMT";
        #endregion
        #region Timer channel
        public const string GetTimerChannel = "GTCh";
        public const string SetTimerChannel = "STCh";
        public const string UpdTimerChannel = "UTCh";
        #endregion

        #region Set FOTA En
        // Fota En
        public const string SetFOTAEn = "SFEn";
        public const string GetFOTAEn = "GFEn";
        public const string UpdFOTAEn = "UFEn";
        #endregion

        // Reset
        public const string Reset = "Reset";
        public const string ResetAck = "ResetAck";

        #region ManualAutoMode for PIR
        public const string GetManualAutoMode = "GMAM";
        public const string SetManualAutoMode = "SMAM";
        public const string UpdManualAutoMode = "UMAM";
        #endregion
        #region Light Level for PIR
        public const string GetLightLevelMode = "GLLe";
        public const string SetLightLevelMode = "SLLe";
        public const string UpdLightLevelMode = "ULLe";
        #endregion

        #region Start stop PIR active
        public const string GetTimeActiveDev = "GTAt";
        public const string SetTimeActiveDev = "STAt";
        public const string UpdTimeActiveDev = "UTAt";
        #endregion

        #region Set auto effect active for RGB
        public const string GetAutoEffectActive = "GAEA";// index = 0 is manual mode
        public const string SetAutoEffectActive = "SAEA";// index = 0 is manual mode
        public const string UpdAutoEffectActive = "UAEA";// index = 0 is manual mode
        #endregion

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }
    public class ATCCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string PingAck = "PingAck";
        public const string Ping = "Ping";
        public const string GetTime = "GetTime";
        public const string SetTime = "SetTime";

        // Working command
        public const string ActiveRequest = "ActReq";
        public const string ActiveAccept = "ActAcc";
        public const string ActiveFinish = "ActFin";
        public const string ActiveDone = "ActDon";

        // fota
        // bridge from MAN
        public const string FOTACheck = "CFV";
        public const string FOTAStop = "STF";
        public const string FOTAStopAck = "STFa";
        // HW
        public const string GetFOTAVer = "GFV";
        public const string UpdFOTAVer = "UFV";
        public const string GetFOTAInfo = "GFI";
        public const string UpdFOTAInfo = "UFI";
        public const string GetFOTAData = "GFD";
        public const string UpdFOTAData = "UFD";
        public const string UpdFOTAFinish = "DFF";

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }

    public class REDCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string PingAck = "PingAck";
        public const string Ping = "Ping";
        public const string GetTime = "GetTime";
        public const string SetTime = "SetTime";

        public const string SendQR = "SendQR";
        public const string SendQRAck = "SendQRAck";

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }

    public class REVCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string PingAck = "PingAck";
        public const string Ping = "Ping";
        public const string GetTime = "GetTime";
        public const string SetTime = "SetTime";

        public const string RecQR = "RecQR";
        public const string RecQRAck = "RecQRAck";

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }
    // some detail code back for APPCmd
    public class APPCmdCodeBack
    {
        public const string OK = "OK";
        public const string NOK = "NOK";
        public const string NoConnect = "NoConnect";
        public const string Timeout = "Timeout";
        public const string WrongFormat = "WrongFormat";
        public const string Unk = "Unk";
    }
    public class oldHWAPPCmdDef
    {
        public const string Connect = "Connect";
        public const string ConnectAccept = "ConnectAccept";
        public const string ConnectDone = "ConnectDone";
        public const string PingAck = "PingAck";
        public const string Ping = "Ping";

        public const string StartScene = "StartScript";
        public const string CheckHWConn = "CheckHWConn";
        public const string UpdHWConn = "UpdHWConn";
        public const string SetREStatus = "SetStatus";
        public const string SetDIStatus = "SetStatus";
        public const string StartIRCmd = "StartCmd";
        public const string StartDCCmd = "StartCmd";
        public const string UpdREStatus = "UpdStatus";

        // for helper deliminate
        public const char Deli1 = ':';// deli level 1
        public const char Deli2 = '$';// deli level 2
        public const char Deli3 = '&';// deli level 3
        public const char Deli4 = '@';// deli level 4
    }
}
