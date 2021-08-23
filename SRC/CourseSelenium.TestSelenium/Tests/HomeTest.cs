using CourseSelenium.TestSelenium.Screens;
using CourseSelenium.TestSelenium.Utils;
using Xunit;

namespace CourseSelenium.TestSelenium.Tests {

    public class HomeTest : BaseTest {
        public void DeveCarregarTelaHomeComSucesso(Browser browser)
        {
            DeveCarregarTelaHomeComSucesso(browser, new HomeScreen(_configuration, browser));
        }

        [Theory]
        [InlineData (Browser.Chrome)]

        public void DeveCarregarTelaHomeComSucesso (Browser browser, HomeScreen homeScreen) {
            homeScreen.LoadScreen(_configuration.GetSection("Selenium:Urls:Home").Value);
            homeScreen.CloseScreen();
        
        }

    
        
    }
}