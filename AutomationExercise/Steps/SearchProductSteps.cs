using AutomationExercise.Helpers;
using AutomationExercise.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding]
    public class SearchProductSteps :Base
    {
        HeaderPage hp = new HeaderPage(Driver);
        Utilities ut = new Utilities(Driver);
        

        [Given(@"User is on products page")]

        public void GivenUserIsOnProductsPage()
        {
            ut.ClickOnElemnt(hp.productIcon);
        }
        
        [When(@"User types a term in the search box")]
        public void WhenUserTypesATermInTheSearchBox()
        {
            ProductPage pp = new ProductPage(Driver);
            ut.EnterTextInElement(pp.searchBar, TestConstants.Product);
        }
        
        [When(@"clicks on search icon")]
        public void WhenClicksOnSearchIcon()
        {
            ProductPage pp = new ProductPage(Driver);
            ut.ClickOnElemnt(pp.searchBtn);
        }
        
        [Then(@"Searched Products section will appear")]
        public void ThenSectionWillAppear()
        {
            ProductPage pp = new ProductPage(Driver);

            Assert.True(ut.ElementDisplayed(pp.searchedProductsTitle), "section did not appear");
        }
    }
}
