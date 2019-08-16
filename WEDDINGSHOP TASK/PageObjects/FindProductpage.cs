using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WEDDINGSHOP_TASK.PageObjects
{
    public class FindProductpage
    {
        public FindProductpage()

        {
            PageFactory.InitElements(Utilities.Hooks1.Driver, this);
        }
        [FindsBy(How = How.Id, Using = "icon-nav-search")]
        private IWebElement search { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search-query")]
        private IWebElement searchquery { get; set; }

        [FindsBy(How = How.Id, Using = "product - filter - header - prices")]
        private IWebElement product { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul > li:nth-child(1) > div > div.group-section-dynamic > a > img")]
        private IWebElement candles { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#product-filter-items-prices > li:nth-child(2) > label > input")]
        private IWebElement SelectRange { get; set; }



        [FindsBy(How = How.CssSelector, Using = "#text-current-result-count")]
        private IWebElement DisplayedCandle { get; set; }
        //.product-grid__items__item
        internal void ConfirmThatCandlesAreDisplayed()
        {
            Assert.IsTrue(DisplayedCandle.Displayed);
        }

        //

        public void EnterSearchQuery()
        {
            search.Click();
           searchquery.SendKeys("Candles");
            searchquery.SendKeys(Keys.Enter);

            SelectRange.Click();


        }

 
        public bool ProductIsDisplayed()
        {
            return product.Displayed;
        }

    }
}
