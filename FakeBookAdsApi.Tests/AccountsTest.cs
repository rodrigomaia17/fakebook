#region Usings

using FakeBookAdsApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace FakeBookAdsApi.Tests
{
    [TestClass]
    public class AccountsTest
    {
        [TestMethod]
        public void ConsigoRecuperarPixels()
        {
            var adsController = new AccountController();
            var retorno = adsController.GetPixels(111, "token");

            const string expected = @"{""data"": [
      {
         ""id"": ""6008948291788"",
         ""name"": ""Teste pixel 03"",
         ""tag"": ""add_to_cart"",
         ""status"": ""Unverified"",
         ""creator"": ""100690260075287 (Ronaldo Bastos)"",
         ""js_pixel"": ""<!-- Facebook Conversion Code for Teste pixel 03 -->\n\u003Cscript type=\""text/javascript\"">\nvar fb_param = {};\nfb_param.pixel_id = '6008948291788';\nfb_param.value = '0.01';\nfb_param.currency = 'BRL';\n(function(){\n  var fpw = document.createElement('script');\n  fpw.async = true;\n  fpw.src = '//connect.facebook.net/en_US/fp.js';\n  var ref = document.getElementsByTagName('script')[0];\n  ref.parentNode.insertBefore(fpw, ref);\n})();\n\u003C/script>\n\u003Cnoscript>\u003Cimg height=\""1\"" width=\""1\"" alt=\""\"" style=\""display:none\"" src=\""https://www.facebook.com/offsite_event.php?id=6008948291788&amp;value=0.01&amp;currency=BRL\"" /></noscript>""
          }] 
            } ";

            Utils.AreEqualIgnoreWhiteSpace(expected, ((SuccessResponse) retorno).Result);
        }
    }
}