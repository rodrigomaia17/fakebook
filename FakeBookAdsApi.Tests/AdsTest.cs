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

            Assert.IsInstanceOfType(retorno,typeof(SuccessResponse));
            Assert.IsNotNull(((SuccessResponse)retorno).Result);
        }

        [TestMethod]
        public void NaoConsigoGerarSemToken()
        {
            var adsController = new AdsController();
            var retorno = adsController.GetAdsPreview(12312312, new FacebookAdCreative(), new FacebookTargetingSpecs(), null);

            Assert.IsInstanceOfType(retorno,typeof(ErrorResponse));
        }

        [TestMethod]
        public void NaoConsigoGerarSemAdCreative()
        {
            var adsController = new AdsController();
            var retorno = adsController.GetAdsPreview(123123,null, new FacebookTargetingSpecs(),"aaa");

            Assert.IsInstanceOfType(retorno, typeof(ErrorResponse));
        }
    }
}
