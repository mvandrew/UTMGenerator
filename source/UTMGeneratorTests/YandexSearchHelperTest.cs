using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UTMGeneratorLibrary;

namespace UTMGeneratorTests
{
    [TestFixture]
    public class YandexSearchHelperTest
    {
        [Test]
        public void TestSiteURL_http()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            yaHelper.SiteURL = @"http:\\site.ru";

            Regex rg = new Regex(@"^http:\\\\");
            if (rg.IsMatch(yaHelper.SiteURL))
                Assert.Pass(@"A simple HTTP test has passed.");
            else
                Assert.Fail(@"A simple HTTP test has failed.");
        }
    }
}
