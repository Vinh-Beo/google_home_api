#define __LOG
using Api.Common;
using Api.Helper;
using Api.Models.Oauth2;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        private string connDecrypt = "";
        private const long timeTO = (60 * 60 * 24);
        
        public ActionResult Portal()
        {

            #region GET DATA
            Session["ResponseType"] = Request.QueryString["response_type"];
            Session["ClientID"] = Request.QueryString["client_id"];
            Session["State"] = Request.QueryString["state"];
            Session["UserLocale"] = Request.QueryString["user_locale"];
            Session["RedirectUri"] = Request.QueryString["redirect_uri"];
            #endregion

            #region LOG
#if (__LOG)
            string _input = string.Format("{0}: {1}\r\n" +
                "{2}: {3}\r\n" +
                "{4}: {5}\r\n" +
                "{6}: {7}\r\n" +
                "{8}: {9}",
                 "ResponseType: ", Session["ResponseType"],
                 "ClientId: ", Session["ClientID"],
                 "RedirectUri: ", Session["RedirectUri"],
                 "State: ", Session["State"],
                 "UserLocale: ", Session["UserLocale"]);
            Base.LOG("\r\nPortal");
            Base.LOG(_input);
#endif
            #endregion
            return View();
        }
        /*LOGIN*/
        [HttpPost]
        public ActionResult Login(string MasterAccount, string ControlAccount, string Password)
        {
            bool _retval = false;
            try
            {
#if (__LOG)
                Base.LOG("*****Login*****");
#endif
                // Checking info before do
                if (string.IsNullOrEmpty(MasterAccount))
                {
#if (__LOG)
                    Base.LOG("\r\nError: Forgot input master account!!!");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound,StatusHttpResp.NotFound);
                }
                MasterAccount = MasterAccount.Trim();
                if (string.IsNullOrEmpty(ControlAccount))
                {
#if (__LOG)
                    Base.LOG("\r\nError: Forgot input control account!!!");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                }
                ControlAccount = ControlAccount.Trim();
                if (string.IsNullOrEmpty(Password))
                {
#if (__LOG)
                    Base.LOG("\r\nError: Forgot input password!!!");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                }
                Password = Password.Trim();
                // checking special character
                if (Base.HasSpecicalChar(MasterAccount))
                {
#if (__LOG)
                    Base.LOG("\r\nError: Input special character!!!");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                }
                if (Base.HasSpecicalChar(ControlAccount))
                {
#if (__LOG)
                    Base.LOG("\r\nError: Input special character!!!");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                }
                if (Base.HasPasswordSpecicalChar(Password))
                {
#if (__LOG)
                    Base.LOG("\r\nError: Input special character for password!!!");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                }

                bool _loginOK = true;
                string CerApiKey = "";
                if (_loginOK)
                {
                    #region REDIRECT TO GOOGLE
                    _retval = false;
                    string redirectURL = String.Format("{0}?code={1}&state={2}", Session["RedirectUri"], CerApiKey, Session["State"]);
#if (__LOG)
                    Base.LOG("Redirect");
                    Base.LOG(redirectURL);
#endif
                    return Redirect(redirectURL);
                    #endregion
                }
            }
            catch (Exception e)
            {
#if (__LOG)
                Base.LOG("Login error: " + e.ToString());
#endif
                _retval = false;
                return new HttpStatusCodeResult(HttpStatusCode.ExpectationFailed,StatusHttpResp.ExpectationFailed);
            }
            return Json(_retval);
        }

        /*TOKEN*/
        [HttpPost]
        public ActionResult Token()
        {
            bool _retval = false;

            try
            {
                #region GET DATA
                string grantType = Request.Form["grant_type"];
                string clientId = Request.Form["client_id"];
                string clientSecret = Request.Form["client_secret"];
                string code = Request.Form["code"];
                #endregion

                #region LOG
#if (__LOG)
                string _input = string.Format("{0}: {1}\r\n" +
                    "{2}: {3}\r\n" +
                    "{4}: {5}\r\n" +
                    "{6}: {7}",
                     nameof(grantType), grantType,
                     nameof(clientId), clientId,
                     nameof(clientSecret), clientSecret,
                     nameof(code), code);
                Base.LOG("\r\n*****AccessToken*****");
                Base.LOG(_input);
#endif
                #endregion

                switch (grantType)
                {
                    case "authorization_code":
                        {
                            #region CHECK 
                            if (string.IsNullOrEmpty(clientId))
                            {
#if (__LOG)
                                Base.LOG("\r\nClient id is null");
#endif
                                _retval = false;
                                return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                            }
                            clientId = clientId.Trim();
                            if (string.IsNullOrEmpty(clientSecret))
                            {
#if (__LOG)
                                Base.LOG("\r\nClient secrect is null");
#endif
                                _retval = false;
                                return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                            }
                            clientSecret = clientSecret.Trim();
                            
                            Crypto crypto = new Crypto();
                            string __accessToken = crypto.CalculateMD5Hash(Convert.ToBase64String(crypto.Encrypt(code + crypto.GenKey(), Encoding.ASCII.GetBytes(APIKeyConstant.TPToken))));
                            string __refreshToken = crypto.CalculateMD5Hash(Convert.ToBase64String(crypto.Encrypt(code+ crypto.GenKey(), Encoding.ASCII.GetBytes(APIKeyConstant.TPToken))));
#if (__LOG)
                            Base.LOG("Access [" + __accessToken.Length.ToString() + "]: " + __accessToken.ToString());
                            Base.LOG("Refresh [" + __refreshToken.Length.ToString() + "]: " + __refreshToken.ToString());

#endif
                            

                            #endregion
                            #region GET ACCESS TOKEN
                            double _expired = 360;
#if (__LOG)
                            Base.LOG("expired: " + _expired.ToString());
#endif
                            Api.Models.Oauth2.TokenModel accessToken = new Api.Models.Oauth2.TokenModel()
                            {
                                token_type = "Bearer",
                                access_token = __accessToken,
                                refresh_token = __refreshToken,
                                expires_in = _expired
                            };

                            return Json(accessToken);
                            #endregion
                        }

                    #region REFESH TOKEN
                    case "refresh_token":
                        {

                            #region GET DATA
                            string refresh_token = Request.Form["refresh_token"];
                            #endregion
                            #region LOG
#if (__LOG)
                            _input = string.Format("{0}: {1}\r\n" +
                               "{2}: {3}\r\n" +
                               "{4}: {5}\r\n" +
                                nameof(clientId), clientId,
                                nameof(clientSecret), clientSecret,
                                nameof(refresh_token), refresh_token);
                            Base.LOG("\r\nRefreshToken\r\n");
                            Base.LOG(_input);
#endif
                            #endregion
                            #region CHECk
                            if (string.IsNullOrEmpty(clientId))
                            {
#if (__LOG)
                                Base.LOG("\r\nClient id is null");
#endif
                                _retval = false;
                                return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                            }
                            if (string.IsNullOrEmpty(clientSecret))
                            {
#if (__LOG)
                                Base.LOG("\r\nClient secret is null");
#endif
                                _retval = false;
                                return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                            }
                            if (string.IsNullOrEmpty(refresh_token))
                            {
#if (__LOG)
                                Base.LOG("\r\nRefresh token is null");
#endif
                                _retval = false;
                                return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                            }
                            
                            string _accessToken = "";
                            double _expired = 360;
                            #endregion
                            #region REFRESH TOKEN
                            Api.Models.Oauth2.TokenModel refeshToken = new Api.Models.Oauth2.TokenModel()
                            {
                                token_type = "Bearer",
                                access_token = _accessToken,
                                expires_in = _expired
                            };
                            return Json(refeshToken);
                            #endregion
                        }
                    #endregion
                    default:
                        return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, StatusHttpResp.Unauthorized);
                }
            }
            catch (Exception ex)
            {
#if (__LOG)
                Base.LOG("Token: " + ex.ToString());
#endif
                return new HttpStatusCodeResult(HttpStatusCode.ExpectationFailed, StatusHttpResp.ExpectationFailed);
            }
        }
    }
}
