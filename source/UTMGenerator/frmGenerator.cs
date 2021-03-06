﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using UTMGeneratorLibrary;

namespace UTMGenerator
{
    public partial class frmGenerator : Form
    {
        /// <summary>
        /// Generator helper class instance
        /// </summary>
        private GeneratorHelper generatorHelper;

        /// <summary>
        /// Form Constructor
        /// </summary>
        public frmGenerator()
        {
            InitializeComponent();

            //
            // Determine current assembly version
            //
            Version ver = Assembly.GetEntryAssembly().GetName().Version;
            Text += @" - Вер. " + ver.ToString();


            //
            // Load the latest settings
            //
            SettingsHelper settings = SettingsHelper.GetSettings();

            // Process the traffic source
            switch (settings.SourceType)
            {
                case SourcesTypes.YANDEX_SEARCH:
                    rbYandexSearch.Checked = true;
                    break;
                case SourcesTypes.YANDEX_MEDIA:
                    rbYandexRSYA.Checked = true;
                    break;
                case SourcesTypes.GOOGLE_SEARCH:
                    rbGoogleAdWords.Checked = true;
                    break;
                case SourcesTypes.GOOGLE_MEDIA:
                    rbGoogleKMS.Checked = true;
                    break;
                case SourcesTypes.VK_TARGET:
                    rbVK.Checked = true;
                    break;
            }

            tbUTMSource.Text = settings.UTMSource;
            tbUTMMedium.Text = settings.UTMMedium;
            tbUTMCampaign.Text = settings.UTMCampaign;
            tbUTMContent.Text = settings.UTMContent;
            tbUTMTerm.Text = settings.UTMTerm;
            tbUTMAdditional.Text = settings.UTMAdditional;

            cbTransliteration.Checked = settings.Transliteration;
            cbSlashPlace.Checked = settings.SlashPlace;

            tbURL.Text = settings.SiteURL;
        }

        /// <summary>
        /// Defines the traffic source type template
        /// </summary>
        private void responseMedium()
        {
            int valIndex;

            switch (tbUTMMedium.Text)
            {
                case "organic":
                    valIndex = 1;
                    break;
                case "cpc":
                    valIndex = 2;
                    break;
                case "email":
                    valIndex = 3;
                    break;
                case "social":
                    valIndex = 4;
                    break;
                case "banner":
                    valIndex = 5;
                    break;
                case "cpa":
                    valIndex = 6;
                    break;
                default:
                    valIndex = 0;
                    break;
            }

            if (valIndex != cbUTMMedium.SelectedIndex)
                cbUTMMedium.SelectedIndex = valIndex;
        }

        private void llYandexDirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://direct.yandex.ru/");
        }

        private void llGoogleAdWords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://adwords.google.com/");
        }

        private void llVKTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://vk.com/ads");
        }

        private void llMailTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://target.my.com/");
        }

        private void llFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://business.facebook.com/");
        }

        private void llInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.instagram.com/");
        }

        private void llTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://twitter.com/");
        }

        private void llRecreativ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://recreativ.ru/");
        }

        private void llKadam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.kadam.net/");
        }

        private void llOblivkiBiz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://oblivki.biz/");
        }

        /// <summary>
        /// Additional Templates List Item Selected Index Changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAdditionalTemplatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedValue =
                lbAdditionalTemplatesList.Items[lbAdditionalTemplatesList.SelectedIndex].ToString();

                tbAdditionalTemplatesValue.Text = generatorHelper.getUTMAdditionalValue(selectedValue);
            }
            catch { tbAdditionalTemplatesValue.Text = ""; }
        }

        /// <summary>
        /// Creating helper class for the target trafic source.
        /// </summary>
        private void targetSystemChanged()
        {
            // Creating helper class
            if (rbYandexSearch.Checked) { generatorHelper = new YandexSearchHelper(); }
            else if (rbYandexRSYA.Checked) { generatorHelper = new YandexMediaHelper(); }
            else if (rbGoogleAdWords.Checked) { generatorHelper = new GoogleSearchHelper(); }
            else if (rbGoogleKMS.Checked) { generatorHelper = new GoogleMediaHelper(); }
            else if (rbVK.Checked) { generatorHelper = new VKontakteTargetHelper(); }
            else { generatorHelper = null; }

            // Set default field values
            tbAdditionalTemplatesValue.Text = "";
            lbAdditionalTemplatesList.Items.Clear();
            if (generatorHelper == null)
            {
                tbUTMSource.Text = "";
                tbUTMMedium.Text = "";
                tbUTMCampaign.Text = "";
                tbUTMContent.Text = "";
                tbUTMTerm.Text = "";
                tbUTMAdditional.Text = "";
            }
            else
            {
                generatorHelper.SiteURLChanged += GeneratorHelper_SiteURLChanged;

                generatorHelper.Transliteration = cbTransliteration.Checked;
                generatorHelper.SlashPlace = cbSlashPlace.Checked;
                generatorHelper.SiteURL = tbURL.Text;

                // Set default tag values
                tbUTMSource.Text = generatorHelper.Default_UTMSource;
                tbUTMMedium.Text = generatorHelper.Default_UTMMedium;
                tbUTMCampaign.Text = generatorHelper.Default_UTMCampaign;
                tbUTMContent.Text = generatorHelper.Default_UTMContent;
                tbUTMTerm.Text = generatorHelper.Default_UTMTerm;
                tbUTMAdditional.Text = generatorHelper.Default_UTMAdditional;

                // Refreshing additional templates list
                foreach (string templateValue in generatorHelper.AdditionalTemplatesList)
                {
                    lbAdditionalTemplatesList.Items.Add(templateValue);
                }
            }
        }

        private void GeneratorHelper_SiteURLChanged(object sender, EventArgs e)
        {
            tbResultURL.Text = generatorHelper.ResultURL;
        }

        private void refreshResultURL()
        {

        }

        /// <summary>
        /// Safely adds a selected additional tags template to the additional tags field.
        /// </summary>
        private void includeAdditionalTemplate()
        {
            tbUTMAdditional.Text += tbAdditionalTemplatesValue.Text;
        }

        private void rbYandexSearch_CheckedChanged(object sender, EventArgs e)
        {
            targetSystemChanged();
        }

        private void btAdditionalTemplateInclude_Click(object sender, EventArgs e)
        {
            includeAdditionalTemplate();
        }

        /// <summary>
        /// Returns the current source type
        /// </summary>
        /// <returns>The current source type</returns>
        private SourcesTypes getSourceType()
        {
            SourcesTypes result = SourcesTypes.EMPTY;

            if (rbYandexSearch.Checked) { result = SourcesTypes.YANDEX_SEARCH; }
            else if (rbYandexRSYA.Checked) { result = SourcesTypes.YANDEX_MEDIA; }
            else if (rbGoogleAdWords.Checked) { result = SourcesTypes.GOOGLE_SEARCH; }
            else if (rbGoogleKMS.Checked) { result = SourcesTypes.GOOGLE_MEDIA; }
            else if (rbVK.Checked) { result = SourcesTypes.VK_TARGET; }

            return result;
        }

        /// <summary>
        /// Process the form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Saves the current settings
            SettingsHelper settings = new SettingsHelper();

            settings.SiteURL = tbURL.Text;
            settings.SourceType = getSourceType();

            settings.UTMSource = tbUTMSource.Text;
            settings.UTMMedium = tbUTMMedium.Text;
            settings.UTMCampaign = tbUTMCampaign.Text;
            settings.UTMContent = tbUTMContent.Text;
            settings.UTMTerm = tbUTMTerm.Text;
            settings.UTMAdditional = tbUTMAdditional.Text;

            settings.Transliteration = cbTransliteration.Checked;
            settings.SlashPlace = cbSlashPlace.Checked;

            settings.SaveSettings();
        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.SiteURL = tbURL.Text;
        }

        private void cbSlashPlace_CheckedChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.SlashPlace = cbSlashPlace.Checked;
        }

        private void tbUTMSource_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.UTMSource = tbUTMSource.Text;
        }

        private void cbTransliteration_CheckedChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.Transliteration = cbTransliteration.Checked;
        }

        private void tbUTMMedium_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.UTMMedium = tbUTMMedium.Text;

            responseMedium();
        }

        private void tbUTMCampaign_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.UTMCampaign = tbUTMCampaign.Text;
        }

        private void tbUTMContent_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.UTMContent = tbUTMContent.Text;
        }

        private void tbUTMTerm_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.UTMTerm = tbUTMTerm.Text;
        }

        private void tbUTMAdditional_TextChanged(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                generatorHelper.UTMAdditional = tbUTMAdditional.Text;
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (tbResultURL.Text.Length > 0)
                Clipboard.SetText(tbResultURL.Text);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            if (generatorHelper != null)
                tbResultURL.Text = generatorHelper.ResultURL;
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"^(https|http):\/\/");
            if (rg.IsMatch(tbResultURL.Text))
                System.Diagnostics.Process.Start(tbResultURL.Text);
        }

        private void rbYandexRSYA_CheckedChanged(object sender, EventArgs e)
        {
            targetSystemChanged();
        }

        private void rbGoogleAdWords_CheckedChanged(object sender, EventArgs e)
        {
            targetSystemChanged();
        }

        private void rbGoogleKMS_CheckedChanged(object sender, EventArgs e)
        {
            targetSystemChanged();
        }

        private void llYandexDirectTemplates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://yandex.ru/support/direct/statistics/url-tags.html");
        }

        private void llGoogleAdWordsTemplates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://support.google.com/adwords/answer/6305348");
        }

        /// <summary>
        /// Processing the selection of the traffic source type template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUTMMedium_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderElement = (ComboBox)sender;

            if (senderElement.SelectedIndex > 0 && senderElement.SelectedIndex < 7)
            {
                string[] sources = {
                    "organic",
                    "cpc",
                    "email",
                    "social",
                    "banner",
                    "cpa"
                };
                string newVal = sources[senderElement.SelectedIndex - 1];
                if (newVal != tbUTMMedium.Text)
                    tbUTMMedium.Text = newVal;
            }
            
        }

        private void rbVK_CheckedChanged(object sender, EventArgs e)
        {
            targetSystemChanged();
        }
    }
}
