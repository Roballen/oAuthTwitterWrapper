﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using OAuthTwitterWrapper;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace oAuthTwitterWrapper
{
	public class Authenticate
	{
		public TwitAuthenticateResponse AuthenticateMe(string oAuthConsumerKey, string oAuthConsumerSecret, string oAuthUrl)
		{
			TwitAuthenticateResponse twitAuthResponse = null;
			// Do the Authenticate
			var authHeaderFormat = "Basic {0}";

			var authHeader = string.Format(authHeaderFormat,
										   Convert.ToBase64String(
											   Encoding.UTF8.GetBytes(Uri.EscapeDataString(oAuthConsumerKey) + ":" +

																	  Uri.EscapeDataString((oAuthConsumerSecret)))

											   ));
			var postBody = "grant_type=client_credentials";
			HttpWebRequest authRequest = (HttpWebRequest)WebRequest.Create(oAuthUrl);

			authRequest.Headers.Add("Authorization", authHeader);
			authRequest.Method = "POST";
			authRequest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
			authRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			using (Stream stream = authRequest.GetRequestStream())
			{
				byte[] content = Encoding.ASCII.GetBytes(postBody);
				stream.Write(content, 0, content.Length);
			}
			authRequest.Headers.Add("Accept-Encoding", "gzip");
			WebResponse authResponse = authRequest.GetResponse();
			// deserialize into an object
			using (authResponse)
			{
				using (var reader = new StreamReader(authResponse.GetResponseStream()))
				{
					var objectText = reader.ReadToEnd();
					twitAuthResponse = JsonConvert.DeserializeObject<TwitAuthenticateResponse>(objectText);
				}
			}

			return twitAuthResponse;
		}
	}
}
