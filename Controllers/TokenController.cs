using Microsoft.AspNetCore.Mvc;
using RestSharp;
using Newtonsoft.Json;

namespace Glossary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var client = new RestClient("https://dev-qy4-ihvr.auth0.com/oauth/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"client_id\":\"BnlQstGQUSLc3u9dpkGwEyiT8VFGAhcs\",\"client_secret\":\"EE-95Ob-tm0Gzftzc6jvRIgse3ocoN2rZA7RaplWCTVbq2QaMoCOBfhYiI-Z1rIo\",\"audience\":\"https://glossary.com\",\"grant_type\":\"client_credentials\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return Ok(response.Content.ToString());
        }
    }
}