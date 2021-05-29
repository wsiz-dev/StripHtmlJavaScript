using Xunit;

namespace StripHtmlJavaScript.Tests
{
    public class TextStripperTests
    {
        [Fact]
        public void StripHtmlAndJavaScript_WhenTextContainsHtml_ShouldRemoveHtmlCode()
        {
        
        }
        
        [Fact]
        public void StripHtmlAndJavaScript_WhenTextContainsJavaScript_ShouldRemoveJavaScriptCode()
        {
        
        }
        
        [Fact]
        public void StripHtmlAndJavaScript_WhenTextDoesntContainsHtmlNorJavaScript_ShouldNotChangeText()
        {
        
        }
        
        [Fact]
        public void StripHtmlAndJavaScript_WhenTextIsNullOrEmpty_ShouldThrowArgumentNullException()
        {
        
        }
    }
}