using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WEDDINGSHOP_TASK.PageObjects
{
   public class LoginPage
    {
        public LoginPage()

        {
            PageFactory.InitElements(Utilities.Hooks1.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "btn-nav-login")]
        private IWebElement login { get; set; }

        public void ClickLogin()
        {
            login.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='userName']")]
        private IWebElement emailaddress { get; set; }

        public void EnterEmailAddress()
        {
            emailaddress.SendKeys("Tjaychampion@yahoo.com");
        }
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement password { get; set; }

        public void EnterPassword()
        {
            password.SendKeys("Lateef2803");
        }

        [FindsBy(How = How.CssSelector, Using = "#btn-login")]
        private IWebElement loginbutton { get; set; }

        public void ClickLogniButtonn()
        {
            loginbutton.Click();
        }

      

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div[3]/div[1]")]
        private IWebElement message { get; set; }

        public bool MessageIsDisplayed()
        {
            return message.Displayed;
        }







    }
}
