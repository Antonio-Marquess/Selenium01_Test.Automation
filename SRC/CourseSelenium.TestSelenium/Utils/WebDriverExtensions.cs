using System;
using OpenQA.Selenium;

namespace CourseSelenium.TestSelenium.Utils {

    public static class WebDriverExtensions {

        public static void LoadPage (this IWebDriver webDriver, TimeSpan timeToWait, string url) {
            webDriver.Manage ().Timeouts ().PageLoad = timeToWait;
            webDriver.Navigate (). GoToUrl(url);
        }  

        public static string GetHtml (this IWebDriver webDriver, By by) {
            IWebElement webElement = webDriver.FindElement(by);
            return webElement.GetAttribute("innerHTML");
        } 

        public static void SetText (this IWebDriver webDriver, By by, string Value) {
            IWebElement webElement = webDriver.FindElement (by);
            webElement.SendKeys (Value);
        }

        public static void Submit (this IWebDriver webDriver, By by) {
            IWebElement webElement = webDriver.FindElement (by);
            webElement.Submit ();
        }


        
    }
}