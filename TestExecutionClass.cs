using System;
using NUnit;
using NUnit.Framework;

namespace SeleniumDotNetCore
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]

    class TestExecutionClass : TestFixtureBase
    {
        public TestExecutionClass(BrowserType browserType):base(browserType)
        { }
        public override void TestSetup()
        {
            base.TestSetup();
            OpenBrowser();
        }
        [Test]
        public void FirstTest()
        {
            Console.WriteLine("this is the first Test");

        

        }

        [Test]
        public void SecondTest()
        {

        }
    }
}
