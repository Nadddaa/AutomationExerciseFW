using AutomationExercise.Helpers;
using AutomationExercise.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps 
{
    [Binding]
    public class AuthenticationSteps : Base
    {
        Utilities ut = new Utilities(Driver);
     HeaderPage hp = new HeaderPage(Driver);

        [Given(@"User opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElemnt(hp.LoginLink);  
        }
        
        [Given(@"user enters correct credentials")]
        public void GivenUserEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);

            ut.EnterTextInElement(ap.loginEmail, TestConstants.Username);
            ut.EnterTextInElement(ap.loginPassword, TestConstants.Password);
        }
        
        [When(@"user submits login form")]
        public void WhenUserSubmitsLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElemnt(ap.loginBtn);
           
        }
        
        [Then(@"user is logged in")]
        public void ThenUserIsLoggedIn()
        {
            Assert.True(ut.ElementDisplayed(hp.DeleteAcc), "User is NOT logged in");
        }
        [Given(@"enters '(.*)' name and valid email address")]
        public void GivenEntersNameAndValidEmailAddress(string name)
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.name, name);
            ut.EnterTextInElement(ap.signupEmail, ut.GenerateRandomEmail());
        }

        [Given(@"user lick on SignUp button")]
        public void GivenUserLickOnSignUpButton()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElemnt(ap.signupBtn);
        }

        [When(@"user fills in all required fields")]
        public void WhenUserFillsInAllRequiredFields()
        {
            SignUp sp = new SignUp(Driver);
            ut.EnterTextInElement(sp.password, TestConstants.Password);
            ut.EnterTextInElement(sp.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sp.lastName, TestConstants.LastName);
            ut.EnterTextInElement(sp.address , TestConstants.Address);
            ut.DropdownSelect(sp.country, TestConstants.Country);
            ut.EnterTextInElement(sp.state, TestConstants.State);
            ut.EnterTextInElement(sp.city, TestConstants.City);
            ut.EnterTextInElement(sp.zipcode, TestConstants.ZipCode);
            ut.EnterTextInElement(sp.mobile, TestConstants.Phone);
        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            SignUp sp = new SignUp(Driver);
            Driver.FindElement(sp.form).Submit();
                
                
                }

        [Then(@"user will get '(.*)' successs message")]
        public void ThenUserWillGetSuccesssMessage(string message)
        {
            AccountCreatedPage acp = new AccountCreatedPage(Driver);
            Assert.True(ut.TextPresentInElement(message)," USer did NOT get expected success message");
            ut.ClickOnElemnt(acp.continueBtn);
        }

    }

}
