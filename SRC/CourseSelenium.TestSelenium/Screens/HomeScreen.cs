using System;
using Microsoft.Extensions.Configuration;
using CourseSelenium.TestSelenium.Utils;
using OpenQA.Selenium;

namespace CourseSelenium.TestSelenium.Screens {

    public class HomeScreen : BaseScreen {

        public HomeScreen (IConfiguration configuration, Browser browser) : base(configuration, browser) {}

        public string GetServices() {
             WaitByHtml(TimeSpan.FromSeconds(15), By.Id ("servicos"));
             string response = _webDriver.GetHtml(By.Id ("servicos"));
             return response;

        }



    }
}