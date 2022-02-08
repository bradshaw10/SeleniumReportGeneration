using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace SeleniumHTMLResults
{
    [TestFixture]
    public class UnitTest1: TestBase
    {
        [Test]
        public void NopCommerceDummyTest()
        {
            Pages.Home.isAt();
            Pages.Home.GoToComputers();
            Pages.Computers.isAt();
            Pages.Computers.EnterSearchText("Search for me");
            Pages.Computers.ClickSearch();
        }
    }
}
