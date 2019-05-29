using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.PageOjects
{
    public class EncodersPage
    {
        private readonly IWebDriver driver;

        // (*CHANGE ENCODER ACCORDINGLY*)
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec']")]
        public IWebElement UserEncoder { get; set; }

        public void SpecificEncoder()
        {
            UserEncoder.Click();
        }
    }
}

