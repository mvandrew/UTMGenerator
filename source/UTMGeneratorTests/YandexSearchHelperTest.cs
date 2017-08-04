﻿using NUnit.Framework;
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
            yaHelper.SiteURL = @"http://site.ru";

            Regex rg = new Regex(@"^http:\/\/");
            if (rg.IsMatch(yaHelper.SiteURL))
                Assert.Pass(@"A simple HTTP test has passed.");
            else
                Assert.Fail(@"A simple HTTP test has failed.");
        }

        [Test]
        public void TestSiteURL_https()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            yaHelper.SiteURL = @"https://site.ru";

            Regex rg = new Regex(@"^https:\/\/");
            if (rg.IsMatch(yaHelper.SiteURL))
                Assert.Pass(@"A simple HTTPS test has passed.");
            else
                Assert.Fail(@"A simple HTTPS test has failed.");
        }

        [Test]
        public void TestSiteURL_NoProtocol()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            yaHelper.SiteURL = @"site.ru";

            Regex rg = new Regex(@"^http:\/\/");
            if (rg.IsMatch(yaHelper.SiteURL))
                Assert.Pass(@"Test URL without protocol passed.");
            else
                Assert.Fail(@"Test URL without protocol failed.");
        }

        [Test]
        public void TestSiteURL_HostName()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            yaHelper.SiteURL = @"https://site.ru/questions/11717707/best-way-to-split-a-string-without-a-separator?noredirect=1&lq=1";

            if (yaHelper.HostName == @"site.ru")
                Assert.Pass(@"The host name extracting test has passed.");
            else
                Assert.Fail(@"The host name extracting test has failed.");
        }
    }
}
