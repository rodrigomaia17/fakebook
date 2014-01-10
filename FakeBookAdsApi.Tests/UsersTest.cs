using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using FakeBookAdsApi.Controllers;

namespace FakeBookAdsApi.Tests
{
    [TestClass]
    public class UsersTest
    {
        [TestMethod]
        public void ConsigoLerUmAdUser()
        {
            var usersController = new UsersController();
            const long accountId = 0;
            const string accessToken = "";
            var response = usersController.Get(accountId, accessToken);

            var jsonResponse = JsonConvert.SerializeObject(response);

            Utils.AreEqualIgnoreWhiteSpace(ReadUserResponse, jsonResponse);

        }

    

        private const string ReadUserResponse = @"{ ""data"": [{
                ""id"": 121211,
                ""permissions"": [
                 1,
                                    2,
                                    3,
                                    4,
                                    5,
                                    7
                                  ],
                                  ""role"": 1001
                                }
                              ]
                            }";
    }
}
