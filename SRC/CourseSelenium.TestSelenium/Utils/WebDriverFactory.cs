using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CourseSelenium.TestSelenium.Utils {

    public static class WebDriverFactory {

        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver, bool headless) {
            IWebDriver webDriver = null;

            switch (browser)  {
                case Browser.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    
                    if (headless) {
                        chromeOptions.AddArguments ("--headless");
                    }

                    webDriver = new ChromeDriver(pathDriver, chromeOptions);    
                    break;
            
                case Browser.Firefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    
                    if (headless) {
                        firefoxOptions.AddArguments ("--headless");
                    }

                    webDriver = new FirefoxDriver(pathDriver, firefoxOptions);    
                    break;
            }         
                     
            return webDriver; 
        }
             
    }
}