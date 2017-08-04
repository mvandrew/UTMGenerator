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
        YANDEX_MEDIA = 1
    }
}