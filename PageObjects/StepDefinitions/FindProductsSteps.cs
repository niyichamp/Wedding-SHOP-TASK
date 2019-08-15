using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WEDDINGSHOP_TASK.PageObjects;
using WEDDINGSHOP_TASK.Utilities;

namespace WEDDINGSHOP_TASK.StepDefinitions
{
    [Binding]
    public class FindProductsSteps
    {
        FindProductpage FindProductpage;

        public FindProductsSteps()

        {
            FindProductpage = new FindProductpage();
        }
        [Given(@"I want candles in the £(.*)-£(.*) price range")]
        public void GivenIWantCandlesInThe_PriceRange(int p0, int p1)
        {
            Hooks1.Driver.Navigate().GoToUrl("https://www.weddingshop.com/");
            Hooks1.Driver.Manage().Window.Maximize();
            Hooks1.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);


            
        }
        
        [When(@"I click on search for ""(.*)"" and filter by price")]
        public void WhenIClickOnSearchForAndFilterByPrice(string p0)
        {
            FindProductpage.EnterSearchQuery();
        }
        
        [Then(@"candles priced between £(.*)-£(.*) should be displayed")]
        public void ThenCandlesPricedBetween_ShouldBeDisplayed(int p0, int p1)
        {
           Assert.IsTrue(FindProductpage.ProductIsDisplayed());
        }
    }
}
