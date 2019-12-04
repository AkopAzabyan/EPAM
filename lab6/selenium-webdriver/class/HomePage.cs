using OpenQA.Selenium;
using System.Threading;

namespace PageObjectLab.PageObjects
{
    public class HomePage
    {
        private IWebDriver webDriver; 
        
        private string homeUrl = "https://www.onliner.by/";

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl(homeUrl);
        }

        public ProductsPage SearchProduct(string name)
        {
            var search = webDriver.FindElement(By.XPath("//input[@class = 'fast-search__input']"));
            search.SendKeys(name);
            search.SendKeys("\t");
            Thread.Sleep(8000);
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.CssSelector(".modal-iframe")));
            var getItem = webDriver.FindElement(By.CssSelector("a.product__title-link:nth-child(1)"));
            getItem.Click();

            return new ProductsPage(webDriver);
        }
        public CheckCurrensyPage GoToCours()
        {
            var getItem = webDriver.FindElement(By.CssSelector("a.b-top-navigation-informers__link:nth-child(1)"));
            getItem.Click();

            return new CheckCurrensyPage(webDriver);
        }


    }
}
