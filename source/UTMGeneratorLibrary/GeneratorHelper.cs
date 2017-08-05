using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// UTM Generator main template class
    /// </summary>
    public abstract class GeneratorHelper
    {
        /// <summary>
        /// Site URL value
        /// </summary>
        private string _siteURL;
        /// <summary>
        /// URL host name
        /// </summary>
        private string _hostName;
        /// <summary>
        /// Only the URL value without arguments and anchor
        /// </summary>
        private string _clearURL;
        /// <summary>
        /// URL arguments
        /// </summary>
        private string _arguments;
        /// <summary>
        /// URL anchor
        /// </summary>
        private string _anchor;

        /// <summary>
        /// The event raised when the URL value or UTM tag changes
        /// </summary>
        public event EventHandler SiteURLChanged;

        /// <summary>
        /// Return default UTM Source value
        /// </summary>
        public abstract string Default_UTMSource
        {
            get;
        }

        /// <summary>
        /// Return default UTM Medium value
        /// </summary>
        /// <value>Default value is "cpc"</value>
        public string Default_UTMMedium
        {
            get { return @"cpc"; }
        }

        /// <summary>
        /// Return default UTM Campaign value
        /// </summary>
        public abstract string Default_UTMCampaign
        {
            get;
        }

        /// <summary>
        /// Return default UTM Content value
        /// </summary>
        public abstract string Default_UTMContent
        {
            get;
        }

        /// <summary>
        /// Return default UTM Term value
        /// </summary>
        public abstract string Default_UTMTerm
        {
            get;
        }

        /// <summary>
        /// Return default UTM Additional tags value
        /// </summary>
        public abstract string Default_UTMAdditional
        {
            get;
        }

        /// <summary>
        /// Additional Tag Templates List for the current traffic source.
        /// </summary>
        /// <value>Templates List Array</value>
        public abstract string[] AdditionalTemplatesList
        {
            get;
        }

        /// <summary>
        /// Site URL value
        /// </summary>
        public string SiteURL
        {
            get { return _siteURL; }

            set
            {
                if (value != _siteURL)
                {
                    string result = value.Trim();

                    // Check the protocol information
                    Regex rg = new Regex(@"^(http|https):\/\/");
                    if (!rg.IsMatch(result))
                        result = @"http://" + result;

                    _siteURL = result;

                    // Extracting the host name
                    rg = new Regex(@"^(http|https):\/\/(?<host>[^\/]+)");
                    Match mtHostName = rg.Match(result);
                    if (mtHostName.Success)
                        _hostName = mtHostName.Groups["host"].Value;
                    else
                        _hostName = "";

                    // Extracting the clear URL value without arguments and anchor
                    rg = new Regex(@"(?<url>^(http|https):\/\/[^?#]+)");
                    Match mtClearURL = rg.Match(result);
                    if (mtClearURL.Success)
                        _clearURL = mtClearURL.Groups["url"].Value;
                    else
                        _clearURL = "";

                    // Extracting the URL arguments
                    rg = new Regex(@"(?<args>\?[^?#]+)");
                    Match mtArguments = rg.Match(result);
                    if (mtArguments.Success)
                        _arguments = mtArguments.Groups["args"].Value;
                    else
                        _arguments = "";

                    // Extracting the URL anchor
                    rg = new Regex(@"(?<anchor>#[^?#]+)");
                    Match mtAnchor = rg.Match(result);
                    if (mtAnchor.Success)
                        _anchor = mtAnchor.Groups["anchor"].Value;
                    else
                        _anchor = "";

                    // Raise the event
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// URL host name
        /// </summary>
        public string HostName
        {
            get { return _hostName; }
        }

        /// <summary>
        /// Only the URL value without arguments and anchor
        /// </summary>
        public string ClearURL
        {
            get { return _clearURL; }
        }

        /// <summary>
        /// URL arguments
        /// </summary>
        public string Arguments
        {
            get { return _arguments; }
        }

        /// <summary>
        /// URL anchor
        /// </summary>
        public string Anchor
        {
            get { return _anchor; }
        }

        /// <summary>
        /// Process additional template name
        /// </summary>
        /// <param name="additionalTemplateName">Value from the collection AdditionalTemplatesList</param>
        /// <returns>Additional UTM Tags</returns>
        /// <see cref="AdditionalTemplatesList"/>
        public abstract string getUTMAdditionalValue(string additionalTemplateName);

        /// <summary>
        /// Raising SiteURLChanged event
        /// </summary>
        public void RaiseSiteURLChanged()
        {
            if (SiteURLChanged != null)
                SiteURLChanged(this, new EventArgs());
        }
    }
}
