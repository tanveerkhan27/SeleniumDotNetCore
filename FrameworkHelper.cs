using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumDotNetCore
{
    public enum ElementIdentifier{Id,Xpath};
    class FrameworkHelper
    {
        private static IWebDriver _webDriver;
        public static IWebDriver WebDriver
        {
            get{return _webDriver;}
            set{_webDriver = value;}
        }

        public static WebDriverWait wait;

        
    }
}