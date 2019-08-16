using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WEDDINGSHOP_TASK.PageObjects;
using WEDDINGSHOP_TASK.Utilities;

namespace WEDDINGSHOP_TASK.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()

        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to www\. weddingshop\.com")]
        public void GivenINavigateToWww_Weddingshop_Com()
        {
            Hooks1.Driver.Navigate().GoToUrl("https://www.weddingshop.com/");
            Hooks1.Driver.Manage().Window.Maximize();
            Hooks1.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
        }
        
        [Given(@"I click on create a list")]
        public void GivenIClickOnCreateAList()
        {
           
           registrationPage.ClickCreatList();
        }
        
        [Given(@"I enter my title")]
        public void GivenIEnterMyTitle()
        {
            registrationPage.EnterTitle();
        }
        
        [Given(@"I enter my Firstname")]
        public void GivenIEnterMyFirstname()
        {
            registrationPage.EnterFirstName();
        }
        
        [Given(@"I enter my Lastname")]
        public void GivenIEnterMyLastname()
        {
            registrationPage.EnterSurName();
        }
        
        [Given(@"I enter where I hear about the site")]
        public void GivenIEnterWhereIHearAboutTheSite()
        {
            registrationPage.EnterAboutUs();
        }
        
        [Given(@"I enter my partners title")]
        public void GivenIEnterMyPartnersTitle()
        {
            registrationPage.EnterPartnerTitle();
        }
        
        [Given(@"I enter my partner firstname")]
        public void GivenIEnterMyPartnerFirstname()
        {
           registrationPage.EnterPartnerName ();
        }
        
        [Given(@"I enter my partner lastname")]
        public void GivenIEnterMyPartnerLastname()
        {
            registrationPage.EnterPartnerSurName();
        }
        
        [Given(@"I enter country location")]
        public void GivenIEnterCountryLocation()
        {
          registrationPage.EnterAddress();
        }
        
        [Given(@"I enter address/postcode")]
        public void GivenIEnterAddressPostcode()
        {
            
            registrationPage.EnterPostCodeAddress();
        }
        
        [Given(@"I enter contact number")]
        public void GivenIEnterContactNumber()
        {
            registrationPage.EnterContactNumber();
        }
        
        [Given(@"I enter wedding date")]
        public void GivenIEnterWeddingDate()
        {
           
            registrationPage.EnterOccasiondate();
        }
        
        [Given(@"I enter number of guest")]
        public void GivenIEnterNumberOfGuest()
        {
            registrationPage.EnterGuests();
        }
        
        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [Given(@"I Confirm Password")]
        public void GivenIConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            registrationPage.ClickSubmit();
        }
        
        [Then(@"I should be a registered user")]
        public void ThenIShouldBeARegisteredUser()
        {
           Assert.IsTrue(registrationPage.ConfirmRegistration());
        }
    }
}
