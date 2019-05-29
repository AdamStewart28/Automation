using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.PageOjects
{
    public class CameraConfigureChannelPage
    {
        private IWebDriver driver;

        // Submit button
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitButton { get; set; }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }

        // Checkbox to enable/disable the channel on the camera
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='form']/div[@class='policyGroup']/p[@class='radio']/label")]
        private IWebElement ChannelCheckbox { get; set; }

        public void ChannelEnabledDisabledCheckbox()
        {
            ChannelCheckbox.Click();
        }

        // Checkbox for available for recording on the camera
        [FindsBy(How = How.XPath, Using = "/html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='form']/div[@class='policyGroup ng-scope']/p[@class='radio']/label")]
        public IWebElement RecordingCheckbox { get; set; }

        public void AvailableForRecordingCheckbox()
        {
            RecordingCheckbox.Click();
        }

        // Frame Size dropdown menu
        [FindsBy(How = How.Id, Using = "dimensions")]
        public IWebElement FrameSize { get; set; }

        public void FrameSizeDropdown()
        {
            FrameSize.Click();
        }

        // Frame Size dropdown option
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='form']/div[@class='policyGroup ng-scope']/div[@class='ng-scope']/p[1]/select[@id='dimensions']/option[2]")]
        public IWebElement FrameSizeOption { get; set; }

        public void FrameSizeDropdownOption()
        {
            FrameSizeOption.Click();
        }

        // Frame Rate dropdown menu
        [FindsBy(How = How.Id, Using = "frame_step")]
        public IWebElement FrameRate { get; set; }

        public void FrameRateDropdown()
        {
            FrameRate.Click();
        }

        // Frame Rate dropdown option
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='form']/div[@class='policyGroup ng-scope']/div[@class='ng-scope']/p[2]/select[@id='frame_step']/option[2]")]
        public IWebElement FrameRateOption { get; set; }

        public void FrameRateDropdownOption()
        {
            FrameRateOption.Click();
        }

        // Bandwidth dropdown menu
        [FindsBy(How = How.Id, Using = "bandwidth")]
        public IWebElement Bandwidth { get; set; }

        public void BandwidthDropdown()
        {
            Bandwidth.Click();
        }

        // Frame Rate dropdown option
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='form']/div[@class='policyGroup ng-scope']/div[@class='ng-scope']/p[3]/select[@id='bandwidth']/option[2]")]
        public IWebElement BandwidthOption { get; set; }

        public void BandwidthDropdownOption()
        {
            BandwidthOption.Click();
        }
    }
}

