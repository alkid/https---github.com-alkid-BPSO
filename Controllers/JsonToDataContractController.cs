using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RNA.Controllers
{
    public class JsonToDataContractController : ApiController
    {
        // POST api/<controller>
        public HttpResponseMessage Post(HttpRequestMessage value)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("I'll be running on an Azure Web Site!");
            return response;
        }

        public HttpResponseMessage Get()
        {
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("I'll be running on an Azure Web Site!");
            return response;
        }
    }
}