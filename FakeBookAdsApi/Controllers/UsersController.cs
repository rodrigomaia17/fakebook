using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FakeBookAdsApi.Controllers
{
    public class UsersController : ApiController
    {
        [Route("act_{account_id:long}/users")]
        public ReadResponse Get(long account_id,string accessToken)
        {
            return new ReadResponse();
        }
    }

    public class ReadResponse
    {
        public DataReadResponse[] data;

        public ReadResponse()
        {
            data = new DataReadResponse[]
                {
                    new DataReadResponse()
                        {
                            id = 121211,
                            permissions = new int[] {1, 2, 3, 4, 5, 7},
                            role = 1001
                        }
                };
        }
    }

    public class DataReadResponse
    {
        public long id { get; set; }
        public int[] permissions { get; set; }
        public int role { get; set; }
    }
}