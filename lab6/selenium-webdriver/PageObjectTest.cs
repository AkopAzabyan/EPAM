using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectLab.PageObjects;

namespace PageObjectLab
{
    public class PageObjectTest
    {
        private IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Close();
        }

        [Test]
        public void CompareOnProductPage()
        {
            var HomePage = new HomePage(webDriver);
            HomePage.GoToPage();
            var productsPage = HomePage.SearchProduct("Samsung Galaxy A50");
            var comparePage = productsPage.clickCompareProducts();
            int countElements = comparePage.getCountButtonAddToCart();
            Assert.IsTrue(countElements > 0);
        }

        [Test]
        public void CheckCoursPage()
        {
            var HomePage = new HomePage(webDriver);
            HomePage.GoToPage();
            var CheckCurrensyPage = HomePage.GoToCours();
            Assert.IsTrue(CheckCurrensyPage.getCoursDollars() > 0);           
        }
    }
}