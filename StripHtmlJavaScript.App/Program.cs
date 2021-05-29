using System;

namespace StripHtmlJavaScript.App
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (!(args is {Length: 1}))
            {
                return;
            }
            
            var text = args[0];

            Console.WriteLine("Original text: {0}", text);
            
            //Console.WriteLine("Stripped text: {0}", strippedText);
        }
    }
}