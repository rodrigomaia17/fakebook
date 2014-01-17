#region Usings

using System.Collections.Generic;
using System.Web.Http;

#endregion

namespace FakeBookAdsApi.Controllers
{
    public class AccountController : ApiController
    {
        [Route("act_{account_id:long}/offsitepixels")]
        public Response GetPixels(long account_id, string access_token)
        {
            if (access_token == null || account_id < 1)
                return new ErrorResponse();
            return new RootPixelObject() {data = new List<Datum> {new Datum() {id = "111", name = "teste"}}};
        }


        private class Datum
        {
            public string id { get; set; }
            public string name { get; set; }
            public string tag { get; set; }
            public string status { get; set; }
            public string creator { get; set; }
            public string js_pixel { get; set; }
        }

        private class Paging
        {
            public string next { get; set; }
        }

        private class RootPixelObject : Response
        {
            public List<Datum> data { get; set; }
            public Paging paging { get; set; }
        }
    }
}