using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// Google AdWords search traffic
    /// </summary>
    /// <remarks>https://support.google.com/adwords/answer/6305348?authuser=1</remarks>
    public class GoogleSearchHelper : GeneratorHelper
    {
        /// <summary>
        /// Return default UTM Source value
        /// </summary>
        /// <value>Default value is "google" and network type</value>
        public override string Default_UTMSource
        {
            get { return @"google.{network}"; }
        }

        /// <summary>
        /// Return default UTM Campaign value
        /// </summary>
        /// <value>Default value is Google AdWords Campaign ID.</value>
        public override string Default_UTMCampaign
        {
            get { return @"{campaignid}"; }
        }

        /// <summary>
        /// Return default UTM Content value
        /// </summary>
        /// <value>Default value is Google AdWords group ID and Ads ID.</value>
        public override string Default_UTMContent
        {
            get { return @"{adgroupid}.{creative}"; }
        }

        /// <summary>
        /// Return default UTM Term value.
        /// </summary>
        /// <value>Default value is current keyword value template.</value>
        public override string Default_UTMTerm
        {
            get { return @"{keyword}"; }
        }

        /// <summary>
        /// Return default UTM Additional tags value
        /// </summary>
        /// <value>Default value is additional tags: ads position.</value>
        public override string Default_UTMAdditional
        {
            get { return @"&utm_position=google.{adposition}"; }
        }

        /// <summary>
        /// Additional Tag Templates List for the current traffic source.
        /// </summary>
        /// <value>Templates List Array</value>
        public override string[] AdditionalTemplatesList
        {
            get
            {
                string[] result =
                {
                    @"Субаккаунты для M1-Shop.Ru"
                };

                return result;
            }
        }

        /// <summary>
        /// Process additional template name
        /// </summary>
        /// <remarks>https://support.google.com/adwords/answer/6305348?authuser=1</remarks>
        /// <param name="additionalTemplateName">Value from the collection AdditionalTemplatesList</param>
        /// <returns>Additional UTM Tags</returns>
        /// <see cref="AdditionalTemplatesList"/>
        public override string getUTMAdditionalValue(string additionalTemplateName)
        {

            string result = "";

            int templateIndex = Array.IndexOf(AdditionalTemplatesList, additionalTemplateName);

            switch (templateIndex)
            {
                case 0:
                    result = @"&s=" + HostName +
                        @"&w=" + Default_UTMSource +
                        @"&p=" + Default_UTMCampaign +
                        @"&t=" + Default_UTMContent +
                        @"&m=" + Default_UTMMedium;
                    break;
            }

            return result;
        }
    }
}
