#define __LOG
#define __USING_LOAD_DEVICE_CHANNEL_LIST

using Api.Common;
using Api.Helper;
using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc;
using TypeBuilderNamespace;

namespace Api.Controllers
{
    public class HomeGraphController : ApiController
    {
        private string connDecrypt = "";
        private const long timeTO = (60 * 60 * 2);
        public object Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/HomeGraph
        public object Post([FromBody]object value)
        {
            bool _retval = false;
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
#if (__LOG)
                Base.LOG("\r\n*****HomeGraph*****");
#endif
                //B1: Get header GG response
                string _inputStr = value.ToString();
                string authCodeHeader = Request.Headers.GetValues(AuthorizationConstant.Authorization).FirstOrDefault().ToString();
                if (!authCodeHeader.Contains(AuthorizationConstant.Bearer))
                {
#if (__LOG)
                    Base.LOG("Wrong header");
#endif
                    _retval = false;
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound, StatusHttpResp.NotFound);
                }
                authCodeHeader = authCodeHeader.Replace(AuthorizationConstant.Bearer, "").Trim();

#if (__LOG)
                Base.LOG("HomeGraph Header: " + authCodeHeader);
                Base.LOG("HomeGraph Input:\r\n" + _inputStr);

                string _authorCode = authCodeHeader;

                try
                {
#endif
                    Api.Models.Request.Sync.RequestSyncModel _inputRequestSync = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.Request.Sync.RequestSyncModel>(_inputStr);
                    Api.Models.Request.Query.RequestQueryModel _inputRequestQuery = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.Request.Query.RequestQueryModel>(_inputStr);
                    Api.Models.Request.Execute.RequestExecuteModel _inputRequestExec = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.Request.Execute.RequestExecuteModel>(_inputStr);
                    Api.Models.Request.Disconnect.RequestDisconnectModel _inputRequestDis = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.Request.Disconnect.RequestDisconnectModel>(_inputStr);

                    #region SYNC
                    if (_inputRequestSync != null &&
                         _inputRequestSync.inputs != null &&
                         _inputRequestSync.inputs.Length > 0 &&
                         _inputRequestSync.inputs[0] != null &&
                         _inputRequestSync.inputs[0].intent != null &&
                         _inputRequestSync.inputs[0].intent == IntentConstant.SYNC)
                    {
                        // do some thing
                        Api.Models.Response.Sync.ResponseSyncModel _response = new Api.Models.Response.Sync.ResponseSyncModel();

                        _response.requestId = _inputRequestSync.requestId;
                        _response.payload = new Models.Response.Sync.Payload();
                        _response.payload.agentUserId = _authorCode;
#if (__LOG)
                        Base.LOG("AgentUserId: " + _response.payload.agentUserId.ToString() + "," + "  API key: " + _authorCode);
#endif
                        Models.Response.Sync.DeviceOnOff _dv = new Models.Response.Sync.DeviceOnOff()
                        {
                            id = "",
                            type = ActionDeviceTypes.Light,
                            traits = new string[]
                            {
                            ActionDeviceStraits.OnOff
                            },
                            name = new Models.Response.Sync.Name()
                            {
                                defaultNames = new string[] { "" },
                                name = "",
                                nicknames = new string[] { "" }
                            },
                            willReportState = true,
                            deviceInfo = new Models.Response.Sync.Deviceinfo()
                            {
                                manufacturer = "VINHBEO",
                                hwVersion = "5.1",
                                model = "",
                                swVersion = "1.0"
                            },
                            customData = new Models.Response.Sync.Customdata()
                            {
                                barValue = true,
                                bazValue = "RE",
                                fooValue = 74
                            },
                            attributes = new Models.Response.Sync.AttributesOnOff()
                            {
                                commandOnlyOnOff = true
                            }
                        };
                        _response.payload.devices[0] = _dv;
#if (__LOG)
                        Base.LOG("Return: " + Newtonsoft.Json.JsonConvert.SerializeObject(_response).ToString());
#endif
                        _retval = true;
                        return Json(_response);
                    }
                    #region QUERY
                    else
                    if (_inputRequestQuery != null &&
                        _inputRequestQuery.inputs != null &&
                        _inputRequestQuery.inputs.Length > 0 &&
                        _inputRequestQuery.inputs[0] != null &&
                        _inputRequestQuery.inputs[0].intent != null &&
                        _inputRequestQuery.inputs[0].intent == IntentConstant.QUERY)
                    {
                        // Get Google response
                    }
                    #endregion
                    #region EXECUTE
                    else
                    if (_inputRequestExec != null &&
                        _inputRequestExec.inputs != null &&
                        _inputRequestExec.inputs.Length > 0 &&
                        _inputRequestExec.inputs[0] != null &&
                        _inputRequestExec.inputs[0].intent != null &&
                        _inputRequestExec.inputs[0].intent == IntentConstant.EXECUTE)
                    {
                        // Get info
                        // Get nesscessary info
                        string _responseId = _inputRequestExec.requestId;
                        // Checking database to make full info
                        List<Api.Models.Response.Execute.ControlDvChannel> _requestDeviceCanDolst = new List<Api.Models.Response.Execute.ControlDvChannel>();
                        foreach (Api.Models.Request.Execute.Input item in _inputRequestExec.inputs)
                        {
                            // B1: capture device id and check authorize
                            // B2: depend on device type to analyst command require
                            // B3: base on param to do this command
                            // B4: summarize all of info list code to do
                            foreach (Api.Models.Request.Execute.Command cmd in item.payload.commands)
                            {
                                foreach (Api.Models.Request.Execute.Device _dv in cmd.devices)
                                {
                                    // B1: capture device id and check authorize
                                    if (string.IsNullOrWhiteSpace(_dv.id))
                                    {
                                        continue;
                                    }
                                    // Get reponse from Google and return;
                                }
                            }
                        }
                    }
                    #endregion
                    #region DISCONNECT
                    if (_inputRequestDis != null &&
                       _inputRequestDis.inputs != null &&
                       _inputRequestDis.inputs.Length > 0 &&
                       _inputRequestDis.inputs[0] != null &&
                       _inputRequestDis.inputs[0].intent != null &&
                       _inputRequestDis.inputs[0].intent == IntentConstant.DISCONNECT)
                    {
                        Api.Models.Response.Disconnect.ReponseDisconnectModel _resp = new Api.Models.Response.Disconnect.ReponseDisconnectModel();

#if (__LOG)
                        Base.LOG("Disconnect: " + Newtonsoft.Json.JsonConvert.SerializeObject(_resp).ToString());
#endif
                        _retval = true;
                        return Newtonsoft.Json.JsonConvert.SerializeObject(_resp).ToString();
                    }
                    #endregion
                }
                catch (Exception e)
                {
                    _retval = false;
#if (__LOG)
                    Base.LOG("HomeGraph Sync Error: " + e.ToString());
#endif
                }
            }
            catch (Exception e)
            {
#if (__LOG)
                _retval = false;
                Base.LOG("HomeGraph Error: " + e.ToString());
#endif
            }
            return Json(_retval);
        }

        // PUT: api/HomeGraph/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HomeGraph/5
        public void Delete(int id)
        {
        }

        public long DateTimeToUnixTime(DateTime t)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long)(t - sTime).TotalSeconds;
        }

        public void RequestSync(string _agentUserId)
        {
            try
            {
                #region JWT
                string jwtToken = "";
                string _exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"file:\", "");

                using (StreamReader reader = new StreamReader(_exePath + @"\ACISserviceaccount.json"))
                {
                    string inputKey = reader.ReadToEnd();
                    Api.Models.ReportState.ServiceAccountKey _accountKey = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.ReportState.ServiceAccountKey>(inputKey);
                    var utc0 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                    var issueTime = DateTime.UtcNow;// UtcNow chu khong phai Now
                    var iatTime = (int)issueTime.Subtract(utc0).TotalSeconds;
                    var expTime = (int)issueTime.AddMinutes(60).Subtract(utc0).TotalSeconds; // Expiration time is up to 1 hour, but lets play on safe side
                    string scope = LinkConstant.Scope;
                    string audience = LinkConstant.Audience;

                    var payload = new Dictionary<string, object>()
                    {
                        { "iss", _accountKey.client_email },
                        { "scope", scope},
                        { "aud", audience },
                        { "iat", iatTime},
                        { "exp", expTime }
                    };
                    string tempKey = "";
                    if (_accountKey.private_key.StartsWith("-----BEGIN PRIVATE KEY-----\n"))
                    {
                        _accountKey.private_key = _accountKey.private_key.Replace("-----BEGIN PRIVATE KEY-----\n", "").TrimStart();

                        if (_accountKey.private_key.EndsWith("\n-----END PRIVATE KEY-----\n"))
                        {
                            tempKey = _accountKey.private_key.Replace("\n-----END PRIVATE KEY-----\n", "").TrimEnd();

                            byte[] privateKeyByte = Convert.FromBase64String(tempKey);

                            jwtToken = Common.JsonWebToken.Encode(payload, privateKeyByte, Common.JwtHashAlgorithm.RS256);
                        }
                    }
                    if (string.IsNullOrEmpty(jwtToken))
                    {
                        return;
                    }
#if (__LOG)
                    Base.LOG("\r\nJWT :");
                    Base.LOG(jwtToken);
#endif
                }
                #endregion JWT
                #region Make request 
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(LinkConstant.Token);
                httpWebRequest.ContentType = WebRequestConstant.ContentTypeUnEncode;
                httpWebRequest.Method = WebRequestConstant.PostMethod;
                #region Body
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var postData = "grant_type=" + Uri.EscapeDataString("urn:ietf:params:oauth:grant-type:jwt-bearer") + "&assertion=" + Uri.EscapeDataString(jwtToken);
                    streamWriter.Write(postData);
#if (__LOG)
                    Base.LOG("\r\nMake request after creating JWT");
                    Base.LOG("Body :");
                    Base.LOG(postData);
#endif
                }
                #endregion Body
                #endregion  Make request 
                #region Get Response
                string accessToken;
                string tokenType;
                int expiresIn;
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Api.Models.ReportState.GoogleAccessToken token = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.ReportState.GoogleAccessToken>(responseText);
                    accessToken = token.access_token;
                    tokenType = token.token_type;
                    expiresIn = token.expires_in;

#if (__LOG)
                    string _input = string.Format("{0}: {1}\r\n" +
                        "{2}: {3}\r\n" +
                        "{4}: {5}\r\n",
                         nameof(accessToken), accessToken,
                         nameof(tokenType), tokenType,
                         nameof(expiresIn), expiresIn);
                    Base.LOG("\r\nGet Google accessToken:");
                    Base.LOG("Google accessToken:");
                    Base.LOG(_input);
#endif
                }
                #endregion Get Response
                #region Call Homegraph API
                #region Make request
                var request = (HttpWebRequest)WebRequest.Create("https://homegraph.googleapis.com/v1/devices:requestSync");
                request.Method = WebRequestConstant.PostMethod;
                request.ContentType = WebRequestConstant.ContentTypeJson;
                request.Headers.Add(WebRequestConstant.AuthorHeader, "Bearer " + accessToken);

#if (__LOG)
                string input = string.Format("{0}: {1}\r\n" +
                                             "{2}: {3}\r\n",
                                             nameof(request.ContentType), request.ContentType,
                                             nameof(request.Headers), request.Headers);
                Base.LOG("\r\nCall Homegraph API");
                Base.LOG("Make request");
                Base.LOG(input);
#endif

                #region Body
                using (var stream = new StreamWriter(request.GetRequestStream()))
                {
                    var getID = new
                    {
                        agentUserId = _agentUserId
                    };
                    var json = Newtonsoft.Json.JsonConvert.DeserializeObject(Newtonsoft.Json.JsonConvert.SerializeObject(getID));
#if (__LOG)
                    Base.LOG("JSON");
                    Base.LOG(json.ToString());
#endif
                    stream.Write(json);
                }
                #endregion Body
                #endregion Make request
                #region Get Response
                var response = (HttpWebResponse)request.GetResponse();
                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var _retval = stream.ReadToEnd();
#if (__LOG)
                    Base.LOG("\r\nGet response:");
                    Base.LOG(_retval);
#endif
                }

                #endregion Get Response
                #endregion Call Homegraph API
                #endregion
            }
            catch (WebException ex)
            {
                StreamReader sr = new StreamReader(ex.Response.GetResponseStream());
                Base.LOG("\r\nError");
                Base.LOG(sr.ReadToEnd());
                throw;
            }

        }

        public void ReportState(string _deviceId, string _agentUserId, int _state, string _cmd, string _inputState)
        {
            try
            {
                #region JWT
                string jwtToken = "";
                string _exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"file:\", "");
                using (StreamReader reader = new StreamReader(_exePath + @"\ACISserviceaccount.json"))
                {
                    string inputKey = reader.ReadToEnd();
                    Api.Models.ReportState.ServiceAccountKey accountKey = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.ReportState.ServiceAccountKey>(inputKey);
                    var utc0 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                    var issueTime = DateTime.UtcNow;// UtcNow chu khong phai Now
                    var iatTime = (int)issueTime.Subtract(utc0).TotalSeconds;
                    var expTime = (int)issueTime.AddMinutes(60).Subtract(utc0).TotalSeconds; // Expiration time is up to 1 hour, but lets play on safe side
                    string scope = "https://www.googleapis.com/auth/homegraph";
                    string audience = "https://accounts.google.com/o/oauth2/token";

                    var payload = new Dictionary<string, object>()
                    {
                            { "iss", accountKey.client_email },
                            { "scope", scope},
                            { "aud", audience },
                            { "iat", iatTime},
                            { "exp", expTime }
                    };
                    string tempKey = "";
                    if (accountKey.private_key.StartsWith("-----BEGIN PRIVATE KEY-----\n"))
                    {
                        accountKey.private_key = accountKey.private_key.Replace("-----BEGIN PRIVATE KEY-----\n", "").TrimStart();

                        if (accountKey.private_key.EndsWith("\n-----END PRIVATE KEY-----\n"))
                        {
                            tempKey = accountKey.private_key.Replace("\n-----END PRIVATE KEY-----\n", "").TrimEnd();

                            byte[] privateKeyByte = Convert.FromBase64String(tempKey);

                            jwtToken = Common.JsonWebToken.Encode(payload, privateKeyByte, Common.JwtHashAlgorithm.RS256);
                        }
                    }

#if (__LOG)
                    Base.LOG("\r\nJWT:");
                    Base.LOG(jwtToken);
#endif
                }
                #endregion
                #region Make request to  get access token
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Method = "POST";

                #region Body
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var postData = "grant_type=" + Uri.EscapeDataString("urn:ietf:params:oauth:grant-type:jwt-bearer") + "&assertion=" + Uri.EscapeDataString(jwtToken);
                    streamWriter.Write(postData);
#if (__LOG)
                    Base.LOG("\r\nMake quest after creating JWT");
                    Base.LOG("Body request:");
                    Base.LOG(postData);
#endif
                }
                #endregion Body
                #endregion Make request to  get access token
                #region Get Response Access Token
                string accessToken;
                string tokenType;
                int expiresIn;
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Api.Models.ReportState.GoogleAccessToken token = Newtonsoft.Json.JsonConvert.DeserializeObject<Api.Models.ReportState.GoogleAccessToken>(responseText);
                    accessToken = token.access_token;
                    tokenType = token.token_type;
                    expiresIn = token.expires_in;


                    string _input = string.Format("{0}: {1}\r\n" +
                        "{2}: {3}\r\n" +
                        "{4}: {5}\r\n",
                         nameof(accessToken), accessToken,
                         nameof(tokenType), tokenType,
                         nameof(expiresIn), expiresIn);
                    Base.LOG("\r\n Get Google accesstoken");
                    Base.LOG("AccessToken");
                    Base.LOG(_input);
                }
                #endregion Get Response Access Token
                #region Call Homegraph API
                #region Make request
                var request = (HttpWebRequest)WebRequest.Create("https://homegraph.googleapis.com/v1/devices:reportStateAndNotification");
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", "Bearer " + accessToken);
                #region Body
                // Create body request
                #endregion
                #endregion
                #region Get response

                var response = (HttpWebResponse)request.GetResponse();
                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var _retval = stream.ReadToEnd();
                    Base.LOG("Get reponse");
                    Base.LOG(_retval);
                }
                #endregion
                #endregion
            }
            catch (WebException e)
            {

#if (__LOG)
                Base.LOG(e.ToString());
#endif
                throw;
            }
        }
    }

    class MCEServerAddClass
    {
        public string MCELst;
        public string ServerAdd;
    }
}
