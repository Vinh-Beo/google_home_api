using System;

namespace VINHBEO.SmartHome.TP
{
    class ResponseGoogleRefreshSyncModel
    {
        /// <summary>
        /// Version info
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// Response error code
        /// </summary>
        public ResponseGoogleRefreshSyncErrorCode ErrorCode { get; set; }
    }
    enum ResponseGoogleRefreshSyncErrorCode
    {
        OK = 0,
        Unknown
    }
}