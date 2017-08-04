namespace UTMGenerator
{
    partial class frmGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            this.lbURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.llOblivkiBiz = new System.Windows.Forms.LinkLabel();
            this.llKadam = new System.Windows.Forms.LinkLabel();
            this.llRecreativ = new System.Windows.Forms.LinkLabel();
            this.llTwitter = new System.Windows.Forms.LinkLabel();
            this.llInstagram = new System.Windows.Forms.LinkLabel();
            this.llFacebook = new System.Windows.Forms.LinkLabel();
            this.llMailTarget = new System.Windows.Forms.LinkLabel();
            this.llVKTarget = new System.Windows.Forms.LinkLabel();
            this.llGoogleAdWords = new System.Windows.Forms.LinkLabel();
            this.llYandexDirect = new System.Windows.Forms.LinkLabel();
            this.rbOblivkiBiz = new System.Windows.Forms.RadioButton();
            this.rbKadam = new System.Windows.Forms.RadioButton();
            this.rbRecreativ = new System.Windows.Forms.RadioButton();
            this.rbTwitter = new System.Windows.Forms.RadioButton();
            this.rbInstagram = new System.Windows.Forms.RadioButton();
            this.rbFacebook = new System.Windows.Forms.RadioButton();
            this.rbMailTarget = new System.Windows.Forms.RadioButton();
            this.rbVK = new System.Windows.Forms.RadioButton();
            this.rbGoogleKMS = new System.Windows.Forms.RadioButton();
            this.rbGoogleAdWords = new System.Windows.Forms.RadioButton();
            this.rbYandexRSYA = new System.Windows.Forms.RadioButton();
            this.rbYandexSearch = new System.Windows.Forms.RadioButton();
            this.lbUTMSource = new System.Windows.Forms.Label();
            this.tbUTMSource = new System.Windows.Forms.TextBox();
            this.lbUTMSourceHint = new System.Windows.Forms.Label();
            this.lbUTMMediumHint = new System.Windows.Forms.Label();
            this.tbUTMMedium = new System.Windows.Forms.TextBox();
            this.lbUTMMedium = new System.Windows.Forms.Label();
            this.lbUTMCampaignHint = new System.Windows.Forms.Label();
            this.tbUTMCampaign = new System.Windows.Forms.TextBox();
            this.lbUTMCampaign = new System.Windows.Forms.Label();
            this.lbUTMContentHint = new System.Windows.Forms.Label();
            this.tbUTMContent = new System.Windows.Forms.TextBox();
            this.lbUTMContent = new System.Windows.Forms.Label();
            this.lbUTMTermHint = new System.Windows.Forms.Label();
            this.tbUTMTerm = new System.Windows.Forms.TextBox();
            this.lbUTMTerm = new System.Windows.Forms.Label();
            this.lbUTMAdditionalHint = new System.Windows.Forms.Label();
            this.tbUTMAdditional = new System.Windows.Forms.TextBox();
            this.lbUTMAdditional = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbSlashPlaceHint = new System.Windows.Forms.Label();
            this.cbSlashPlace = new System.Windows.Forms.CheckBox();
            this.lbTransliterationHint = new System.Windows.Forms.Label();
            this.cbTransliteration = new System.Windows.Forms.CheckBox();
            this.gbAdditionalTemplates = new System.Windows.Forms.GroupBox();
            this.btAdditionalTemplateInclude = new System.Windows.Forms.Button();
            this.tbAdditionalTemplatesValue = new System.Windows.Forms.TextBox();
            this.lbAdditionalTemplatesList = new System.Windows.Forms.ListBox();
            this.lbResultURL = new System.Windows.Forms.Label();
            this.tbResultURL = new System.Windows.Forms.TextBox();
            this.btCopy = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gbSource.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbAdditionalTemplates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 9);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(104, 13);
            this.lbURL.TabIndex = 0;
            this.lbURL.Text = "Целевая страница:";
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Location = new System.Drawing.Point(15, 25);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(709, 20);
            this.tbURL.TabIndex = 1;
            this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.llOblivkiBiz);
            this.gbSource.Controls.Add(this.llKadam);
            this.gbSource.Controls.Add(this.llRecreativ);
            this.gbSource.Controls.Add(this.llTwitter);
            this.gbSource.Controls.Add(this.llInstagram);
            this.gbSource.Controls.Add(this.llFacebook);
            this.gbSource.Controls.Add(this.llMailTarget);
            this.gbSource.Controls.Add(this.llVKTarget);
            this.gbSource.Controls.Add(this.llGoogleAdWords);
            this.gbSource.Controls.Add(this.llYandexDirect);
            this.gbSource.Controls.Add(this.rbOblivkiBiz);
            this.gbSource.Controls.Add(this.rbKadam);
            this.gbSource.Controls.Add(this.rbRecreativ);
            this.gbSource.Controls.Add(this.rbTwitter);
            this.gbSource.Controls.Add(this.rbInstagram);
            this.gbSource.Controls.Add(this.rbFacebook);
            this.gbSource.Controls.Add(this.rbMailTarget);
            this.gbSource.Controls.Add(this.rbVK);
            this.gbSource.Controls.Add(this.rbGoogleKMS);
            this.gbSource.Controls.Add(this.rbGoogleAdWords);
            this.gbSource.Controls.Add(this.rbYandexRSYA);
            this.gbSource.Controls.Add(this.rbYandexSearch);
            this.gbSource.Location = new System.Drawing.Point(15, 51);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(288, 298);
            this.gbSource.TabIndex = 2;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Источник трафика";
            // 
            // llOblivkiBiz
            // 
            this.llOblivkiBiz.AutoSize = true;
            this.llOblivkiBiz.Location = new System.Drawing.Point(217, 275);
            this.llOblivkiBiz.Name = "llOblivkiBiz";
            this.llOblivkiBiz.Size = new System.Drawing.Size(59, 13);
            this.llOblivkiBiz.TabIndex = 21;
            this.llOblivkiBiz.TabStop = true;
            this.llOblivkiBiz.Text = "Перейти...";
            this.llOblivkiBiz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOblivkiBiz_LinkClicked);
            // 
            // llKadam
            // 
            this.llKadam.AutoSize = true;
            this.llKadam.Location = new System.Drawing.Point(217, 252);
            this.llKadam.Name = "llKadam";
            this.llKadam.Size = new System.Drawing.Size(59, 13);
            this.llKadam.TabIndex = 20;
            this.llKadam.TabStop = true;
            this.llKadam.Text = "Перейти...";
            this.llKadam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llKadam_LinkClicked);
            // 
            // llRecreativ
            // 
            this.llRecreativ.AutoSize = true;
            this.llRecreativ.Location = new System.Drawing.Point(217, 229);
            this.llRecreativ.Name = "llRecreativ";
            this.llRecreativ.Size = new System.Drawing.Size(59, 13);
            this.llRecreativ.TabIndex = 19;
            this.llRecreativ.TabStop = true;
            this.llRecreativ.Text = "Перейти...";
            this.llRecreativ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRecreativ_LinkClicked);
            // 
            // llTwitter
            // 
            this.llTwitter.AutoSize = true;
            this.llTwitter.Location = new System.Drawing.Point(217, 206);
            this.llTwitter.Name = "llTwitter";
            this.llTwitter.Size = new System.Drawing.Size(59, 13);
            this.llTwitter.TabIndex = 18;
            this.llTwitter.TabStop = true;
            this.llTwitter.Text = "Перейти...";
            this.llTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTwitter_LinkClicked);
            // 
            // llInstagram
            // 
            this.llInstagram.AutoSize = true;
            this.llInstagram.Location = new System.Drawing.Point(217, 183);
            this.llInstagram.Name = "llInstagram";
            this.llInstagram.Size = new System.Drawing.Size(59, 13);
            this.llInstagram.TabIndex = 17;
            this.llInstagram.TabStop = true;
            this.llInstagram.Text = "Перейти...";
            this.llInstagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInstagram_LinkClicked);
            // 
            // llFacebook
            // 
            this.llFacebook.AutoSize = true;
            this.llFacebook.Location = new System.Drawing.Point(217, 160);
            this.llFacebook.Name = "llFacebook";
            this.llFacebook.Size = new System.Drawing.Size(59, 13);
            this.llFacebook.TabIndex = 16;
            this.llFacebook.TabStop = true;
            this.llFacebook.Text = "Перейти...";
            this.llFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFacebook_LinkClicked);
            // 
            // llMailTarget
            // 
            this.llMailTarget.AutoSize = true;
            this.llMailTarget.Location = new System.Drawing.Point(217, 137);
            this.llMailTarget.Name = "llMailTarget";
            this.llMailTarget.Size = new System.Drawing.Size(59, 13);
            this.llMailTarget.TabIndex = 15;
            this.llMailTarget.TabStop = true;
            this.llMailTarget.Text = "Перейти...";
            this.llMailTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMailTarget_LinkClicked);
            // 
            // llVKTarget
            // 
            this.llVKTarget.AutoSize = true;
            this.llVKTarget.Location = new System.Drawing.Point(217, 114);
            this.llVKTarget.Name = "llVKTarget";
            this.llVKTarget.Size = new System.Drawing.Size(59, 13);
            this.llVKTarget.TabIndex = 14;
            this.llVKTarget.TabStop = true;
            this.llVKTarget.Text = "Перейти...";
            this.llVKTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llVKTarget_LinkClicked);
            // 
            // llGoogleAdWords
            // 
            this.llGoogleAdWords.AutoSize = true;
            this.llGoogleAdWords.Location = new System.Drawing.Point(217, 68);
            this.llGoogleAdWords.Name = "llGoogleAdWords";
            this.llGoogleAdWords.Size = new System.Drawing.Size(59, 13);
            this.llGoogleAdWords.TabIndex = 13;
            this.llGoogleAdWords.TabStop = true;
            this.llGoogleAdWords.Text = "Перейти...";
            this.llGoogleAdWords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoogleAdWords_LinkClicked);
            // 
            // llYandexDirect
            // 
            this.llYandexDirect.AutoSize = true;
            this.llYandexDirect.Location = new System.Drawing.Point(217, 21);
            this.llYandexDirect.Name = "llYandexDirect";
            this.llYandexDirect.Size = new System.Drawing.Size(59, 13);
            this.llYandexDirect.TabIndex = 12;
            this.llYandexDirect.TabStop = true;
            this.llYandexDirect.Text = "Перейти...";
            this.llYandexDirect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llYandexDirect_LinkClicked);
            // 
            // rbOblivkiBiz
            // 
            this.rbOblivkiBiz.AutoSize = true;
            this.rbOblivkiBiz.Location = new System.Drawing.Point(6, 273);
            this.rbOblivkiBiz.Name = "rbOblivkiBiz";
            this.rbOblivkiBiz.Size = new System.Drawing.Size(86, 17);
            this.rbOblivkiBiz.TabIndex = 11;
            this.rbOblivkiBiz.TabStop = true;
            this.rbOblivkiBiz.Text = "OBLIVKI.BIZ";
            this.rbOblivkiBiz.UseVisualStyleBackColor = true;
            // 
            // rbKadam
            // 
            this.rbKadam.AutoSize = true;
            this.rbKadam.Location = new System.Drawing.Point(6, 250);
            this.rbKadam.Name = "rbKadam";
            this.rbKadam.Size = new System.Drawing.Size(58, 17);
            this.rbKadam.TabIndex = 10;
            this.rbKadam.TabStop = true;
            this.rbKadam.Text = "Kadam";
            this.rbKadam.UseVisualStyleBackColor = true;
            // 
            // rbRecreativ
            // 
            this.rbRecreativ.AutoSize = true;
            this.rbRecreativ.Location = new System.Drawing.Point(6, 227);
            this.rbRecreativ.Name = "rbRecreativ";
            this.rbRecreativ.Size = new System.Drawing.Size(71, 17);
            this.rbRecreativ.TabIndex = 9;
            this.rbRecreativ.TabStop = true;
            this.rbRecreativ.Text = "Recreativ";
            this.rbRecreativ.UseVisualStyleBackColor = true;
            // 
            // rbTwitter
            // 
            this.rbTwitter.AutoSize = true;
            this.rbTwitter.Location = new System.Drawing.Point(6, 204);
            this.rbTwitter.Name = "rbTwitter";
            this.rbTwitter.Size = new System.Drawing.Size(150, 17);
            this.rbTwitter.TabIndex = 8;
            this.rbTwitter.TabStop = true;
            this.rbTwitter.Text = "Twitter - ссылки в постах";
            this.rbTwitter.UseVisualStyleBackColor = true;
            // 
            // rbInstagram
            // 
            this.rbInstagram.AutoSize = true;
            this.rbInstagram.Location = new System.Drawing.Point(6, 181);
            this.rbInstagram.Name = "rbInstagram";
            this.rbInstagram.Size = new System.Drawing.Size(71, 17);
            this.rbInstagram.TabIndex = 7;
            this.rbInstagram.TabStop = true;
            this.rbInstagram.Text = "Instagram";
            this.rbInstagram.UseVisualStyleBackColor = true;
            // 
            // rbFacebook
            // 
            this.rbFacebook.AutoSize = true;
            this.rbFacebook.Location = new System.Drawing.Point(6, 158);
            this.rbFacebook.Name = "rbFacebook";
            this.rbFacebook.Size = new System.Drawing.Size(107, 17);
            this.rbFacebook.TabIndex = 6;
            this.rbFacebook.TabStop = true;
            this.rbFacebook.Text = "Facebook Target";
            this.rbFacebook.UseVisualStyleBackColor = true;
            // 
            // rbMailTarget
            // 
            this.rbMailTarget.AutoSize = true;
            this.rbMailTarget.Location = new System.Drawing.Point(6, 135);
            this.rbMailTarget.Name = "rbMailTarget";
            this.rbMailTarget.Size = new System.Drawing.Size(165, 17);
            this.rbMailTarget.TabIndex = 5;
            this.rbMailTarget.TabStop = true;
            this.rbMailTarget.Text = "Target Mail.ru - target.my.com";
            this.rbMailTarget.UseVisualStyleBackColor = true;
            // 
            // rbVK
            // 
            this.rbVK.AutoSize = true;
            this.rbVK.Location = new System.Drawing.Point(6, 112);
            this.rbVK.Name = "rbVK";
            this.rbVK.Size = new System.Drawing.Size(136, 17);
            this.rbVK.TabIndex = 4;
            this.rbVK.TabStop = true;
            this.rbVK.Text = "ВКонтакте - Target VK";
            this.rbVK.UseVisualStyleBackColor = true;
            // 
            // rbGoogleKMS
            // 
            this.rbGoogleKMS.AutoSize = true;
            this.rbGoogleKMS.Location = new System.Drawing.Point(6, 89);
            this.rbGoogleKMS.Name = "rbGoogleKMS";
            this.rbGoogleKMS.Size = new System.Drawing.Size(138, 17);
            this.rbGoogleKMS.TabIndex = 3;
            this.rbGoogleKMS.TabStop = true;
            this.rbGoogleKMS.Text = "Google AdWords - КМС";
            this.rbGoogleKMS.UseVisualStyleBackColor = true;
            // 
            // rbGoogleAdWords
            // 
            this.rbGoogleAdWords.AutoSize = true;
            this.rbGoogleAdWords.Location = new System.Drawing.Point(6, 66);
            this.rbGoogleAdWords.Name = "rbGoogleAdWords";
            this.rbGoogleAdWords.Size = new System.Drawing.Size(147, 17);
            this.rbGoogleAdWords.TabIndex = 2;
            this.rbGoogleAdWords.TabStop = true;
            this.rbGoogleAdWords.Text = "Google AdWords - Поиск";
            this.rbGoogleAdWords.UseVisualStyleBackColor = true;
            // 
            // rbYandexRSYA
            // 
            this.rbYandexRSYA.AutoSize = true;
            this.rbYandexRSYA.Location = new System.Drawing.Point(6, 43);
            this.rbYandexRSYA.Name = "rbYandexRSYA";
            this.rbYandexRSYA.Size = new System.Drawing.Size(135, 17);
            this.rbYandexRSYA.TabIndex = 1;
            this.rbYandexRSYA.TabStop = true;
            this.rbYandexRSYA.Text = "Яндекс Директ - РСЯ";
            this.rbYandexRSYA.UseVisualStyleBackColor = true;
            // 
            // rbYandexSearch
            // 
            this.rbYandexSearch.AutoSize = true;
            this.rbYandexSearch.Location = new System.Drawing.Point(6, 19);
            this.rbYandexSearch.Name = "rbYandexSearch";
            this.rbYandexSearch.Size = new System.Drawing.Size(145, 17);
            this.rbYandexSearch.TabIndex = 0;
            this.rbYandexSearch.TabStop = true;
            this.rbYandexSearch.Text = "Яндекс Директ - Поиск";
            this.rbYandexSearch.UseVisualStyleBackColor = true;
            this.rbYandexSearch.CheckedChanged += new System.EventHandler(this.rbYandexSearch_CheckedChanged);
            // 
            // lbUTMSource
            // 
            this.lbUTMSource.AutoSize = true;
            this.lbUTMSource.Location = new System.Drawing.Point(309, 51);
            this.lbUTMSource.Name = "lbUTMSource";
            this.lbUTMSource.Size = new System.Drawing.Size(179, 13);
            this.lbUTMSource.TabIndex = 3;
            this.lbUTMSource.Text = "Источник перехода - utm_source: *";
            // 
            // tbUTMSource
            // 
            this.tbUTMSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUTMSource.Location = new System.Drawing.Point(312, 80);
            this.tbUTMSource.Name = "tbUTMSource";
            this.tbUTMSource.Size = new System.Drawing.Size(412, 20);
            this.tbUTMSource.TabIndex = 4;
            // 
            // lbUTMSourceHint
            // 
            this.lbUTMSourceHint.AutoSize = true;
            this.lbUTMSourceHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUTMSourceHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUTMSourceHint.Location = new System.Drawing.Point(309, 64);
            this.lbUTMSourceHint.Name = "lbUTMSourceHint";
            this.lbUTMSourceHint.Size = new System.Drawing.Size(175, 13);
            this.lbUTMSourceHint.TabIndex = 7;
            this.lbUTMSourceHint.Text = "google, yandex, facebook, vk и пр.";
            // 
            // lbUTMMediumHint
            // 
            this.lbUTMMediumHint.AutoSize = true;
            this.lbUTMMediumHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUTMMediumHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUTMMediumHint.Location = new System.Drawing.Point(309, 116);
            this.lbUTMMediumHint.Name = "lbUTMMediumHint";
            this.lbUTMMediumHint.Size = new System.Drawing.Size(178, 13);
            this.lbUTMMediumHint.TabIndex = 10;
            this.lbUTMMediumHint.Text = "cpc, cpa, email, social, banner и пр.";
            // 
            // tbUTMMedium
            // 
            this.tbUTMMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUTMMedium.Location = new System.Drawing.Point(312, 132);
            this.tbUTMMedium.Name = "tbUTMMedium";
            this.tbUTMMedium.Size = new System.Drawing.Size(412, 20);
            this.tbUTMMedium.TabIndex = 9;
            // 
            // lbUTMMedium
            // 
            this.lbUTMMedium.AutoSize = true;
            this.lbUTMMedium.Location = new System.Drawing.Point(309, 103);
            this.lbUTMMedium.Name = "lbUTMMedium";
            this.lbUTMMedium.Size = new System.Drawing.Size(150, 13);
            this.lbUTMMedium.TabIndex = 8;
            this.lbUTMMedium.Text = "Тип трафика - utm_medium: *";
            // 
            // lbUTMCampaignHint
            // 
            this.lbUTMCampaignHint.AutoSize = true;
            this.lbUTMCampaignHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUTMCampaignHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUTMCampaignHint.Location = new System.Drawing.Point(309, 168);
            this.lbUTMCampaignHint.Name = "lbUTMCampaignHint";
            this.lbUTMCampaignHint.Size = new System.Drawing.Size(251, 13);
            this.lbUTMCampaignHint.TabIndex = 13;
            this.lbUTMCampaignHint.Text = "ремонт офисов, установка кондиционеров и пр.";
            // 
            // tbUTMCampaign
            // 
            this.tbUTMCampaign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUTMCampaign.Location = new System.Drawing.Point(312, 184);
            this.tbUTMCampaign.Name = "tbUTMCampaign";
            this.tbUTMCampaign.Size = new System.Drawing.Size(412, 20);
            this.tbUTMCampaign.TabIndex = 12;
            // 
            // lbUTMCampaign
            // 
            this.lbUTMCampaign.AutoSize = true;
            this.lbUTMCampaign.Location = new System.Drawing.Point(309, 155);
            this.lbUTMCampaign.Name = "lbUTMCampaign";
            this.lbUTMCampaign.Size = new System.Drawing.Size(257, 13);
            this.lbUTMCampaign.TabIndex = 11;
            this.lbUTMCampaign.Text = "Название рекламной кампании - utm_campaign: *";
            // 
            // lbUTMContentHint
            // 
            this.lbUTMContentHint.AutoSize = true;
            this.lbUTMContentHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUTMContentHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUTMContentHint.Location = new System.Drawing.Point(309, 220);
            this.lbUTMContentHint.Name = "lbUTMContentHint";
            this.lbUTMContentHint.Size = new System.Drawing.Size(164, 13);
            this.lbUTMContentHint.TabIndex = 16;
            this.lbUTMContentHint.Text = "id-001, creative-002, banner-003:";
            // 
            // tbUTMContent
            // 
            this.tbUTMContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUTMContent.Location = new System.Drawing.Point(312, 236);
            this.tbUTMContent.Name = "tbUTMContent";
            this.tbUTMContent.Size = new System.Drawing.Size(412, 20);
            this.tbUTMContent.TabIndex = 15;
            // 
            // lbUTMContent
            // 
            this.lbUTMContent.AutoSize = true;
            this.lbUTMContent.Location = new System.Drawing.Point(309, 207);
            this.lbUTMContent.Name = "lbUTMContent";
            this.lbUTMContent.Size = new System.Drawing.Size(222, 13);
            this.lbUTMContent.TabIndex = 14;
            this.lbUTMContent.Text = "Идентификатор объявления - utm_content:";
            // 
            // lbUTMTermHint
            // 
            this.lbUTMTermHint.AutoSize = true;
            this.lbUTMTermHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUTMTermHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUTMTermHint.Location = new System.Drawing.Point(309, 272);
            this.lbUTMTermHint.Name = "lbUTMTermHint";
            this.lbUTMTermHint.Size = new System.Drawing.Size(205, 13);
            this.lbUTMTermHint.TabIndex = 19;
            this.lbUTMTermHint.Text = "кондиционер цена, купить пальто и пр.";
            // 
            // tbUTMTerm
            // 
            this.tbUTMTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUTMTerm.Location = new System.Drawing.Point(312, 288);
            this.tbUTMTerm.Name = "tbUTMTerm";
            this.tbUTMTerm.Size = new System.Drawing.Size(412, 20);
            this.tbUTMTerm.TabIndex = 18;
            // 
            // lbUTMTerm
            // 
            this.lbUTMTerm.AutoSize = true;
            this.lbUTMTerm.Location = new System.Drawing.Point(309, 259);
            this.lbUTMTerm.Name = "lbUTMTerm";
            this.lbUTMTerm.Size = new System.Drawing.Size(145, 13);
            this.lbUTMTerm.TabIndex = 17;
            this.lbUTMTerm.Text = "Ключевое слово - utm_term:";
            // 
            // lbUTMAdditionalHint
            // 
            this.lbUTMAdditionalHint.AutoSize = true;
            this.lbUTMAdditionalHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUTMAdditionalHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUTMAdditionalHint.Location = new System.Drawing.Point(309, 324);
            this.lbUTMAdditionalHint.Name = "lbUTMAdditionalHint";
            this.lbUTMAdditionalHint.Size = new System.Drawing.Size(350, 13);
            this.lbUTMAdditionalHint.TabIndex = 22;
            this.lbUTMAdditionalHint.Text = "указывайте, как расширение: block={position_type}position={position}";
            // 
            // tbUTMAdditional
            // 
            this.tbUTMAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUTMAdditional.Location = new System.Drawing.Point(312, 340);
            this.tbUTMAdditional.Multiline = true;
            this.tbUTMAdditional.Name = "tbUTMAdditional";
            this.tbUTMAdditional.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUTMAdditional.Size = new System.Drawing.Size(412, 55);
            this.tbUTMAdditional.TabIndex = 21;
            // 
            // lbUTMAdditional
            // 
            this.lbUTMAdditional.AutoSize = true;
            this.lbUTMAdditional.Location = new System.Drawing.Point(309, 311);
            this.lbUTMAdditional.Name = "lbUTMAdditional";
            this.lbUTMAdditional.Size = new System.Drawing.Size(132, 13);
            this.lbUTMAdditional.TabIndex = 20;
            this.lbUTMAdditional.Text = "Дополнительные метки:";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbSlashPlaceHint);
            this.gbOptions.Controls.Add(this.cbSlashPlace);
            this.gbOptions.Controls.Add(this.lbTransliterationHint);
            this.gbOptions.Controls.Add(this.cbTransliteration);
            this.gbOptions.Location = new System.Drawing.Point(15, 355);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(288, 173);
            this.gbOptions.TabIndex = 23;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Параметры формирования";
            // 
            // cbSlashPlaceHint
            // 
            this.cbSlashPlaceHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSlashPlaceHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbSlashPlaceHint.Location = new System.Drawing.Point(3, 123);
            this.cbSlashPlaceHint.Name = "cbSlashPlaceHint";
            this.cbSlashPlaceHint.Size = new System.Drawing.Size(276, 43);
            this.cbSlashPlaceHint.TabIndex = 25;
            this.cbSlashPlaceHint.Text = "Адрес целевой страницы будет автоматически закрываться символом слеш /, если он н" +
    "е установлен в поле целевой страницы.";
            // 
            // cbSlashPlace
            // 
            this.cbSlashPlace.AutoSize = true;
            this.cbSlashPlace.Location = new System.Drawing.Point(6, 103);
            this.cbSlashPlace.Name = "cbSlashPlace";
            this.cbSlashPlace.Size = new System.Drawing.Size(176, 17);
            this.cbSlashPlace.TabIndex = 24;
            this.cbSlashPlace.Text = "Ставить слеш / после адреса";
            this.cbSlashPlace.UseVisualStyleBackColor = true;
            // 
            // lbTransliterationHint
            // 
            this.lbTransliterationHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransliterationHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTransliterationHint.Location = new System.Drawing.Point(6, 43);
            this.lbTransliterationHint.Name = "lbTransliterationHint";
            this.lbTransliterationHint.Size = new System.Drawing.Size(276, 57);
            this.lbTransliterationHint.TabIndex = 23;
            this.lbTransliterationHint.Text = "Все метки на русском языке будут транслитерированы, удалены запрещённые символы, " +
    "дубликаты пробелов, пробелы конвертируются в символ подчёркивания";
            // 
            // cbTransliteration
            // 
            this.cbTransliteration.AutoSize = true;
            this.cbTransliteration.Checked = true;
            this.cbTransliteration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTransliteration.Location = new System.Drawing.Point(6, 23);
            this.cbTransliteration.Name = "cbTransliteration";
            this.cbTransliteration.Size = new System.Drawing.Size(110, 17);
            this.cbTransliteration.TabIndex = 0;
            this.cbTransliteration.Text = "Транслитерация";
            this.cbTransliteration.UseVisualStyleBackColor = true;
            // 
            // gbAdditionalTemplates
            // 
            this.gbAdditionalTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdditionalTemplates.Controls.Add(this.btAdditionalTemplateInclude);
            this.gbAdditionalTemplates.Controls.Add(this.tbAdditionalTemplatesValue);
            this.gbAdditionalTemplates.Controls.Add(this.lbAdditionalTemplatesList);
            this.gbAdditionalTemplates.Location = new System.Drawing.Point(312, 401);
            this.gbAdditionalTemplates.Name = "gbAdditionalTemplates";
            this.gbAdditionalTemplates.Size = new System.Drawing.Size(412, 127);
            this.gbAdditionalTemplates.TabIndex = 24;
            this.gbAdditionalTemplates.TabStop = false;
            this.gbAdditionalTemplates.Text = "Шаблоны дополнительных меток";
            // 
            // btAdditionalTemplateInclude
            // 
            this.btAdditionalTemplateInclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdditionalTemplateInclude.Image = global::UTMGenerator.Properties.Resources.Next_icon;
            this.btAdditionalTemplateInclude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdditionalTemplateInclude.Location = new System.Drawing.Point(324, 91);
            this.btAdditionalTemplateInclude.Name = "btAdditionalTemplateInclude";
            this.btAdditionalTemplateInclude.Size = new System.Drawing.Size(81, 28);
            this.btAdditionalTemplateInclude.TabIndex = 2;
            this.btAdditionalTemplateInclude.Text = "Включить";
            this.btAdditionalTemplateInclude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdditionalTemplateInclude.UseVisualStyleBackColor = true;
            this.btAdditionalTemplateInclude.Click += new System.EventHandler(this.btAdditionalTemplateInclude_Click);
            // 
            // tbAdditionalTemplatesValue
            // 
            this.tbAdditionalTemplatesValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdditionalTemplatesValue.Location = new System.Drawing.Point(6, 94);
            this.tbAdditionalTemplatesValue.Name = "tbAdditionalTemplatesValue";
            this.tbAdditionalTemplatesValue.Size = new System.Drawing.Size(312, 20);
            this.tbAdditionalTemplatesValue.TabIndex = 1;
            // 
            // lbAdditionalTemplatesList
            // 
            this.lbAdditionalTemplatesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdditionalTemplatesList.FormattingEnabled = true;
            this.lbAdditionalTemplatesList.Location = new System.Drawing.Point(7, 19);
            this.lbAdditionalTemplatesList.Name = "lbAdditionalTemplatesList";
            this.lbAdditionalTemplatesList.Size = new System.Drawing.Size(399, 69);
            this.lbAdditionalTemplatesList.TabIndex = 0;
            this.lbAdditionalTemplatesList.SelectedIndexChanged += new System.EventHandler(this.lbAdditionalTemplatesList_SelectedIndexChanged);
            // 
            // lbResultURL
            // 
            this.lbResultURL.AutoSize = true;
            this.lbResultURL.Location = new System.Drawing.Point(18, 531);
            this.lbResultURL.Name = "lbResultURL";
            this.lbResultURL.Size = new System.Drawing.Size(162, 13);
            this.lbResultURL.TabIndex = 25;
            this.lbResultURL.Text = "Готовый URL с UTM-метками:";
            // 
            // tbResultURL
            // 
            this.tbResultURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultURL.Location = new System.Drawing.Point(21, 547);
            this.tbResultURL.Multiline = true;
            this.tbResultURL.Name = "tbResultURL";
            this.tbResultURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultURL.Size = new System.Drawing.Size(709, 75);
            this.tbResultURL.TabIndex = 26;
            // 
            // btCopy
            // 
            this.btCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCopy.Image = global::UTMGenerator.Properties.Resources.Copy_icon;
            this.btCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCopy.Location = new System.Drawing.Point(110, 628);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(177, 28);
            this.btCopy.TabIndex = 28;
            this.btCopy.Text = "Копировать в буфер обмена";
            this.btCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCopy.UseVisualStyleBackColor = true;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRefresh.Image = global::UTMGenerator.Properties.Resources.Refresh_icon;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefresh.Location = new System.Drawing.Point(21, 628);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(83, 28);
            this.btRefresh.TabIndex = 27;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 665);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.tbResultURL);
            this.Controls.Add(this.lbResultURL);
            this.Controls.Add(this.gbAdditionalTemplates);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.lbUTMAdditionalHint);
            this.Controls.Add(this.tbUTMAdditional);
            this.Controls.Add(this.lbUTMAdditional);
            this.Controls.Add(this.lbUTMTermHint);
            this.Controls.Add(this.tbUTMTerm);
            this.Controls.Add(this.lbUTMTerm);
            this.Controls.Add(this.lbUTMContentHint);
            this.Controls.Add(this.tbUTMContent);
            this.Controls.Add(this.lbUTMContent);
            this.Controls.Add(this.lbUTMCampaignHint);
            this.Controls.Add(this.tbUTMCampaign);
            this.Controls.Add(this.lbUTMCampaign);
            this.Controls.Add(this.lbUTMMediumHint);
            this.Controls.Add(this.tbUTMMedium);
            this.Controls.Add(this.lbUTMMedium);
            this.Controls.Add(this.lbUTMSourceHint);
            this.Controls.Add(this.tbUTMSource);
            this.Controls.Add(this.lbUTMSource);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lbURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(752, 704);
            this.Name = "frmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор UTM-меток";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerator_FormClosing);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbAdditionalTemplates.ResumeLayout(false);
            this.gbAdditionalTemplates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.RadioButton rbYandexSearch;
        private System.Windows.Forms.RadioButton rbYandexRSYA;
        private System.Windows.Forms.LinkLabel llYandexDirect;
        private System.Windows.Forms.RadioButton rbOblivkiBiz;
        private System.Windows.Forms.RadioButton rbKadam;
        private System.Windows.Forms.RadioButton rbRecreativ;
        private System.Windows.Forms.RadioButton rbTwitter;
        private System.Windows.Forms.RadioButton rbInstagram;
        private System.Windows.Forms.RadioButton rbFacebook;
        private System.Windows.Forms.RadioButton rbMailTarget;
        private System.Windows.Forms.RadioButton rbVK;
        private System.Windows.Forms.RadioButton rbGoogleKMS;
        private System.Windows.Forms.RadioButton rbGoogleAdWords;
        private System.Windows.Forms.LinkLabel llGoogleAdWords;
        private System.Windows.Forms.LinkLabel llVKTarget;
        private System.Windows.Forms.LinkLabel llMailTarget;
        private System.Windows.Forms.LinkLabel llFacebook;
        private System.Windows.Forms.LinkLabel llInstagram;
        private System.Windows.Forms.LinkLabel llTwitter;
        private System.Windows.Forms.LinkLabel llRecreativ;
        private System.Windows.Forms.LinkLabel llKadam;
        private System.Windows.Forms.LinkLabel llOblivkiBiz;
        private System.Windows.Forms.Label lbUTMSource;
        private System.Windows.Forms.TextBox tbUTMSource;
        private System.Windows.Forms.Label lbUTMSourceHint;
        private System.Windows.Forms.Label lbUTMMediumHint;
        private System.Windows.Forms.TextBox tbUTMMedium;
        private System.Windows.Forms.Label lbUTMMedium;
        private System.Windows.Forms.Label lbUTMCampaignHint;
        private System.Windows.Forms.TextBox tbUTMCampaign;
        private System.Windows.Forms.Label lbUTMCampaign;
        private System.Windows.Forms.Label lbUTMContentHint;
        private System.Windows.Forms.TextBox tbUTMContent;
        private System.Windows.Forms.Label lbUTMContent;
        private System.Windows.Forms.Label lbUTMTermHint;
        private System.Windows.Forms.TextBox tbUTMTerm;
        private System.Windows.Forms.Label lbUTMTerm;
        private System.Windows.Forms.Label lbUTMAdditionalHint;
        private System.Windows.Forms.TextBox tbUTMAdditional;
        private System.Windows.Forms.Label lbUTMAdditional;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lbTransliterationHint;
        private System.Windows.Forms.CheckBox cbTransliteration;
        private System.Windows.Forms.Label cbSlashPlaceHint;
        private System.Windows.Forms.CheckBox cbSlashPlace;
        private System.Windows.Forms.GroupBox gbAdditionalTemplates;
        private System.Windows.Forms.ListBox lbAdditionalTemplatesList;
        private System.Windows.Forms.Button btAdditionalTemplateInclude;
        private System.Windows.Forms.TextBox tbAdditionalTemplatesValue;
        private System.Windows.Forms.Label lbResultURL;
        private System.Windows.Forms.TextBox tbResultURL;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btCopy;
    }
}