using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Pages
{
    class HeaderPage
    {
        readonly IWebDriver _Driver;
        public By header = By.Id("header");
        public By LoginLink = By.ClassName("fa-lock");
        public By DeleteAcc = By.ClassName("fa-trash-o");
        public HeaderPage(IWebDriver driver)
        {
            this._Driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(header));
        }
    }
}
