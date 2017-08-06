using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// Google AdWords KMS media network traffic
    /// </summary>
    public class GoogleMediaHelper : GoogleSearchHelper
    {
        /// <summary>
        /// Return default UTM Additional tags value
        /// </summary>
        /// <value>Default value is additional tags: source placement.</value>
        public override string Default_UTMAdditional
        {
            get { return @"&utm_site={placement}"; }
        }
    }
}
