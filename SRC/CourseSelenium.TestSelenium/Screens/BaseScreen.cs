using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using CourseSelenium.TestSelenium.Utils;

namespace CourseSelenium.TestSelenium.Screens {

    public class BaseScreen {

        protected readonly IConfiguration _configuration; 

        protected readonly Browser _browser; 

        protected IWebDriver _webDriver;  

        public BaseScreen (IConfiguration configuration, Browser browser) {
            _configuration = configuration;
            _browser = browser;

            _webDriver = WebDriverFactory.CreateWebDriver(browser, configuration.GetSection ("Selenium:Drivers:Path").value, false); 

        }
         
        public void CloseScreen () {
            _webDriver.Quit();
            _webDriver = null;

        }
        
    }
}