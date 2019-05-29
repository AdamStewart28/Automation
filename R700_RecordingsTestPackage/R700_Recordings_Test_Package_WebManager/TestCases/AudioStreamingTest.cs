using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using R700_Recordings_Test_Package_WebManager.PageOjects;
using SeleniumExtras.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.TestCases
{
    public class AudioStreamingTest
    {
        [Test]
        public void Test()
        {
            // Opening the browser to the specified server
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://192.168.53.204:9443");

            // Entering the username and password and opening a domain
            var loginPage = new LogInPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.LogIntoApplication();

            // Selecting a Domain 
            var serverHomepage = new ServerHomepagePage();
            PageFactory.InitElements(driver, serverHomepage);
            WebDriverWait domainWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement domainButton = domainWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio']")));
            serverHomepage.ViewAllDomains();

            // Viewing all encoders
            var domainsPage = new DomainsPage();
            PageFactory.InitElements(driver, domainsPage);
            WebDriverWait AllDomainsWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement AllDomainsButton = AllDomainsWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/section[@class='status-bar']/div[@class='status-bar-body']/div[@class='surround'][2]/div[@class='overlay encoders']/span[@class='textbar']/p[1]/a[@class='baseLink ng-binding']")));
            domainsPage.ViewAllEncoders();

            // Selecing an encoder
            var encodersPage = new EncodersPage();
            PageFactory.InitElements(driver, encodersPage);
            WebDriverWait EncoderWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement EncoderButton = EncoderWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio/encoders/HDR700_Rec']")));
            encodersPage.SpecificEncoder();


            // Audio Settings
            var audioSettingsPage = new EncoderPage();
            PageFactory.InitElements(driver, audioSettingsPage);
            WebDriverWait AudioLink = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement AudioLinkButton = AudioLink.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio/encoders/HDR700_Rec/audio']")));
            audioSettingsPage.AudioSettings();

            // Edit Audio Settings
            var editAudioSettingsPage = new AudioPage();
            PageFactory.InitElements(driver, editAudioSettingsPage);
            WebDriverWait editAudioLink = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement EditAudioLinkButton = editAudioLink.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio/encoders/HDR700_Rec/audio/edit']")));
            editAudioSettingsPage.AudioSettings();

            // Turning on Audio Streaming
            var audioStreamingOnPage = new AudioPage();
            PageFactory.InitElements(driver, audioStreamingOnPage);
            WebDriverWait audioStreamingOn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement audioStreamingOnButton = audioStreamingOn.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='viewer-timeout']/div[@class='ng-scope']/p[@class='radio'][1]/label")));
            audioStreamingOnPage.AudioStreamingOn();
            audioStreamingOnPage.AudioStreamingSubmit();

            // Exiting the test if completed
            WebDriverWait serverHomepagewait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement serverHomepageWaitButton = serverHomepagewait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("contentPage")));
            driver.Quit();
        }
    }
}



