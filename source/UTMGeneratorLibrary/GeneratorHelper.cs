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
        /// Need Transliteration
        /// </summary>
        private bool _transliteration;
        /// <summary>
        /// Place the trailing slash
        /// </summary>
        private bool _slashPlace;
        /// <summary>
        /// Additional UTM Tags
        /// </summary>
        private string _utmAdditional;
        /// <summary>
        /// UTM Campaign Tag
        /// </summary>
        private string _utmCampaign;
        /// <summary>
        /// UTM Content Tag
        /// </summary>
        private string _utmContent;
        /// <summary>
        /// UTM Medium Tag
        /// </summary>
        private string _utmMedium;
        /// <summary>
        /// UTM Source Tag
        /// </summary>
        private string _utmSource;
        /// <summary>
        /// UTM Term Tag
        /// </summary>
        private string _utmTerm;

        /// <summary>
        /// The event raised when the URL value or UTM tag changes
        /// </summary>
        public event EventHandler SiteURLChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GeneratorHelper()
        {
            _siteURL = "";
            _hostName = "";
            _clearURL = "";
            _arguments = "";
            _anchor = "";
            _transliteration = false;
            _slashPlace = false;
            _utmAdditional = Default_UTMAdditional;
            _utmCampaign = Default_UTMCampaign;
            _utmContent = Default_UTMContent;
            _utmMedium = Default_UTMMedium;
            _utmSource = Default_UTMSource;
            _utmTerm = Default_UTMTerm;
        }

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
        /// Place the trailing slash
        /// </summary>
        public bool SlashPlace
        {
            get { return _slashPlace; }

            set
            {
                if (_slashPlace != value)
                {
                    _slashPlace = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// Need Transliteration
        /// </summary>
        public bool Transliteration
        {
            get { return _transliteration; }

            set
            {
                if (_transliteration != value)
                {
                    _transliteration = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// Additional UTM Tags
        /// </summary>
        public string UTMAdditional
        {
            get
            {
                string result = _utmAdditional;
                Regex rg = new Regex(@"^&");
                result = rg.Replace(result, "");
                return result;
            }

            set
            {
                if (_utmAdditional != value)
                {
                    _utmAdditional = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// UTM Campaign Tag
        /// </summary>
        public string UTMCampaign
        {
            get
            {
                string result = Transliteration ? Transliterate(_utmCampaign) : ReplaceProhibitedCharacters(_utmCampaign);
                return result;
            }

            set
            {
                if (_utmCampaign != value)
                {
                    _utmCampaign = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// UTM Content Tag
        /// </summary>
        public string UTMContent
        {
            get
            {
                string result = Transliteration ? Transliterate(_utmContent) : ReplaceProhibitedCharacters(_utmContent);
                return result;
            }

            set
            {
                if (_utmContent != value)
                {
                    _utmContent = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// UTM Medium Tag
        /// </summary>
        public string UTMMedium
        {
            get
            {
                string result = Transliteration ? Transliterate(_utmMedium) : ReplaceProhibitedCharacters(_utmMedium);
                return result;
            }

            set
            {
                if (_utmMedium != value)
                {
                    _utmMedium = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// UTM Source Tag
        /// </summary>
        public string UTMSource
        {
            get
            {
                string result = Transliteration ? Transliterate(_utmSource) : ReplaceProhibitedCharacters(_utmSource);
                return result;
            }

            set
            {
                if (_utmSource != value)
                {
                    _utmSource = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// UTM Term Tag
        /// </summary>
        public string UTMTerm
        {
            get
            {
                string result = Transliteration ? Transliterate(_utmTerm) : ReplaceProhibitedCharacters(_utmTerm);
                return result;
            }

            set
            {
                if (_utmTerm != value)
                {
                    _utmTerm = value;
                    RaiseSiteURLChanged();
                }
            }
        }

        /// <summary>
        /// Result URL
        /// </summary>
        public string ResultURL
        {
            get
            {
                string result = ClearURL;

                
                // Trailing slash check
                if (SlashPlace && result.Length > 0 && result.Substring(result.Length - 1, 1) != "/")
                    result += "/";

                
                // Adding arguments
                if (Arguments.Length > 0)
                    result += Arguments;

                
                // Creating UTM tags
                string utmArgs = "";
                if (UTMSource.Length > 0)
                {
                    if (utmArgs.Length > 0) utmArgs += "&";
                    utmArgs += @"utm_source=" + UTMSource;
                }

                if (UTMMedium.Length > 0)
                {
                    if (utmArgs.Length > 0) utmArgs += "&";
                    utmArgs += @"utm_medium=" + UTMMedium;
                }

                if (UTMCampaign.Length > 0)
                {
                    if (utmArgs.Length > 0) utmArgs += "&";
                    utmArgs += @"utm_campaign=" + UTMCampaign;
                }

                if (UTMContent.Length > 0)
                {
                    if (utmArgs.Length > 0) utmArgs += "&";
                    utmArgs += @"utm_content=" + UTMContent;
                }

                if (UTMTerm.Length > 0)
                {
                    if (utmArgs.Length > 0) utmArgs += "&";
                    utmArgs += @"utm_term=" + UTMTerm;
                }

                if (UTMAdditional.Length > 0)
                {
                    if (utmArgs.Length > 0) utmArgs += "&";
                    utmArgs += UTMAdditional;
                }


                // Adding UTM tags
                if (utmArgs.Length > 0)
                {
                    result += (Arguments.Length > 0 ? "&" : "?") +
                        utmArgs;
                }


                // Adding anchor
                if (Anchor.Length > 0)
                    result += Anchor;

                return result.ToLower();
            }
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

        /// <summary>
        /// Transliterate the string
        /// </summary>
        public string Transliterate(string sourceValue)
        {
            // Preparing the argument
            string result = sourceValue.Trim().ToLower();

            // Transliterate cyrillic symbols
            string[] symbRu = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string[] symbEn = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "", "y", "", "e", "yu", "ya" };

            for (int i = 0; i < Math.Min(symbRu.Length, symbEn.Length); i++)
            {
                result = result.Replace(symbRu[i], symbEn[i]);
            }

            return ReplaceProhibitedCharacters(result);
        }

        /// <summary>
        /// Replace the prohibited characters
        /// </summary>
        /// <param name="sourceValue"></param>
        /// <returns>The safe value.</returns>
        public string ReplaceProhibitedCharacters(string sourceValue)
        {
            Regex rg = new Regex(@"[^\w{}\.\|]+");
            string result = rg.Replace(sourceValue, "-");

            return result;
        }
    }
}
