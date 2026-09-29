using System;
using System.Collections.Generic;
using System.Text;

namespace OBSWebsocketDotNet.Communication
{
    /// <summary>
    /// Disconnection information received from the OBS Websocket server
    /// </summary>
    public class ObsDisconnectionInfo
    {
        /// <summary>
        /// Close/Error codes sent by OBS Websocket when closing the connection
        /// </summary>
        public ObsCloseCodes ObsCloseCode { get; private set; }

        /// <summary>
        /// String reason of disconnect
        /// </summary>
        public string DisconnectReason { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obsCloseCode">Close/Error codes sent by OBS Websocket when closing the connection</param>
        /// <param name="disconnectReason">String reason of disconnect</param>
        public ObsDisconnectionInfo(ObsCloseCodes obsCloseCode, string disconnectReason)
        {
            ObsCloseCode = obsCloseCode;
            DisconnectReason = disconnectReason;
        }
    }
}
