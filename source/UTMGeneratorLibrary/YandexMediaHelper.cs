using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// Yandex Direct media network (RSYA) traffic
    /// </summary>
    public class YandexMediaHelper : YandexSearchHelper
    {
        /// <summary>
        /// Return default UTM Additional tags value
        /// </summary>
        /// <value>Default value is additional tags: source placement.</value>
        public override string Default_UTMAdditional
        {
            get { return @"&source={source}"; }
        }
    }
}
