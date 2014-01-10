using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeBookAdsApi.Tests
{
    public static class Utils
    {
        public static void AreEqualIgnoreWhiteSpace(string expected, string actual)
        {
            string stringOne = expected;
            string stringTwo = actual;

            string fixedStringOne = Regex.Replace(stringOne, @"\s+", String.Empty);
            string fixedStringTwo = Regex.Replace(stringTwo, @"\s+", String.Empty);

            Assert.AreEqual(fixedStringOne, fixedStringTwo, false);

        }
    }
}
