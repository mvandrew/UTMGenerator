using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTMGeneratorLibrary
{
    /// <summary>
    /// Trafic Sources Types
    /// </summary>
    public enum SourcesTypes
    {
        /// <summary>
        /// Traffic source type isn't selected
        /// </summary>
        EMPTY = -1,

        /// <summary>
        /// Yandex Direct search traffic only
        /// </summary>
        YANDEX_SEARCH = 0,

        /// <summary>
        /// Yandex Direct media network traffic only
        /// </summary>
        YANDEX_MEDIA = 1,

        /// <summary>
        /// Google AdWords search traffic only
        /// </summary>
        GOOGLE_SEARCH = 2,

        /// <summary>
        /// Google AdWords KMS media network traffic only
        /// </summary>
        GOOGLE_MEDIA = 3,

        /// <summary>
        /// VKontakte target ads and public guest ads trafic traffic - Really stupid system!
        /// </summary>
        VK_TARGET = 4,

        /// <summary>
        /// Mail.ru target traffic - Crazy moderators ;)
        /// </summary>
        MAILRU_TARGET = 5,

        /// <summary>
        /// Facebook target ads traffic only
        /// </summary>
        FACEBOOK_TARGET = 6,

        /// <summary>
        /// Links in Instagram profiles
        /// </summary>
        INSTAGRAM = 7,

        /// <summary>
        /// Links in Twitter posts
        /// </summary>
        TWITTER_POST = 8,

        /// <summary>
        /// Recreativ teasers links
        /// </summary>
        RECREATIV = 9,

        /// <summary>
        /// Kadam teasers links
        /// </summary>
        KADAM = 10,

        /// <summary>
        /// OBLIVKI teasers links
        /// </summary>
        OBLIVKI = 11
    }
}