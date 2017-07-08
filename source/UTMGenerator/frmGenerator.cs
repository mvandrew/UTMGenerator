using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTMGenerator
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
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

        private void lbAdditionalTemplatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbAdditionalTemplatesList.SelectedIndex)
            {
                case 0:
                    tbAdditionalTemplatesValue.Text = @"&region={region_id}&region_name={region_name}";
                    break;
            }
        }

        private void refreshResultURL()
        {

        }

        /// <summary>
        /// Безопасно добавляет в поле дополнительных меток
        /// выбраный шаблон дополнительных меток.
        /// </summary>
        private void includeAdditionalTemplate()
        {
            tbUTMAdditional.Text += tbAdditionalTemplatesValue.Text;
        }

        private void rbYandexSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYandexSearch.Checked)
            {
                // Формирование шаблона меток
                tbUTMSource.Text = @"yandex";
                tbUTMMedium.Text = @"cpc";
                tbUTMCampaign.Text = @"{campaign_id}";
                tbUTMContent.Text = @"{ad_id}";
                tbUTMTerm.Text = @"{keyword}";
                tbUTMAdditional.Text = @"&block={position_type}&position={position}";
                includeAdditionalTemplate();

                // Проверка включения ключевого слова
                if (!cbIncludeUTMTerm.Checked)
                    cbIncludeUTMTerm.Checked = true;
            }
            refreshResultURL();
        }
    }
}
