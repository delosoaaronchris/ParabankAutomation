using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParabankAutomation.Framework.Pages;

namespace ParabankAutomation
{
    public class Tests
    {
        public IWebDriver driver;
        public static string BaseURL = "https://parabank.parasoft.com/parabank/index.htm";

        [SetUp]
        public void Setup()
        {            
            // Initialize the WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BaseURL);
            Thread.Sleep(1000);
        }

        [Test]
        public void NavigationTest()
        {
            var homePageElements = new HomePageElements(driver);
            homePageElements.aboutUsButton.Click();
            Thread.Sleep(1000);
            homePageElements.servicesElem.Click();
            Thread.Sleep(1000);
            homePageElements.productsElem.Click();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl(BaseURL);
            Thread.Sleep(1000);
            homePageElements.locationsElem.Click();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl(BaseURL);
            Thread.Sleep(1000);
            homePageElements.adminPageElem.Click();
            Thread.Sleep(1000);
            homePageElements.paraBankLogo.Click();
            Thread.Sleep(1000);
            homePageElements.homeLogoButton.Click();
            Thread.Sleep(1000);
            homePageElements.aboutUsLogoButton.Click();
            Thread.Sleep(1000);
            homePageElements.contactLogoButton.Click();
            Thread.Sleep(1000);


            Thread.Sleep(5000);

            driver.Quit();
    

        }


    }
}