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

        

        }

        [Test]
        public void SecondTest()
        {

        }
    }
}
