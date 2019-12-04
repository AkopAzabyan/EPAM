using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace PageObjectLab.PageObjects
{
    public class CheckCurrensyPage
    {
        private IWebDriver webDriver; 
        
        public CheckCurrensyPage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public float getCoursDollars()
        {
            var price = webDriver.FindElements(By.CssSelector(".value.rise b"));
            var text = Regex.Replace(price[0].Text, @"\D+", "", RegexOptions.ECMAScript);
            return float.Parse(text);
        }


    }
}
