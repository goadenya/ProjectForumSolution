using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services.Tools
{
    public class Tools : ITool
    {
        public string ShortenText(string text, int wordCount)
        {
            var textParts = text.Split(' ');
            if (textParts.Length > wordCount + 10)
            {
                var newText = "";
                for (int i = 0; i < wordCount; i++)
                {
                    newText += $"{textParts[i]} ";
                }
                return newText;
            }
            else
            {
                return text;
            }
        }
    }
}
