using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestSeleniumMovieUI.PageModels
{
    public class BasePage
    {
        protected static string _baseUrl = "http://localhost:4200/";
        protected static IWebDriver _webDriver;

        protected static By _byActiveMenuAnchor = By.CssSelector("mat-toolbar a.active");

        public static void SetWebDriver(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string Title {
            get {
                return _webDriver.Title;
            }
        }

        public string NameActiveMenu
        {
            get => _webDriver.FindElement(_byActiveMenuAnchor).Text;
        }

    }
}
