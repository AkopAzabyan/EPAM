using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace selenium_webdriver
{
    [TestFixture]
    public class WebTests
    {
        public IWebDriver webDriver;

        [SetUp]
        public void StartBrowserAndGoToTheSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("https://www.onliner.by/");
        }

        [TearDown]
        public void QuitDriver()
        {
            webDriver.Quit();
        }

        [Test]
        // testCase1
        public void SearchProduct()
        { 
            var search = webDriver.FindElement(By.XPath("//input[@class = 'fast-search__input']"));
            search.SendKeys("Samsung Galaxy A50");
            search.SendKeys("\t");
            Thread.Sleep(5000);
           
        }

        [Test]  
        // testCase5
        public void addToCard()
        {
            var search = webDriver.FindElement(By.XPath("//input[@class = 'fast-search__input']"));
            search.SendKeys("Samsung Galaxy A50");
            search.SendKeys("\t");
            Thread.Sleep(8000);
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.CssSelector(".modal-iframe")));
            var getItem = webDriver.FindElements(By.CssSelector("a[class='product__title-link']"));
            getItem[0].Click();        
            var addToCard = webDriver.FindElements(By.CssSelector(".product-aside__item-button"))[0];
            addToCard.Click();

            Thread.Sleep(3000);


        }
    }
}
