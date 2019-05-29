using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace R700_Recordings_Test_Package_WebManager.PageOjects
{
    public class DomainsPage
    {
        private readonly IWebDriver driver;

        // Showing all the available encoders on the server
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/section[@class='status-bar']/div[@class='status-bar-body']/div[@class='surround'][2]/div[@class='overlay encoders']/span[@class='textbar']/p[1]/a[@class='baseLink ng-binding']")]
        public IWebElement AllEncoders { get; set; }

        public void ViewAllEncoders()
        {
            AllEncoders.Click();
        }
    }
}
