using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.PageOjects
{
    public class ServerHomepagePage
    {
        private readonly IWebDriver driver;

        // (*CHANGE DOMAIN ACCORDINGLY*)
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio']")]
        public IWebElement Domains { get; set; }

        public void ViewAllDomains()
        {
            Domains.Click();
        }

    }
}


