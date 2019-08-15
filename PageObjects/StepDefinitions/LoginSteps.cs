using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WEDDINGSHOP_TASK.PageObjects;

namespace WEDDINGSHOP_TASK.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage LoginPage;

        public LoginSteps()

        {
            LoginPage = new LoginPage();
        }
        [Given(@"I click on Login link")]
        public void GivenIClickOnLoginLink()
        {
            LoginPage.ClickLogin();
        }
        [Given(@"I enter Email address")]
        public void GivenIEnterEmailAddress()
        {
            LoginPage.EnterEmailAddress();
        }
        [Given(@"I enter  my Password")]
        public void GivenIEnterMyPassword()
        {
            LoginPage.EnterPassword();
        }

        [Given(@"I click on Login")]
        public void GivenIClickOnLogin()
        {
            LoginPage.ClickLogniButtonn();
        }
        
        [Then(@"the weddingshop homepage should be displayed")]
        public void ThenTheWeddingshopHomepageShouldBeDisplayed()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(LoginPage.MessageIsDisplayed(), "DON'T FORGET TO PUBLISH YOUR LIST WHEN YOU'RE READY");
        }
    }
}
