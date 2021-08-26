using System;
using CourseSelenium.TestSelenium.Screens;
using CourseSelenium.TestSelenium.Utils;
using Xunit;

namespace CourseSelenium.TestSelenium.Tests {

    public class LoginTest : BaseTest {
        
        private readonly LoginScreen _loginScreen;
        
        public LoginTest() {
              _loginScreen = new LoginScreen (_configuration, Browser.Chrome);
        }
        
        [Theory]
        [InlineData ("Antonio-Marquess", "Ma26341578")]
        public void DeveRealizarLoginComSucesso (string login, string password) {
            
            string response = null;
            const string expected = "PRICILA ALVES ANTUNES BEM VIDA AO PORTAL DO ALUNO DA ESCOLA <strong>ECO APRENDER</strong>";

            try {  
                _loginScreen.LoadScreen (_configuration.GetSection ("Selenium:Urls:Login").Value);
                _loginScreen.SetText ("login",login); 
                _loginScreen.SetText ("senha",password); 
                _loginScreen.Submit ();
                response = _loginScreen.GetUserLogin ();

            } catch (System.Exception ex) {
                throw ex;

            }finally {
                _loginScreen.CloseScreen ();
            }
            
            Assert.True(!string.IsNullOrEmpty (response));
            Assert.Equal (response, expected); 
        }

        [Theory]
        [InlineData ("pri", "teamo")]
        [InlineData ("usuario_errado", "senha_errada")]
        [InlineData ("pri", "teamo")]
        public void DeveExibirUmaMensagemErroQuandoUsuarioSenhaInvalido (string login, string password) {
            
            string response = null;
            const string expected = "Usuario ou Senha não encontrada!";

            try {  
                _loginScreen.LoadScreen (_configuration.GetSection ("Selenium:Urls:Login").Value);
                _loginScreen.SetText ("login",login); 
                _loginScreen.SetText ("senha",password); 
                _loginScreen.Submit ();
                response = _loginScreen.GetUserLogin ();
                _loginScreen.TakeScreenshot (@"c:\Screenshot\", $"DeveExibirUmaMensagemErroQuandoUsuarioSenhaInvalido {DateTime.Now.ToString ("dd_MM_yyyy_HH_mm_ss")}.png");

            } catch (System.Exception ex) {
                throw ex;

            }finally {
                _loginScreen.CloseScreen ();
            }
            Assert.True (!string.IsNullOrEmpty (response));
            Assert.Equal (response, expected);   
        }
    
    }
}