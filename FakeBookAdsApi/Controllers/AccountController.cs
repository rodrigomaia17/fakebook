#region Usings

using System.Web.Http;

#endregion

namespace FakeBookAdsApi.Controllers
{
    public class AccountController : ApiController
    {
        [Route("act_{account_id:long}/offsitepixels")]
        public Response GetPixels(long account_id, string accessToken)
        {
            if (accessToken == null)
                return new ErrorResponse();
            return new SuccessResponse()
            {
                Result = @"{""data"": [
      {
         ""id"": ""6008948291788"",
         ""name"": ""Teste pixel 03"",
         ""tag"": ""add_to_cart"",
         ""status"": ""Unverified"",
         ""creator"": ""100690260075287 (Ronaldo Bastos)"",
         ""js_pixel"": ""<!-- Facebook Conversion Code for Teste pixel 03 -->\n\u003Cscript type=\""text/javascript\"">\nvar fb_param = {};\nfb_param.pixel_id = '6008948291788';\nfb_param.value = '0.01';\nfb_param.currency = 'BRL';\n(function(){\n  var fpw = document.createElement('script');\n  fpw.async = true;\n  fpw.src = '//connect.facebook.net/en_US/fp.js';\n  var ref = document.getElementsByTagName('script')[0];\n  ref.parentNode.insertBefore(fpw, ref);\n})();\n\u003C/script>\n\u003Cnoscript>\u003Cimg height=\""1\"" width=\""1\"" alt=\""\"" style=\""display:none\"" src=\""https://www.facebook.com/offsite_event.php?id=6008948291788&amp;value=0.01&amp;currency=BRL\"" /></noscript>""
          }] 
            } "
            };
        }
    }
}