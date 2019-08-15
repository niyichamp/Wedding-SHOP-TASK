using System;
using System.Threading;
using TechTalk.SpecFlow;
using WEDDINGSHOP_TASK.PageObjects;
using WEDDINGSHOP_TASK.Utilities;

namespace WEDDINGSHOP_TASK.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage RegistrationPage;

        public RegistrationSteps()

        {
            RegistrationPage = new RegistrationPage();
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
           
           RegistrationPage.ClickCreatList();
        }
        
        [Given(@"I enter my title")]
        public void GivenIEnterMyTitle()
        {
            RegistrationPage.EnterTitle();
        }
        
        [Given(@"I enter my Firstname")]
        public void GivenIEnterMyFirstname()
        {
            RegistrationPage.EnterFirstName();
        }
        
        [Given(@"I enter my Lastname")]
        public void GivenIEnterMyLastname()
        {
            RegistrationPage.EnterSurName();
        }
        
        [Given(@"I enter where I hear about the site")]
        public void GivenIEnterWhereIHearAboutTheSite()
        {
            RegistrationPage.EnterAboutUs();
        }
        
        [Given(@"I enter my partners title")]
        public void GivenIEnterMyPartnersTitle()
        {
            RegistrationPage.EnterPartnerTitle();
        }
        
        [Given(@"I enter my partner firstname")]
        public void GivenIEnterMyPartnerFirstname()
        {
           RegistrationPage.EnterPartnerName ();
        }
        
        [Given(@"I enter my partner lastname")]
        public void GivenIEnterMyPartnerLastname()
        {
            RegistrationPage.EnterPartnerSurName();
        }
        
        [Given(@"I enter country location")]
        public void GivenIEnterCountryLocation()
        {
          RegistrationPage.EnterAddress();
        }
        
        [Given(@"I enter address/postcode")]
        public void GivenIEnterAddressPostcode()
        {
            Thread.Sleep(3000);
            RegistrationPage.EnterPostCodeAddress();
        }
        
        [Given(@"I enter contact number")]
        public void GivenIEnterContactNumber()
        {
            RegistrationPage.EnterContactNumber();
        }
        
        [Given(@"I enter wedding date")]
        public void GivenIEnterWeddingDate()
        {
            Thread.Sleep(3000);
            RegistrationPage.EnterOccasiondate();
        }
        
        [Given(@"I enter number of guest")]
        public void GivenIEnterNumberOfGuest()
        {
            RegistrationPage.EnterGuests();
        }
        
        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
            RegistrationPage.EnterEmail();
        }
        
        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            RegistrationPage.EnterPassword();
        }
        
        [Given(@"I Confirm Password")]
        public void GivenIConfirmPassword()
        {
            RegistrationPage.EnterConfirmPassword();
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            RegistrationPage.ClickSubmit();
        }
        
        [Then(@"I should be a registered user")]
        public void ThenIShouldBeARegisteredUser()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
