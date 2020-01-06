using System;
using NUnit;
using NUnit.Framework;

namespace SeleniumDotNetCore.Tests
{
    //[TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]

    class FirstTest : TestFixtureBase
    {
        public FirstTest(BrowserType browserType):base(browserType)
        { }
        public override void TestSetup()
        {
            base.TestSetup();
            OpenBrowser();
        }
        [Test]
        public void FirstTestMethod()
        {
            Console.WriteLine("this is the first Test");

        }

        [Test]
        public void SecondTestMethod()
        {
            
            Console.WriteLine("this is the second test");
        }
    }
}
