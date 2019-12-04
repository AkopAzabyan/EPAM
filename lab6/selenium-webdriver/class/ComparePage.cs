using OpenQA.Selenium;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace PageObjectLab.PageObjects
{
    public class ComparePage
    {
        private IWebDriver webDriver;
        

        public ComparePage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public int getCountButtonAddToCart()
        {
            var elements = webDriver.FindElements(By.CssSelector(".button.offers-list__button.offers-list__button_basket"));
            return elements.Count;

        }

    
    }
}
