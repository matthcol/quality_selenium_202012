using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestSeleniumMovieUI
{
    [TestClass]
    public class MovieListTest
    {
        [TestMethod]
        public void MovieListReadTest()
        {
            using (IWebDriver webDriver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                webDriver.Navigate().GoToUrl("http://localhost:4200/movies");
                wait.Until(driver => driver.FindElement(By.CssSelector("mat-toolbar")).Displayed);
                var title = webDriver.Title;
                var menuActive = webDriver.FindElement(By.CssSelector("mat-toolbar a.active"));
                var menuBar = webDriver.FindElement(By.TagName("mat-toolbar"));
                var firstMenu = webDriver.FindElement(By.XPath("//mat-toolbar/a"));

                Assert.IsTrue(title.Equals("MovieApp"));
                Assert.IsTrue(menuActive.Text.Equals("Movies"));
            }
        }
    }
}
