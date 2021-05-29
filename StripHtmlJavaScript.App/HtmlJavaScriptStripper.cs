using System;

namespace StripHtmlJavaScript.App
{
    public class HtmlJavaScriptStripper
    {
        public string ProcessText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            return text;
        }
    }
}