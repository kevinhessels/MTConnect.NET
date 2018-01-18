using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MTConnect.Clients
{
    public abstract class MTConnectClientRequest
    {
        /// <summary>
        /// Web proxy information to be used when sending MTConnect request
        /// </summary>
        public IWebProxy Proxy { get; set; }
    }
}
