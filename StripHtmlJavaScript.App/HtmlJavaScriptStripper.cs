using System;
using System.Text.RegularExpressions;

namespace StripHtmlJavaScript.App
{
    public class HtmlJavaScriptStripper
    {
        public static string ProcessText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            if (text.Contains("<script"))
            {
                text = RemoveJavaScript(text);
            }

            return RemoveHtml(text);
        }

        private static string RemoveHtml(string text)
        {
            return Regex.Replace(text, "<.*?>", "");
        }

        private static string RemoveJavaScript(string text)
        {
            return Regex.Replace(text, @"<script.*?</script>", "");
        }
    }
}