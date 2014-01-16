using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FakeBookAdsApi.Controllers
{
    public class AdsController : ApiController
    {
        [Route("act_{account_id:long}/generatepreviews")]
        public Response GetAdsPreview(long account_id, [FromUri] FacebookAdCreative creative,
                                       [FromUri] FacebookTargetingSpecs targetingSpecs,
                                      string accessToken)
        {
            if (accessToken == null || creative == null)
                return new ErrorResponse();
            return new SuccessResponse(){Result = "<div> preview </div>"};
        }
    }

    public abstract class Response
    {
        
    }

    public class SuccessResponse : Response
    {
        public string Result { get; set; }
    }

    public class SuccessDataResponse : Response
    {
        public string data { get; set; }
    }

    public class ErrorResponse : Response
    {
        public ErrorDetail error { get; set; }
    }

    public class ErrorDetail
    {
        public string message { get; set; }
        public string type { get; set; }
        public string code { get; set; }
    }

    public class FacebookAdCreative
    {
    }

     public class FacebookTargetingSpecs
    {
    }
}