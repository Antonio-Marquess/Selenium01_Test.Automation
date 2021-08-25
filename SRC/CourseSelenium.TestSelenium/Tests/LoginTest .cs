using CourseSelenium.TestSelenium.Screens;
using CourseSelenium.TestSelenium.Utils;
using Xunit;

namespace CourseSelenium.TestSelenium.Tests {

    public class LoginTest : BaseTest {
        
        [Theory]
        [InlineData (Browser.Chrome, "pri", "teamo")]
        public void DeveRealizarLoginComSucesso (Browser browser, string login, string password){

            LoginScreen loginScreen = new LoginScreen (_configuration, browser); 
            string response = null;

            try {  
                loginScreen.LoadScreen (_configuration.GetSection ("Selenium:Urls:Login").Value);
                loginScreen.SetText ("login",login); 
                loginScreen.SetText ("senha",password); 
                loginScreen.Submit ();

            } catch (System.Exception ex) {
                throw ex;

            }finally {
                loginScreen.CloseScreen();
            }
            
            Assert.True(!string.IsNullOrEmpty (response));
        
        }
           
    }
}