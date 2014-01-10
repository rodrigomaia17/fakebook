using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FakeBookAdsApi.Controllers
{
    public class AdsController
    {
        [Route("act_{account_id:long}/generatepreviews")]
        public Response GetAdsPreview(long account_id, FacebookAdCreative creative,
                                      FacebookTargetingSpecs targetingSpecs,
                                      string accessToken)
        {
            return new Response() {Result = "<div> preview </div>"};
        }
    }

    public class Response
    {
        public string Result { get; set; }
    }

    public class FacebookAdCreative
    {
    }

     public class FacebookTargetingSpecs
    {
    }
}