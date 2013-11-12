using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using FakeBookAdsApi.Controllers;

namespace FakeBookAdsApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConsigoLerUmAdUser()
        {
            var usersController = new UsersController();
            long accountId = 0;
            string accessToken = "";
            var response = usersController.Read(accountId, accessToken);

            var jsonResponse = JsonConvert.SerializeObject(response);

            AreEqualIgnoreWhiteSpace(readUserResponse, jsonResponse);

        }

        public void AreEqualIgnoreWhiteSpace(string expected, string actual)
        {
            string stringOne = expected;
            string stringTwo = actual;

            string fixedStringOne = Regex.Replace(stringOne, @"\s+", String.Empty);
            string fixedStringTwo = Regex.Replace(stringTwo, @"\s+", String.Empty);

            Assert.AreEqual(fixedStringOne,fixedStringTwo,false);
            
        }

        private const string readUserResponse = @"{ ""data"": [{
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
