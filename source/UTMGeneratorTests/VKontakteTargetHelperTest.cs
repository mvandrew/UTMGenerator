using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTMGeneratorLibrary;

namespace UTMGeneratorTests
{
    [TestFixture]
    public class VKontakteTargetHelperTest
    {
        /// <summary>
        /// Testing the default URL.
        /// </summary>
        [Test]
        public void VK_TestDefaultResultURL()
        {
            VKontakteTargetHelper helper = new VKontakteTargetHelper
            {
                SiteURL = @"http://www.site.ru#tag"
            };

            Assert.AreEqual(@"http://www.site.ru?utm_source=vkontakte&utm_medium=cpc&utm_campaign={campaign_id}&utm_content={ad_id}#tag", 
                helper.ResultURL, 
                "Testing the default URL is fail.");
        }
    }
}
