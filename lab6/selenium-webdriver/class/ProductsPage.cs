using OpenQA.Selenium;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace PageObjectLab.PageObjects
{
    public class ProductsPage
    {
        private IWebDriver webDriver;

        public ProductsPage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public ComparePage clickCompareProducts()
        {
            var compare = webDriver.FindElement(By.CssSelector(".button.button_orange.button_big.product-aside__compare-button"));
            compare.Click();
            return new ComparePage(webDriver);
        }

    }
}
