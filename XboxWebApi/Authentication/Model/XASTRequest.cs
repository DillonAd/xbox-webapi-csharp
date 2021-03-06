﻿using System;
using Newtonsoft.Json;

namespace XboxWebApi.Authentication.Model
{
    public class XASTRequest
    {
		public string RelyingParty { get; internal set; }
        public string TokenType { get; internal set; }
		public XASTProperties Properties { get; internal set; }

		public XASTRequest(AccessToken accessToken, DeviceToken deviceToken,
		                   string relyingParty = "http://auth.xboxlive.com",
                           string tokenType = "JWT",
                           string authMethod = "RPS",
                           string siteName = "user.auth.xboxlive.com")
        {
			RelyingParty = relyingParty;
			TokenType = tokenType;
			Properties = new XASTProperties()
			{
				AuthMethod = authMethod,
				DeviceToken = deviceToken.Jwt,
                SiteName = siteName,
				RpsTicket = accessToken.Jwt            
			};
        }
    }

	public class XASTProperties
    {
        public string AuthMethod { get; internal set; }
        public string DeviceToken { get; internal set; }
        public string SiteName { get; internal set; }
        public string RpsTicket { get; internal set; }
    }
}
