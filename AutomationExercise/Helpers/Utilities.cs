﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Helpers
{
    public class Utilities
    {
        readonly IWebDriver _driver;
        private static readonly Random RandomName = new Random();
        public Utilities(IWebDriver driver)
  
        {
            this._driver = driver;
        }

        public string GenerateRandomEmail()
        {

            return string.Format("email{0}@mailinator.com", RandomName.Next(10000,100000));
        }
        public void ClickOnElemnt(By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator)).Click();

        }
        public void EnterTextInElement(By locator, string text)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

        public bool ElementDisplayed(By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).Displayed;
        }

        public void DropdownSelect(By select, string option)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            var dropdown = _driver.FindElement(select);
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByValue(option);
        }

        public bool TextPresentInElement(string text)
        {
            By headline = By.XPath("//*[contains(text(),'" +text+ "')]");

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(headline)).Displayed;

        }

    }

}
