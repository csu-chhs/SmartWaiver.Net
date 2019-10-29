using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using SmartWaiver.Net.Objects;

namespace SmartWaiver.Net
{
    public class SmartWaiver : ISmartWaiver
    {
        private string _apiKey;
        private readonly string _apiBase = "https://api.smartwaiver.com";

        public SmartWaiver(string apiKey)
        {
            _apiKey = apiKey;
        }


        public SignedWaiver GetSignedWaiver(string waiverId)
        {
            var client = new RestClient();
            var request = new RestRequest();

            // Set the API Key Header
            request.AddHeader("sw-api-key", _apiKey);


            // Use Rest Sharp
            throw new NotImplementedException();
        }
    }
}
