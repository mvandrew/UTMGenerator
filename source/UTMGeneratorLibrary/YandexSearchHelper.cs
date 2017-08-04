using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTMGeneratorLibrary
{
    public class YandexSearchHelper : GeneratorHelper
    {
        /// <summary>
        /// Return default UTM Source value
        /// </summary>
        /// <value>Default value is "yandex"</value>
        public override string Default_UTMSource
        {
            get { return "yandex"; }
        }

        /// <summary>
        /// Return default UTM Campaign value
        /// </summary>
        /// <value>Default value is Yandex Direct Campaign ID.</value>
        public override string Default_UTMCampaign
        {
            get { return @"{campaign_id}"; }
        }

        /// <summary>
        /// Return default UTM Content value
        /// </summary>
        /// <value>Default value is Yandex Direct Ads ID.</value>
        public override string Default_UTMContent
        {
            get { return @"{ad_id}"; }
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
        /// <value>Default value is additional tags: position type and position info.</value>
        public override string Default_UTMAdditional
        {
            get { return @"&block={position_type}&position={position}"; }
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
                    @"Регионы для Директа",
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
                    result = @"&region={region_id}&region_name={region_name}";
                    break;
                case 1:
                    result = @"";
                    break;
            }

            return result;
        }
    }
}
