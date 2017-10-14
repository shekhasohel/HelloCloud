using System;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Linq;

namespace HelloCloud
{
    public static class Functions
    {
        [FunctionName("Hello")]
        public static string Hello([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
                                   HttpRequestMessage req, TraceWriter log)
        {
            var name = req.GetQueryNameValuePairs().First(n => n.Key == "name").Value;
            return $"Hello {name}!";
        }
    }
}
