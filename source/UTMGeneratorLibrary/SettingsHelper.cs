using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// Settings serialization helper
    /// </summary>
    [DataContract]
    public class SettingsHelper
    {
        /// <summary>
        /// The settings file name
        /// </summary>
        private static string FILE_NAME = @"UTMGeneratorSettings.xml";

        /// <summary>
        /// Site URL value
        /// </summary>
        [DataMember]
        public string SiteURL;

        /// <summary>
        /// Trafic Source Type
        /// </summary>
        [DataMember]
        public SourcesTypes SourceType;

        /// <summary>
        /// UTM Source Tag
        /// </summary>
        [DataMember]
        public string UTMSource;

        /// <summary>
        /// UTM Medium Tag
        /// </summary>
        [DataMember]
        public string UTMMedium;

        /// <summary>
        /// UTM Campaign Tag
        /// </summary>
        [DataMember]
        public string UTMCampaign;

        /// <summary>
        /// UTM Content Tag
        /// </summary>
        [DataMember]
        public string UTMContent;

        /// <summary>
        /// UTM Term Tag
        /// </summary>
        [DataMember]
        public string UTMTerm;

        /// <summary>
        /// Additional UTM Tags
        /// </summary>
        [DataMember]
        public string UTMAdditional;

        /// <summary>
        /// Need Transliteration
        /// </summary>
        [DataMember]
        public bool Transliteration;

        /// <summary>
        /// Place the trailing slash
        /// </summary>
        [DataMember]
        public bool SlashPlace;

        /// <summary>
        /// Default Class Constructor
        /// </summary>
        public SettingsHelper()
        {
            SiteURL = "";
            SourceType = SourcesTypes.EMPTY;
        }

        /// <summary>
        /// The config file path
        /// </summary>
        public static string CONFIG_PATH
        {
            get
            {
                string configPath =
                    System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                    @"\" + SettingsHelper.FILE_NAME;

                return configPath;
            }
        }

        /// <summary>
        /// Load the last settings values
        /// </summary>
        public static SettingsHelper GetSettings()
        {
            SettingsHelper result = new SettingsHelper();

            try
            {
                if (File.Exists(SettingsHelper.CONFIG_PATH))
                {
                    var ds = new DataContractSerializer(typeof(SettingsHelper));
                    using (Stream s = File.OpenRead(SettingsHelper.CONFIG_PATH))
                        result = (SettingsHelper)ds.ReadObject(s);
                }
            } catch { }

            return result;
        }

        /// <summary>
        /// Saves the current settings
        /// </summary>
        public void SaveSettings()
        {
            try
            {
                var ds = new DataContractSerializer(typeof(SettingsHelper));
                using (Stream s = File.Create(SettingsHelper.CONFIG_PATH))
                    ds.WriteObject(s, this);
            } catch { }

        }
    }
}
