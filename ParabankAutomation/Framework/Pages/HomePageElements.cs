using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParabankAutomation.Framework.Pages
{
    public class HomePageElements
    {
        private IWebDriver _driver;
        public HomePageElements(IWebDriver driver)
        {
            _driver= driver;
        }
        public IWebElement paraBankLogo
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='topPanel']//img[@alt='ParaBank']"));

            }
        }
        public IWebElement SolutionElement
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//li[@class='Solutions']"));

            }
        }
        public IWebElement aboutUsButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[2]/a"));

            }
        }
        public IWebElement servicesElem
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[3]/a"));

            }
        }
        public IWebElement productsElem
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//a[@href='http://www.parasoft.com/jsp/products.jsp']"));

            }
        }
        public IWebElement locationsElem
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));

            }
        }
        public IWebElement adminPageElem
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[6]/a"));

            }
        }
        public IWebElement homeLogoButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[6]/a"));

            }
        }
        public IWebElement aboutUsLogoButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[6]/a"));

            }
        }
        public IWebElement contactLogoButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[6]/a"));

            }
        }
    }
}
