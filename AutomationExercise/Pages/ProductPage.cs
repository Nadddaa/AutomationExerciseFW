using AutomationExercise.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Pages
{
    class ProductPage :Base
    {
        readonly IWebDriver _driver;
        // dodaj advetismeny
        public By productsTitle = By.Id("advertisement");
        public By searchBar = By.Id("search_product");
        public By searchBtn = By.ClassName("fa-search");
        public By searchedProductsTitle = By.XPath("//*[@class='features_items']//*[contains(text(),'Searched Products')]");
        public By productLink = By.ClassName("fa-plus-square");
        

        public ProductPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productsTitle));
        }
    }
}
