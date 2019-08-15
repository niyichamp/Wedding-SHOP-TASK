using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WEDDINGSHOP_TASK.PageObjects
{
   public class RegistrationPage
    {
        public RegistrationPage()

        {
            PageFactory.InitElements(Utilities.Hooks1.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "btn-nav-create-a-list")]
        private IWebElement createlist { get; set; }

        public void ClickCreatList()
        {
            createlist.Click();
        }

        [FindsBy(How = How.Id, Using = "title")]
        private IWebElement title { get; set; }

        public void EnterTitle()
        {
            title.SendKeys("Mr");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='name']")]
        private IWebElement firtsname { get; set; }

        public void EnterFirstName()
        {
            firtsname.SendKeys("Tajudeen");
        }

        [FindsBy(How = How.Id, Using = "surname")]
        private IWebElement surname { get; set; }

        public void EnterSurName()
        {
            surname.SendKeys("Olasimbo");
        }
        [FindsBy(How = How.Id, Using = "referrerId")]
        private IWebElement aboutus { get; set; }

        public void EnterAboutUs()
        {
            aboutus.SendKeys("Bridebook");
        }

        [FindsBy(How = How.CssSelector, Using = "#partnerTitle")]
        private IWebElement partnertitle { get; set; }

        public void EnterPartnerTitle()
        {
            partnertitle.SendKeys("Miss");
        }

        [FindsBy(How = How.CssSelector, Using = "#partnerName")]
        private IWebElement partnername { get; set; }

        public void EnterPartnerName()
        {
            partnername.SendKeys("Bimbola");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='partnerSurname']")]
        private IWebElement partnersurname { get; set; }

        public void EnterPartnerSurName()
        {
            partnersurname.SendKeys("Amode");
        }

        [FindsBy(How = How.Id, Using = "find-address")]
        private IWebElement address { get; set; }

        public void EnterAddress()
        {
            address.SendKeys("United Kingdom");
        }

        [FindsBy(How = How.CssSelector, Using = "#find-address-manual")]
        private IWebElement entermaually { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#addess1")]
        private IWebElement address1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#addess2")]
        private IWebElement address2 { get; set; }

        [FindsBy(How = How.Id, Using = "addess3")]
        private IWebElement address3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='town']")]
        private IWebElement town { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='county']")]
        private IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='postcode']")]
        private IWebElement postcode { get; set; }

        public void EnterPostCodeAddress()
        {
            entermaually.Click();
            address1.SendKeys("17");
            address2.SendKeys("southmere");
            address3.SendKeys("drive");
            town.SendKeys("London");
            County.SendKeys("Greenwich");
            postcode.SendKeys("SE2 9AF");
            
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactNumber']")]
        private IWebElement contactnumber { get; set; }

        public void EnterContactNumber()
        {
            contactnumber.SendKeys("07539460018");
        }

        [FindsBy(How = How.CssSelector, Using = ".CalendarMonthGrid_month__horizontal:nth-child(2) tr:nth-child(4) > .CalendarDay:nth-child(5)")]
        private IWebElement occasiondate { get; set; }

        public void EnterOccasiondate()
        {
            occasiondate.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#numberOfGuests")]
        private IWebElement guests { get; set; }

        public void EnterGuests()
        {
            guests.SendKeys("102");
        }

        [FindsBy(How = How.CssSelector, Using ="#loginEmail")]
        private IWebElement email { get; set; }

        public void EnterEmail()
        {
            email.SendKeys("Tjaychampion@yahoo.com");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='loginPassword']")]
        private IWebElement password { get; set; }

        public void EnterPassword()
        {
            password.SendKeys("Lateef2803");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='password-confirm']")]
        private IWebElement confirmpassword { get; set; }

        public void EnterConfirmPassword()
        {
            confirmpassword.SendKeys("Lateef2803");
        }

        [FindsBy(How = How.Id, Using = "btn-register")]
        private IWebElement submit { get; set; }

        public void ClickSubmit()
        {
            submit.Click();
        }

















    }
}
