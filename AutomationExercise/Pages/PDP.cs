using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Pages
{
    class PDP
    {
        readonly IWebDriver  _driver;
        public By productDetails = By.ClassName("product-information");
        public By cart = By.ClassName("cart");
        public By productName = By.XPath("//*[@class = 'product-information']//h2");
        public By viewCart = By.XPath("//*[@id='cartModal']//a");
        public PDP(IWebDriver driver)

        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productDetails));

        }



    }
}
