using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using R700_Recordings_Test_Package_WebManager.PageOjects;
using SeleniumExtras.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.TestCases
{
    public class LogInTest
    {
        [Test]
        public void Test()
        {
            // Opening the browser to the specified server
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://192.168.53.204:9443");

            // Entering the username and password
            var loginPage = new LogInPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.LogIntoApplication();

            // Exiting the test if completed
            WebDriverWait serverHomepagewait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement serverHomepage = serverHomepagewait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("contentPage")));
            driver.Quit();
        }
    }
}
