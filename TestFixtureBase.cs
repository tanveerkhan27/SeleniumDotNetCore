using System;
using System.Globalization;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumDotNetCore;
using System.Threading;

namespace SeleniumDotNetCore
{
    public enum BrowserType{Chrome, Firefox}
    class TestFixtureBase
    {
        private BrowserType _browserType;
        protected TestFixtureBase(BrowserType browserType)
        {
            _browserType = browserType;
        }

        protected TestFixtureBase()
        {

        }

        [SetUp]
        public virtual void TestSetup()
        {
            switch(_browserType)
            {
                case BrowserType.Chrome:
                FrameworkHelper.WebDriver = new ChromeDriver();
                break;

                case BrowserType.Firefox:
                FrameworkHelper.WebDriver = new FirefoxDriver();
                break;

                default:
                FrameworkHelper.WebDriver = new ChromeDriver();
                break;
            }
            FrameworkHelper.wait = new WebDriverWait(FrameworkHelper.WebDriver,TimeSpan.FromSeconds(120));
        }
        [TearDown]
        public void TestTearDown()
        {
            //kill process
        }

        internal void OpenBrowser()
        {
            FrameworkHelper.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(400);
            FrameworkHelper.WebDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(2000);

        }

        
    }
}