using System;
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
            const string text = "To jest mój tekst,<br/> który zawiera kod html";
            var stripper = new HtmlJavaScriptStripper();
            
            var strippedText = stripper.ProcessText(text);
        
            strippedText.Should().BeEquivalentTo("To jest mój tekst, który zawiera kod html");
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
            
            var strippedText = stripper.ProcessText(text);
        
            strippedText.Should().BeEquivalentTo("To jest mój tekst, który nie zawiera kodu html ani JavaScript");
        }
        
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void StripHtmlAndJavaScript_WhenTextIsNullOrEmpty_ShouldThrowArgumentNullException(string text)
        {
            var stripper = new HtmlJavaScriptStripper();
            
            Action action = () => stripper.ProcessText(text);
            
            action.Should().Throw<ArgumentNullException>();
        }
    }
}