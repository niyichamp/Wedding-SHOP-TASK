using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [FindsBy(How = How.CssSelector, Using = "(//input[@type='checkbox'])[2]")]
        private IWebElement candles { get; set; }

        public void EnterSearchQuery()
        {
            search.Click();
           searchquery.SendKeys("Candles");
            searchquery.SendKeys(Keys.Enter);
            candles.Click();
        }

        [FindsBy(How = How.Id, Using = "product - filter - header - prices")]
        private IWebElement product { get; set; }

        public bool ProductIsDisplayed()
        {
            return product.Displayed;
        }

    }
}
