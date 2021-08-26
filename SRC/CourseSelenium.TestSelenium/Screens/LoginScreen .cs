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

         public string GetUserLogin() {
             WaitByHtml(TimeSpan.FromSeconds (15), By.ClassName ("texto-branco"));
             string response = _webDriver.GetHtml (By.ClassName ("texto-branco"));
             return response;

        }
        public string GetErrorMensage() {
             WaitByHtml(TimeSpan.FromSeconds (15), By.Id ("mensagemDeErro"));
             string response = _webDriver.GetHtml (By.Id ("mensagemDeErro")).Trim();
             return response;
        }     

    }
}