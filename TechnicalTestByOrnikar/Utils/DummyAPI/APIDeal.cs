using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestByOrnikar.Utils.DummyAPI
{
    class APIDeal
    {
        public RestResponse Response { get; set; }
        public string StatusCode { get; set; }

        public void NewAPIDealGet(string request)
        {
            var client = new RestClient(request);

            var rqt = new RestRequest();

            Response = client.Execute(rqt);
        }

        public void NewAPIDealPost(string request, Object param)
        {
            var client = new RestClient(request);

            var rqt = new RestRequest("/ressource/", Method.Post);

            rqt.AddJsonBody(JsonConvert.SerializeObject(param));
            
            Response = client.Execute(rqt);
        }

        public void NewAPIDealPut(string request, Object param)
        {
            var client = new RestClient(request);

            var rqt = new RestRequest("/ressource/", Method.Put);

            rqt.AddJsonBody(param);

            Response = client.Execute(rqt);
        }

        public void NewAPIDealDelete(string request)
        {
            var client = new RestClient(request);

            var rqt = new RestRequest("/ressource/", Method.Delete);

            Response = client.Execute(rqt);
        }

    }
}
