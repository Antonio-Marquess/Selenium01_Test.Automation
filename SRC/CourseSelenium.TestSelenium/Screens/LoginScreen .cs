using System;
using Microsoft.Extensions.Configuration;
using CourseSelenium.TestSelenium.Utils;
using OpenQA.Selenium;

namespace CourseSelenium.TestSelenium.Screens {

    public class LoginScreen : BaseScreen {

        public LoginScreen (IConfiguration configuration, Browser browser) : base(configuration, browser) {}

        public void SetText (string element, string Value) {
             _webDriver.SetText(By.Id (element), Value);
             
        
        }

        public void Submit () {
            _webDriver.Submit(By.Id ("entrar"));

        }

    }
}