using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestSeleniumMovieUI.PageModels;

namespace TestSeleniumMovieUI.TestUI
{
    [TestClass]
    public class MovieListTest
    {
        // private static IWebDriver _webDriver;
        private IWebDriver _webDriver;

        // [ClassInitialize]
        [TestInitialize]
        // public static void BeforeAll(TestContext context)
        public void BeforeEach()
        {
            _webDriver = new ChromeDriver();
            BasePage.SetWebDriver(_webDriver);
        }

        // [ClassCleanup]
        [TestCleanup]
        // public static void AfterAll()
        public void AfterEach()
        {
            _webDriver.Quit();
        }

        // Old Fashioned Test
        // [TestMethod]
        public void MovieListReadTest()
        {
            using (IWebDriver webDriver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                webDriver.Navigate().GoToUrl(@"http://localhost:4200/movies");
                wait.Until(driver => driver.FindElement(By.CssSelector("mat-toolbar")));
                var title = webDriver.Title;
                var menuActive = webDriver.FindElement(By.CssSelector("mat-toolbar a.active"));
                var menuBar = webDriver.FindElement(By.TagName("mat-toolbar"));
                var firstMenu = webDriver.FindElement(By.XPath("//mat-toolbar/a"));

                Assert.IsTrue(title.Equals("MovieApp"));
                Assert.IsTrue(menuActive.Text.Equals("Movies"));
            }
        }

        [TestMethod]
        public void PageTitleTest()
        {
            // Prepare
            MovieListPage page = new MovieListPage();
            // Arrange
            string expectedTitle = "MovieApp";
            // Assertions
            Assert.AreEqual(expectedTitle, page.Title);
        }

        [TestMethod]
        public void MenuMoviesActiveTest()
        {
            // Prepare
            MovieListPage page = new MovieListPage();
            // Arange
            string expectedNameActiveMenu = "Movies";
            // Assertions
            Assert.AreEqual(expectedNameActiveMenu, page.NameActiveMenu);
        }
    }
}
