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
        FindProductpage findProductpage;

        public FindProductsSteps()

        {
            findProductpage = new FindProductpage();
        }

        [Then(@"I see more candles displayed")]
        public void ThenISeeMoreCandlesDisplayed()
        {
            findProductpage.ConfirmThatCandlesAreDisplayed();
        }


        [When(@"I click on search for ""(.*)"" and filter by price")]
        public void WhenIClickOnSearchForAndFilterByPrice(string p0)
        {
            findProductpage.EnterSearchQuery();
        }
        
        [Then(@"candles priced between £(.*)-£(.*) should be displayed")]
        public void ThenCandlesPricedBetween_ShouldBeDisplayed(int p0, int p1)
        {
           Assert.IsTrue(findProductpage.ProductIsDisplayed());
        }
    }
}
