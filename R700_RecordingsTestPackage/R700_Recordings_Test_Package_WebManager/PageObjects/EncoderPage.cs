using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.PageOjects
{
    public class EncoderPage
    {
        private readonly IWebDriver driver;

        // (*DEFAULTS TO INTERNAL CAMERA. CHANGE ACCORDINGLY*)
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec/channel/0']")]
        public IWebElement UserCamera { get; set; }

        public void SpecificCamera()
        {
            UserCamera.Click();
        }

        // Opening Audio Settings
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec/audio']")]
        public IWebElement AudioSettingsLink { get; set; }

        public void AudioSettings()
        {
            AudioSettingsLink.Click();
        }

        // Opening Storage Device Settings
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec/storage/devices']")]
        public IWebElement StorageSettingsLink { get; set; }

        public void StorageDevicesLink()
        {
            StorageSettingsLink.Click();
        }

    }
}
