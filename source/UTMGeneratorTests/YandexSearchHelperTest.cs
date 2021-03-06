﻿using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using UTMGeneratorLibrary;

namespace UTMGeneratorTests
{
    [TestFixture]
    public class YandexSearchHelperTest
    {
        [Test]
        public void YA_TestSiteURL_http()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper
            {
                SiteURL = @"http://site.ru"
            };

            Regex rg = new Regex(@"^http:\/\/");
            if (rg.IsMatch(yaHelper.SiteURL))
                Assert.Pass(@"A simple HTTP test has passed.");
            else
                Assert.Fail(@"A simple HTTP test has failed.");
        }

        [Test]
        public void YA_TestSiteURL_https()
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
        public void YA_TestSiteURL_NoProtocol()
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
        public void YA_TestSiteURL_HostName()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            yaHelper.SiteURL = @"https://site.ru/questions/11717707/best-way-to-split-a-string-without-a-separator?noredirect=1&lq=1";

            if (yaHelper.HostName == @"site.ru")
                Assert.Pass(@"The host name extracting test has passed.");
            else
                Assert.Fail(@"The host name extracting test has failed.");
        }

        [Test]
        public void YA_TestSiteURL_ClearURL()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            string baseURL = @"https://site.ru/index.html";
            string[] testedURLs =
            {
                baseURL + @"?query=test_value",
                baseURL + @"#test_anchor",
                baseURL + @"?query=test_value#test_anchor"
            };

            bool result = true;

            foreach (string urlValue in testedURLs)
            {
                yaHelper.SiteURL = urlValue;
                if (yaHelper.ClearURL != baseURL)
                    result = false;
            }
            
            if (result)
                Assert.Pass(@"The clear URL value extracting test has passed.");
            else
                Assert.Fail(@"The clear URL value extracting test has failed.");
        }

        [Test]
        public void YA_TestSiteURL_URLArguments()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            string baseURL = @"https://site.ru/index.html";
            string args = @"?query=test&sec=lss";
            string anchor = @"#anchor_test";

            // Test strings
            string[] testedURLs =
            {
                baseURL,
                baseURL + anchor,
                baseURL + args,
                baseURL + args + anchor,
                baseURL + anchor + args
            };

            // Test results
            string[] testResult =
            {
                "",
                "",
                args,
                args,
                args
            };

            bool result = true;

            foreach (string urlValue in testedURLs)
            {
                yaHelper.SiteURL = urlValue;
                if (yaHelper.Arguments != testResult[Array.IndexOf(testedURLs, urlValue)])
                    result = false;
            }

            if (result)
                Assert.Pass(@"The URL arguments extracting test has passed.");
            else
                Assert.Fail(@"The URL arguments extracting test has failed.");
        }

        [Test]
        public void YA_TestSiteURL_URLAnchor()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();
            string baseURL = @"https://site.ru/index.html";
            string args = @"?query=test&sec=lss";
            string anchor = @"#anchor_test";

            // Test strings
            string[] testedURLs =
            {
                baseURL,
                baseURL + anchor,
                baseURL + args,
                baseURL + args + anchor,
                baseURL + anchor + args
            };

            // Test results
            string[] testResult =
            {
                "",
                anchor,
                "",
                anchor,
                anchor
            };

            bool result = true;

            foreach (string urlValue in testedURLs)
            {
                yaHelper.SiteURL = urlValue;
                if (yaHelper.Anchor != testResult[Array.IndexOf(testedURLs, urlValue)])
                    result = false;
            }

            if (result)
                Assert.Pass(@"The URL anchor extracting test has passed.");
            else
                Assert.Fail(@"The URL anchor extracting test has failed.");
        }

        [Test]
        public void YA_Test_Transliterate()
        {
            YandexSearchHelper yaHelper = new YandexSearchHelper();

            // Test strings
            string[] testSource =
            {
                "Тест",
                "TesT",
                "Два Слова",
                "Два  ПроБела",
                "Слово?99",
                "Слово 76",
                "347",
                "33_987"
            };

            // Test results
            string[] testResult =
            {
                "test",
                "test",
                "dva-slova",
                "dva-probela",
                "slovo-99",
                "slovo-76",
                "347",
                "33_987"
            };

            // Result Info
            bool result = true;
            string failValue = "";

            // Testing
            for (int i = 0; i < testSource.Length; i++)
            {
                if (yaHelper.Transliterate(testSource[i]) != testResult[i])
                {
                    result = false;
                    failValue = yaHelper.Transliterate(testSource[i]);
                }
            }

            if (result)
                Assert.Pass(@"Transliterate test has passed.");
            else
                Assert.Fail(@"Transliterate test has failed: " + failValue);
        }
    }
}
