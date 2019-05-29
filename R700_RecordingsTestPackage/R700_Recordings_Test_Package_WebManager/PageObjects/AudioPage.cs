using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.PageOjects
{
    public class AudioPage
    {
        private readonly IWebDriver driver;

        // Editing Audio Settings
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec/audio/edit']")]
        public IWebElement EditAudioSettingsLink { get; set; }

        public void AudioSettings()
        {
            EditAudioSettingsLink.Click();
        }

        // Turning on Audio Streaming
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='viewer-timeout']/div[@class='ng-scope']/p[@class='radio'][1]/label")]
        public IWebElement AudioStreamingSettingOn { get; set; }

        public void AudioStreamingOn()
        {
            AudioStreamingSettingOn.Click();
        }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement AudioStreamingSubmission { get; set; }

        public void AudioStreamingSubmit()
        {
            AudioStreamingSubmission.Click();
        }

    }
}
