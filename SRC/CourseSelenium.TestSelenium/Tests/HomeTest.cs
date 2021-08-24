using CourseSelenium.TestSelenium.Screens;
using CourseSelenium.TestSelenium.Utils;
using Xunit;

namespace CourseSelenium.TestSelenium.Tests {

    public class HomeTest : BaseTest {
        
        [Theory]
        [InlineData (Browser.Chrome)]
        public void DeveCarrellsTelaHomeComSucesso (Browser browser){
            HomeScreen homeScreen = new HomeScreen (_configuration, browser);    
            homeScreen.LoadScreen(_configuration.GetSection("Selenium:Urls:Home").Value);
            string response = homeScreen.GetServices();
            homeScreen.CloseScreen();

            Assert.True(!string.IsNullOrEmpty(response));
        
        }
           
    }
}