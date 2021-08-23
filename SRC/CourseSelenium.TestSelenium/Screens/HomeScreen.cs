using System;
using Microsoft.Extensions.Configuration;
using CourseSelenium.TestSelenium.Utils;

namespace CourseSelenium.TestSelenium.Screens {

    public class HomeScreen : BaseScreen {

        public HomeScreen (IConfiguration configuration, Browser browser) : base(configuration, browser) {}
    
        
    }
}