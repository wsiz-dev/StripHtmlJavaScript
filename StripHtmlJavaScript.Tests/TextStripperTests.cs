using FluentAssertions;
using StripHtmlJavaScript.App;
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
            const string text = "To jest mój tekst, który nie zawiera kodu html ani JavaScript";
            var stripper = new HtmlJavaScriptStripper();
            
            var strippedText = stripper.StripText(text);
        
            strippedText.Should().BeEquivalentTo("To jest mój tekst, który nie zawiera kodu html ani JavaScript");
        }
        
        [Fact]
        public void StripHtmlAndJavaScript_WhenTextIsNullOrEmpty_ShouldThrowArgumentNullException()
        {
        
        }
    }
}