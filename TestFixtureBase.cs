using System;
using System.Globalization;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
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
            //string host = @"http://localhost:4444/wd/hub";
            RemoteSessionSettings caps = new RemoteSessionSettings();
            var chromeoptions = new ChromeOptions();
            switch(_browserType)
            {
                case BrowserType.Chrome:
                    //caps.AddMetadataSetting("browserName","chrome");
                    chromeoptions.AddArgument("no-sandbox");
                    FrameworkHelper.WebDriver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),chromeoptions);
                    break;

                case BrowserType.Firefox:
                    caps.AddMetadataSetting("browserName","firefox");
                    FrameworkHelper.WebDriver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),caps);
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
            //FrameworkHelper.WebDriver.Quit();
        }

        internal void OpenBrowser()
        {
            FrameworkHelper.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(400);
            FrameworkHelper.WebDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            Thread.Sleep(2000);

        }

        
    }
}