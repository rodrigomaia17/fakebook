#region Usings

using FakeBookAdsApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

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

            Assert.IsNotNull(retorno);
        }

    }
}