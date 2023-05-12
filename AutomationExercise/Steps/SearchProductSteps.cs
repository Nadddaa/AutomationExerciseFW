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

        private readonly ProductData productData;

        public SearchProductSteps(ProductData productData)
        {
            this.productData = productData;

        }
        

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

        [When(@"opens a first search result")]
        public void WhenOpensAFirstSearchResult()
        {
            ProductPage pp = new ProductPage(Driver);
            ut.ClickOnElemnt(pp.productLink);
        }

        [When(@"clicks on add to cart button")]
        public void WhenClicksOnAddToCartButton()
        {
            PDP pdp = new PDP(Driver);

            productData.ProductName = ut.ReturnTextFromElement(pdp.productName);
            ut.ClickOnElemnt(pdp.cart);

        }

        [When(@"proceeds to the cart")]
        public void WhenProceedsToTheCart()
        {
            PDP pdp = new PDP(Driver);
            ut.ClickOnElemnt(pdp.viewCart);
        }

        [Then(@"the shopping cart will be displayed with the selected product")]
        public void ThenTheShoppingCartWillBeDisplayedWithTheSelectedProduct()
        {
            Assert.True(ut.TextPresentInElement(productData.ProductName), " expecyed product is not displayed in the cart");
        }
    }
}
