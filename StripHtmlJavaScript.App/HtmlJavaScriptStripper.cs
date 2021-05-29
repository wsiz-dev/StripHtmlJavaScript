using System;
using System.Text.RegularExpressions;

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

            return RemoveHtml(text);
        }
        
        private string RemoveHtml(string text)
        {
            return Regex.Replace(text, "<.*?>", "");
        }
    }
}