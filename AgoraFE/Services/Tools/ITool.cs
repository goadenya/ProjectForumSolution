using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services.Tools
{
    interface ITool
    {
        string ShortenText(string text, int wordCount);
    }
}
