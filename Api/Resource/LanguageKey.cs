using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Language
{
    public class LanguageKey
    {
        public const string Welcome = "Welcome";
        public const string Account = "Account";
        public const string Control = "Control";

        public const string Device = "Device";
        public const string Scene = "Scene";
        public const string On = "On";
        public const string Off = "Off";

        public const string SorryMaybeiHomeIsNotSupportYou = "SorryMaybeiHomeIsNotSupportYou";
        public const string SorryDoYouLinkedGoogleAccountToiHome = "SorryDoYouLinkedGoogleAccountToiHome";
        public const string IHomeIsNotAllowThisThirdPartyLinkingPleaseEnableItOniHomeApplication = "IHomeIsNotAllowThisThirdPartyLinkingPleaseEnableItOniHomeApplication";
        public const string IHomeCanNotFindCenterHub = "IHomeCanNotFindCenterHub";
        public const string MakeSureEverythingIsSetup = "MakeSureEverythingIsSetup";
        public const string CanIHelpYouWithAnythingElse = "CanIHelpYouWithAnythingElse";
        public const string IHomeCanNotFind = "IHomeCanNotFind";
        public const string IHomeFound = "IHomeFound";
        public const string IsSetTwoOrMoreSceneName = "IsSetTwoOrMoreSceneName";
        public const string MakeSurenameIsSetupOnlyOne = "MakeSurenameIsSetupOnlyOne";
        public const string IHomeIsNotAllowThisThirdPartyLinking = "IHomeIsNotAllowThisThirdPartyLinking";
        public const string IHomeFoundmanyDeviceName = "IHomeFoundmanyDeviceName";
        public const string LetSetNameIsOnlyOneOrControlViaScene = "LetSetNameIsOnlyOneOrControlViaScene";
        public const string TryAgain = "TryAgain";
        public const string PleaseEnableItOniHomeApplication = "PleaseEnableItOniHomeApplication";
        public const string IHomeCanNotFindAnySceneName = "IHomeCanNotFindAnySceneName";

        public const string IsCompletedOK = "IsCompletedOK";
        public const string IsFail = "IsFail";


    }
    public class LanguageEnglighKeywordDetect
    {
        public List<string> Keyword = new List<string>()
        {
            "Scene",
            "Run Scene",
            "Activate",
            "Action"
        };
    }
    public class LanguageVietnameseKeywordDetect
    {
        public List<string> Keyword = new List<string>()
        {
            "Ngữ cảnh",
            "Chạy ngữ cảnh",
            "Kích hoạt"
        };
    }
    public class LanguageCode
    {
        public const string English = "en";
        public const string Vietnamese = "vi";
    }
}