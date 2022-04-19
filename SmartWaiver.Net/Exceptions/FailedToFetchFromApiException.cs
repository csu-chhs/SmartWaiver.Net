using System;

namespace SmartWaiver.Net.Exceptions
{
    public class FailedToFetchFromAPIException : Exception
    {
        public FailedToFetchFromAPIException() : base()
        {

        }

        public FailedToFetchFromAPIException(string message) : base(message)
        {

        }

        public FailedToFetchFromAPIException(string message, Exception inner) : base(message, inner)
        {
            
        }

        public void AddWebTrace(string webStackTrace)
        {
            Data.Add("Web API Response", webStackTrace);
        }
    }
}