﻿using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using SmartWaiver.Net.Interfaces;
using SmartWaiver.Net.Clients;

namespace SmartWaiver.Net
{
    public class SmartWaiver : ISmartWaiver
    {
        private string _apiKey;
        private readonly string _apiBase = "https://api.smartwaiver.com";
        private readonly string _waiverBase = "https://waiver.smartwaiver.com/";

        public IWaiverClient Waiver {get;}
        
        public SmartWaiver(string apiKey)
        {
            _apiKey = apiKey;
            var client = new RestClient(_apiBase);
            client.AddDefaultHeader("sw-api-key", _apiKey);
            client.UseNewtonsoftJson();
            Waiver = new WaiverClient(client, _waiverBase);
        }
    }
}
