using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using R700_Recordings_Test_Package_WebManager.PageOjects;
using SeleniumExtras.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.TestCases
{
    public class FrameSizeTest
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

            // Selecting a camera
            var cameraPage1 = new EncoderPage();
            PageFactory.InitElements(driver, cameraPage1);
            WebDriverWait Camera1Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Camera1Button = Camera1Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio/encoders/HDR700_Rec/channel/0']")));
            cameraPage1.SpecificCamera();

            // Changing the Framesize dropdown option
            var framesizeDropdownPage = new CameraConfigureChannelPage();
            PageFactory.InitElements(driver, framesizeDropdownPage);
            WebDriverWait framesizeDropdownPageWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement frameszieDropdownButton = framesizeDropdownPageWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dimensions")));
            framesizeDropdownPage.FrameSizeDropdown();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            framesizeDropdownPage.FrameSizeDropdownOption();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            framesizeDropdownPage.ClickSubmitButton();

            // Exiting the test if completed
            WebDriverWait serverHomepagewait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement serverHomepageWaitButton = serverHomepagewait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("contentPage")));
            driver.Quit();
        }
    }
}