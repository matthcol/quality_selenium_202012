using System;
using System.Collections.Generic;
using System.Text;

namespace TestSeleniumMovieUI.PageModels
{
    public class MovieListPage: BasePage
    {
        private static string _path = "movies";
        public MovieListPage()
        {
            _webDriver.Navigate().GoToUrl(_baseUrl + _path);
        }
    }
}
