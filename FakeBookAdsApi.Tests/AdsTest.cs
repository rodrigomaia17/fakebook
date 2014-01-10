using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBookAdsApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace FakeBookAdsApi.Tests
{
    [TestClass]
    public class AdsTest
    {
        [TestMethod]
        public void ConsigoGerarUmPreview()
        {
            var adsController = new AdsController();
            var retorno = adsController.GetAdsPreview(12312312, new FacebookAdCreative(), new FacebookTargetingSpecs(), "asdasd");

            Assert.IsNotNull(retorno.Result);
        }

        [TestMethod]
        public void NaoConsigoGerarSemToken()
        {
            var adsController = new AdsController();
            var retorno = adsController.GetAdsPreview(12312312, new FacebookAdCreative(), new FacebookTargetingSpecs(), null);
            
            const string expected = "{\"error\": {\"message\": \"An access token is required to request this resource.\",\"type\": \"OAuthException\",\"code\": 104}}";

            Utils.AreEqualIgnoreWhiteSpace(expected,JsonConvert.SerializeObject(retorno));

        }
    }
}
