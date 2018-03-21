using System;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// VKontakte Target & Social traffic
    /// </summary>
    public class VKontakteTargetHelper : GeneratorHelper
    {
        /// <summary>
        /// Return default UTM Source value
        /// </summary>
        /// <value>Default value is "vkontakte"</value>
        public override string Default_UTMSource
        {
            get { return "vkontakte"; }
        }

        /// <summary>
        /// Return default UTM Campaign value
        /// </summary>
        /// <value>Instead of {campaign_id} VKontakte will automatically substitute the ad campaign ID.</value>
        public override string Default_UTMCampaign
        {
            get { return @"{campaign_id}"; }
        }

        /// <summary>
        /// Return default UTM Content value
        /// </summary>
        /// <value>Instead of {ad_id} VKontakte will automatically substitute the ad ID.</value>
        public override string Default_UTMContent
        {
            get { return @"{ad_id}"; }
        }

        /// <summary>
        /// Return default UTM Term value
        /// </summary>
        public override string Default_UTMTerm
        {
            get { return ""; }
        }

        /// <summary>
        /// Return default UTM Additional tags value
        /// </summary>
        public override string Default_UTMAdditional
        {
            get { return ""; }
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
